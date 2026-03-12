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
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMk = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.btnUpdateMk = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(115, 339);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(126, 36);
            this.btnHitungMhs.TabIndex = 0;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHitungMk
            // 
            this.btnHitungMk.Location = new System.Drawing.Point(247, 340);
            this.btnHitungMk.Name = "btnHitungMk";
            this.btnHitungMk.Size = new System.Drawing.Size(109, 36);
            this.btnHitungMk.TabIndex = 1;
            this.btnHitungMk.Text = "Hitung Mk";
            this.btnHitungMk.UseVisualStyleBackColor = true;
            this.btnHitungMk.Click += new System.EventHandler(this.btnHitungMk_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(362, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 339);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.AutoSize = true;
            this.txtHasil.Location = new System.Drawing.Point(324, 141);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(44, 20);
            this.txtHasil.TabIndex = 4;
            this.txtHasil.Text = "Hasil";
            this.txtHasil.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 26);
            this.textBox1.TabIndex = 5;
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(443, 332);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(104, 57);
            this.btnHitungDosen.TabIndex = 6;
            this.btnHitungDosen.Text = "Hitung Dosen";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdateMk
            // 
            this.btnUpdateMk.Location = new System.Drawing.Point(553, 332);
            this.btnUpdateMk.Name = "btnUpdateMk";
            this.btnUpdateMk.Size = new System.Drawing.Size(75, 57);
            this.btnUpdateMk.TabIndex = 7;
            this.btnUpdateMk.Text = "Update Mk";
            this.btnUpdateMk.UseVisualStyleBackColor = true;
            this.btnUpdateMk.Click += new System.EventHandler(this.btnUpdateMk_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(644, 332);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(75, 57);
            this.btnInsertProdi.TabIndex = 8;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 491);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateMk);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMk);
            this.Controls.Add(this.btnHitungMhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label txtHasil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHitungDosen;
        private System.Windows.Forms.Button btnUpdateMk;
        private System.Windows.Forms.Button btnInsertProdi;
    }
}

