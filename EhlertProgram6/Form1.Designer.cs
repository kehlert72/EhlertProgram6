namespace EhlertProgram6
{
    partial class frmImage
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
            this.picDaisy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDaisy)).BeginInit();
            this.SuspendLayout();
            // 
            // picDaisy
            // 
            this.picDaisy.Image = global::EhlertProgram6.Properties.Resources.DaisyImage;
            this.picDaisy.Location = new System.Drawing.Point(25, 9);
            this.picDaisy.Name = "picDaisy";
            this.picDaisy.Size = new System.Drawing.Size(220, 214);
            this.picDaisy.TabIndex = 0;
            this.picDaisy.TabStop = false;
            this.picDaisy.Click += new System.EventHandler(this.picDaisy_Click);
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.picDaisy);
            this.Name = "frmImage";
            this.Text = "Click to Filter Image";
            ((System.ComponentModel.ISupportInitialize)(this.picDaisy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDaisy;
    }
}

