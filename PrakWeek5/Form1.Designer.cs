namespace PrakWeek5
{
    partial class FormMateri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbData = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.listData = new System.Windows.Forms.ListBox();
            this.rdBiru = new System.Windows.Forms.RadioButton();
            this.rdMerah = new System.Windows.Forms.RadioButton();
            this.ckAktif = new System.Windows.Forms.CheckBox();
            this.lbOutput1 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.lbKoleksi = new System.Windows.Forms.Label();
            this.lbSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(37, 38);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(34, 15);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(390, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(81, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(284, 23);
            this.txtInput.TabIndex = 2;
            // 
            // listData
            // 
            this.listData.FormattingEnabled = true;
            this.listData.ItemHeight = 15;
            this.listData.Location = new System.Drawing.Point(45, 105);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(232, 199);
            this.listData.TabIndex = 3;
            this.listData.SelectedIndexChanged += new System.EventHandler(this.listData_SelectedIndexChanged);
            // 
            // rdBiru
            // 
            this.rdBiru.AutoSize = true;
            this.rdBiru.Location = new System.Drawing.Point(359, 128);
            this.rdBiru.Name = "rdBiru";
            this.rdBiru.Size = new System.Drawing.Size(83, 19);
            this.rdBiru.TabIndex = 4;
            this.rdBiru.TabStop = true;
            this.rdBiru.Text = "Warna Biru";
            this.rdBiru.UseVisualStyleBackColor = true;
            this.rdBiru.CheckedChanged += new System.EventHandler(this.rdBiru_CheckedChanged);
            // 
            // rdMerah
            // 
            this.rdMerah.AutoSize = true;
            this.rdMerah.Location = new System.Drawing.Point(359, 103);
            this.rdMerah.Name = "rdMerah";
            this.rdMerah.Size = new System.Drawing.Size(96, 19);
            this.rdMerah.TabIndex = 5;
            this.rdMerah.TabStop = true;
            this.rdMerah.Text = "Warna Merah";
            this.rdMerah.UseVisualStyleBackColor = true;
            this.rdMerah.CheckedChanged += new System.EventHandler(this.rdMerah_CheckedChanged);
            // 
            // ckAktif
            // 
            this.ckAktif.AutoSize = true;
            this.ckAktif.Location = new System.Drawing.Point(390, 84);
            this.ckAktif.Name = "ckAktif";
            this.ckAktif.Size = new System.Drawing.Size(51, 19);
            this.ckAktif.TabIndex = 6;
            this.ckAktif.Text = "Aktif";
            this.ckAktif.UseVisualStyleBackColor = true;
            this.ckAktif.CheckedChanged += new System.EventHandler(this.ckAktif_CheckedChanged);
            // 
            // lbOutput1
            // 
            this.lbOutput1.AutoSize = true;
            this.lbOutput1.Location = new System.Drawing.Point(333, 179);
            this.lbOutput1.Name = "lbOutput1";
            this.lbOutput1.Size = new System.Drawing.Size(48, 15);
            this.lbOutput1.TabIndex = 7;
            this.lbOutput1.Text = "Output:";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOutput.Location = new System.Drawing.Point(333, 194);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(105, 45);
            this.lbOutput.TabIndex = 8;
            this.lbOutput.Text = "label3";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(333, 281);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(189, 23);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbKoleksi
            // 
            this.lbKoleksi.AutoSize = true;
            this.lbKoleksi.Location = new System.Drawing.Point(44, 79);
            this.lbKoleksi.Name = "lbKoleksi";
            this.lbKoleksi.Size = new System.Drawing.Size(47, 15);
            this.lbKoleksi.TabIndex = 10;
            this.lbKoleksi.Text = "Koleksi:";
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Location = new System.Drawing.Point(333, 85);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(47, 15);
            this.lbSetting.TabIndex = 11;
            this.lbSetting.Text = "Setting:";
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSetting);
            this.Controls.Add(this.lbKoleksi);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbOutput1);
            this.Controls.Add(this.ckAktif);
            this.Controls.Add(this.rdMerah);
            this.Controls.Add(this.rdBiru);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbData);
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listData;
        private System.Windows.Forms.RadioButton rdBiru;
        private System.Windows.Forms.RadioButton rdMerah;
        private System.Windows.Forms.CheckBox ckAktif;
        private System.Windows.Forms.Label lbOutput1;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbKoleksi;
        private System.Windows.Forms.Label lbSetting;
    }
}
