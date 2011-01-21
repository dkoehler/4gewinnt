using customControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4gewinnt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.nudCols.Value = (decimal)gpMain.gridColumns;
            this.nudRows.Value = (decimal)gpMain.gridRows;
        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            gpMain.gridRows = (int)nudRows.Value;
            gpMain.ResetGrid();
        }

        private void nudCols_ValueChanged(object sender, EventArgs e)
        {
            gpMain.gridColumns = (int)nudCols.Value;
            gpMain.ResetGrid();
        }
    }
}
