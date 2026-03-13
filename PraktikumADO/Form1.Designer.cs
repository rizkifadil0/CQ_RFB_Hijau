namespace PraktikumADO
{
    partial class Form1
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
            this.HitungMk = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.HitungDosen = new System.Windows.Forms.Button();
            this.HitungMhs = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.UpdateMK = new System.Windows.Forms.Button();
            this.TambahProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HitungMk
            // 
            this.HitungMk.Location = new System.Drawing.Point(326, 290);
            this.HitungMk.Name = "HitungMk";
            this.HitungMk.Size = new System.Drawing.Size(128, 30);
            this.HitungMk.TabIndex = 0;
            this.HitungMk.Text = "Hitung MK";
            this.HitungMk.UseVisualStyleBackColor = true;
            this.HitungMk.Click += new System.EventHandler(this.HitungMk_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(460, 290);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 30);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // HitungDosen
            // 
            this.HitungDosen.Location = new System.Drawing.Point(592, 290);
            this.HitungDosen.Name = "HitungDosen";
            this.HitungDosen.Size = new System.Drawing.Size(116, 30);
            this.HitungDosen.TabIndex = 2;
            this.HitungDosen.Text = "Hitung Dosen";
            this.HitungDosen.UseVisualStyleBackColor = true;
            this.HitungDosen.Click += new System.EventHandler(this.HitungDosen_Click);
            // 
            // HitungMhs
            // 
            this.HitungMhs.Location = new System.Drawing.Point(184, 290);
            this.HitungMhs.Name = "HitungMhs";
            this.HitungMhs.Size = new System.Drawing.Size(127, 30);
            this.HitungMhs.TabIndex = 3;
            this.HitungMhs.Text = "Hitung Mhs";
            this.HitungMhs.UseVisualStyleBackColor = true;
            this.HitungMhs.Click += new System.EventHandler(this.HitungMhs_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(58, 290);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(115, 30);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(301, 187);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(246, 22);
            this.txtHasil.TabIndex = 6;
            // 
            // UpdateMK
            // 
            this.UpdateMK.Location = new System.Drawing.Point(58, 337);
            this.UpdateMK.Name = "UpdateMK";
            this.UpdateMK.Size = new System.Drawing.Size(116, 26);
            this.UpdateMK.TabIndex = 7;
            this.UpdateMK.Text = "Update MK";
            this.UpdateMK.UseVisualStyleBackColor = true;
            this.UpdateMK.Click += new System.EventHandler(this.UpdateMK_Click);
            // 
            // TambahProdi
            // 
            this.TambahProdi.Location = new System.Drawing.Point(184, 336);
            this.TambahProdi.Name = "TambahProdi";
            this.TambahProdi.Size = new System.Drawing.Size(127, 27);
            this.TambahProdi.TabIndex = 8;
            this.TambahProdi.Text = "Tambah Prodi";
            this.TambahProdi.UseVisualStyleBackColor = true;
            this.TambahProdi.Click += new System.EventHandler(this.TambahProdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TambahProdi);
            this.Controls.Add(this.UpdateMK);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.HitungMhs);
            this.Controls.Add(this.HitungDosen);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.HitungMk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HitungMk;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button HitungDosen;
        private System.Windows.Forms.Button HitungMhs;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button UpdateMK;
        private System.Windows.Forms.Button TambahProdi;
    }
}

