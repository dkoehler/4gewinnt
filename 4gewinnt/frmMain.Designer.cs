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
            this.gamepanel1 = new _4gewinnt.gamepanel(this.components);
            this.SuspendLayout();
            // 
            // gamepanel1
            // 
            this.gamepanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamepanel1.BrushColor = System.Drawing.Color.Black;
            this.gamepanel1.Location = new System.Drawing.Point(222, 78);
            this.gamepanel1.Name = "gamepanel1";
            this.gamepanel1.showGridlines = true;
            this.gamepanel1.Size = new System.Drawing.Size(350, 300);
            this.gamepanel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 494);
            this.Controls.Add(this.gamepanel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _4gewinnt.gamepanel gamepanel1;

    }
}

