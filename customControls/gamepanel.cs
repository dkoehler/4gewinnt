﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customControls
{
    public partial class gamepanel : Panel
    {
        // constuctor

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

        // properties
        // unsigned int won't work because of stupid compiler, lol
        int iRows = 6;
        int iColumns = 7;
        int iFieldHeight = 50;
        int iFieldWidth = 50;

        public enum FieldType
        {
            BOX,
            CROSS,
            CIRCLE
        }

        // for drawing selected fields in grid later...
        //int iInnerFieldHeight = 35; 
        //int iInnerFieldWidth = 35;

        bool[] abFields;
        bool bDrawGrid;

        //FieldType ftType;
        SolidBrush objBrush = new SolidBrush(Color.Black);

        //public event EventHandler evtInsertedStone;
        //public event EventHandler evtGameOver;

        private Bitmap objBmp;
        private Graphics objGraphic;

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

        // methods
        private void DrawGrid(Graphics objGraph)
        {
            this.BorderStyle = BorderStyle.Fixed3D;

            for (int i = iFieldHeight; i < (iRows * iFieldHeight); i += iFieldHeight)
                objGraph.DrawLine(new Pen(Brushes.Black), new Point(0, i), new Point(this.Width, i));

            for (int i = iFieldWidth; i < (iColumns * iFieldWidth); i += iFieldWidth)
                objGraph.DrawLine(new Pen(Brushes.Black), new Point(i, 0), new Point(i, this.Height));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            this.Size = new Size(iColumns * iFieldWidth, iRows * iFieldHeight);

            if (bDrawGrid)
                DrawGrid(pe.Graphics);
            pe.Graphics.DrawImage(objBmp, 0, 0);
        }

        public void ClearGrid()
        {
            Graphics objClearGraph = this.CreateGraphics();
            objClearGraph.Clear(this.BackColor);

            DrawGrid(this.CreateGraphics());
        }
    }
}