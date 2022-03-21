namespace PrakWeek5
{
    partial class FormError
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
            this.lbPesan = new System.Windows.Forms.Label();
            this.vtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPesan
            // 
            this.lbPesan.AutoSize = true;
            this.lbPesan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPesan.Location = new System.Drawing.Point(24, 45);
            this.lbPesan.Name = "lbPesan";
            this.lbPesan.Size = new System.Drawing.Size(168, 45);
            this.lbPesan.TabIndex = 0;
            this.lbPesan.Text = "Sudah ada";
            // 
            // vtnClose
            // 
            this.vtnClose.Location = new System.Drawing.Point(193, 133);
            this.vtnClose.Name = "vtnClose";
            this.vtnClose.Size = new System.Drawing.Size(75, 23);
            this.vtnClose.TabIndex = 1;
            this.vtnClose.Text = "Close";
            this.vtnClose.UseVisualStyleBackColor = true;
            this.vtnClose.Click += new System.EventHandler(this.vtnClose_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 190);
            this.Controls.Add(this.vtnClose);
            this.Controls.Add(this.lbPesan);
            this.Name = "FormError";
            this.Text = "Eror!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPesan;
        private System.Windows.Forms.Button vtnClose;
    }
}