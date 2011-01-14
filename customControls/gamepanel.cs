using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customControls
{
    public partial class gamepanel : UserControl
    {
        #region constuctors

        public gamepanel()
        {
            InitializeComponent();
            abFields = new bool[iRows * iColumns];
            this.Size = new Size(iColumns * iFieldWidth, iRows * iFieldHeight);
            objBmp = new Bitmap(this.Width, this.Height);
            objGraphic = Graphics.FromImage(objBmp);
        }

        // constructor for IContainer interfaces...

        public gamepanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            abFields = new bool[iRows * iColumns];
            this.Size = new Size(iColumns * iFieldWidth, iRows * iFieldHeight);
            objBmp = new Bitmap(this.Width, this.Height);
            objGraphic = Graphics.FromImage(objBmp);
        }

        #endregion

        #region properties

        // unsigned int won't work because of stupid compiler, lol
        int iRows = 6;
        int iColumns = 7;
        int iFieldHeight = 50;
        int iFieldWidth = 50;

        public enum FieldType
        {
            CIRCLE,
            BOX
        }

        int iInnerFieldHeight = 35; 
        int iInnerFieldWidth = 35;

        bool[] abFields;
        bool bDrawGrid;

        FieldType ftType;
        SolidBrush objBrush = new SolidBrush(Color.Black);

        //public event EventHandler evtInsertedStone;
        //public event EventHandler evtGameOver;

        private Bitmap objBmp;
        private Graphics objGraphic;

        public FieldType fieldFillType
        {
            get
            {
                return ftType;
            }
            set
            {
                ftType = value;
            }
        }

        public Color BrushColor
        {
            get
            {
                return objBrush.Color;
            }
            set
            {
                objBrush.Color = value;
            }
        }

        public bool showGridlines
        {
            get
            {
                return bDrawGrid;
            }
            set
            {
                bDrawGrid = value;
                this.Refresh(); // On change -> refresh control
            }
        }

        public int gridColumns
        {
            get
            {
                return iColumns;
            }
            set
            {
                iColumns = value;
                this.Refresh();
            }
        }

        public int gridRows
        {
            get
            {
                return iRows;
            }
            set
            {
                iRows = value;
                this.Refresh();
            }
        }

        public int gridFieldHeight
        {
            get
            {
                return iFieldHeight;
            }
            set
            {
                iFieldHeight = value;
                this.Refresh();
            }
        }

        public int gridFieldWidth
        {
            get
            {
                return iFieldWidth;
            }
            set
            {
                iFieldWidth = value;
                this.Refresh();
            }
        }

        #endregion

        #region OnHandlers

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            this.Size = new Size(iColumns * iFieldWidth, iRows * iFieldHeight);

            if (bDrawGrid)
                DrawGrid(pe.Graphics);
            pe.Graphics.DrawImage(objBmp, 0, 0);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            GetField(e.Location, objGraphic);
        }

        #endregion

        #region privateMethods

        private void DrawGrid(Graphics objGraph)
        {
            this.BorderStyle = BorderStyle.Fixed3D;

            for (int i = iFieldHeight; i < (iRows * iFieldHeight); i += iFieldHeight)
                objGraph.DrawLine(new Pen(Brushes.Black), new Point(0, i), new Point(this.Width, i));

            for (int i = iFieldWidth; i < (iColumns * iFieldWidth); i += iFieldWidth)
                objGraph.DrawLine(new Pen(Brushes.Black), new Point(i, 0), new Point(i, this.Height));
        }

        #endregion

        private void GetField(Point objPt, Graphics objGraph)
        {
            int x = objPt.X / iFieldWidth;
            int y = objPt.Y / iFieldHeight;

            int fieldNum = y * iColumns + x;

            if (fieldNum < (iRows * iColumns) - iColumns && !abFields[fieldNum + iColumns] || abFields[fieldNum])
                return;

            Point objPts = new Point(x * iFieldWidth + iFieldWidth / 2 - iInnerFieldWidth / 2,
                y * iFieldHeight + iFieldHeight / 2 - iInnerFieldHeight / 2);

            if (ftType == FieldType.CIRCLE)
                objGraph.FillEllipse(objBrush, new Rectangle(objPts, new Size(iInnerFieldWidth, iInnerFieldHeight)));
            else
                objGraph.FillRectangle(objBrush, new Rectangle(objPts, new Size(iInnerFieldWidth, iInnerFieldHeight)));

            abFields[fieldNum] = true;

            Graphics objNewGraph = this.CreateGraphics();
            objNewGraph.DrawImage(objBmp, 0, 0);
            objNewGraph.Dispose();
        }

        #region publicMethods

        // reset game grid
        public void ResetGrid()
        {
            Graphics objClearGraph = this.CreateGraphics();
            objClearGraph.Clear(this.BackColor);

            DrawGrid(this.CreateGraphics());

            for (int i = 0; i < abFields.Length; i++)
                abFields[i] = false;
        }

        #endregion
    }
}
