using customControls;

namespace _4gewinnt
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.gpMain = new customControls.gamepanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCols
            // 
            this.nudCols.Location = new System.Drawing.Point(199, 65);
            this.nudCols.Name = "nudCols";
            this.nudCols.Size = new System.Drawing.Size(55, 20);
            this.nudCols.TabIndex = 2;
            this.nudCols.ValueChanged += new System.EventHandler(this.nudCols_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(199, 39);
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(55, 20);
            this.nudRows.TabIndex = 5;
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(158, 39);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(37, 13);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows:";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(158, 65);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(30, 13);
            this.lblCols.TabIndex = 7;
            this.lblCols.Text = "Cols:";
            // 
            // gpMain
            // 
            this.gpMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gpMain.BrushColor = System.Drawing.Color.Black;
            this.gpMain.fieldFillType = customControls.gamepanel.FieldType.CIRCLE;
            this.gpMain.gridColumns = 7;
            this.gpMain.gridFieldHeight = 50;
            this.gpMain.gridFieldWidth = 50;
            this.gpMain.gridRows = 6;
            this.gpMain.Location = new System.Drawing.Point(280, 12);
            this.gpMain.Name = "gpMain";
            this.gpMain.showGridlines = true;
            this.gpMain.Size = new System.Drawing.Size(350, 300);
            this.gpMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 424);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudCols);
            this.Controls.Add(this.gpMain);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gamepanel gpMain;
        private System.Windows.Forms.NumericUpDown nudCols;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;



    }
}

