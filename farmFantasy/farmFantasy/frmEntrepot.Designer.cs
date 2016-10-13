namespace farmFantasy
{
    partial class frmEntrepot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxEntrepot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxEntrepot
            // 
            this.tbxEntrepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEntrepot.Location = new System.Drawing.Point(12, 12);
            this.tbxEntrepot.Multiline = true;
            this.tbxEntrepot.Name = "tbxEntrepot";
            this.tbxEntrepot.ReadOnly = true;
            this.tbxEntrepot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxEntrepot.Size = new System.Drawing.Size(278, 252);
            this.tbxEntrepot.TabIndex = 0;
            // 
            // frmEntrepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 276);
            this.Controls.Add(this.tbxEntrepot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrepot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dans la grange";
            this.Load += new System.EventHandler(this.frmEntrepot_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEntrepot_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEntrepot;
    }
}