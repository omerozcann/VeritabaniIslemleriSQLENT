namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kullanicitxt = new System.Windows.Forms.TextBox();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parolatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rolcmb = new System.Windows.Forms.ComboBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.kaydetEbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            this.listeleEbtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.silebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.guncelleebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullanicitxt
            // 
            this.kullanicitxt.Location = new System.Drawing.Point(119, 39);
            this.kullanicitxt.Name = "kullanicitxt";
            this.kullanicitxt.Size = new System.Drawing.Size(161, 22);
            this.kullanicitxt.TabIndex = 1;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(119, 70);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(161, 22);
            this.epostatxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eposta";
            // 
            // parolatxt
            // 
            this.parolatxt.Location = new System.Drawing.Point(119, 98);
            this.parolatxt.Name = "parolatxt";
            this.parolatxt.Size = new System.Drawing.Size(161, 22);
            this.parolatxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol";
            // 
            // rolcmb
            // 
            this.rolcmb.FormattingEnabled = true;
            this.rolcmb.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.rolcmb.Location = new System.Drawing.Point(119, 126);
            this.rolcmb.Name = "rolcmb";
            this.rolcmb.Size = new System.Drawing.Size(121, 24);
            this.rolcmb.TabIndex = 7;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(305, 39);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(89, 23);
            this.kaydetbtn.TabIndex = 8;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // kaydetEbtn
            // 
            this.kaydetEbtn.Location = new System.Drawing.Point(305, 70);
            this.kaydetEbtn.Name = "kaydetEbtn";
            this.kaydetEbtn.Size = new System.Drawing.Size(89, 23);
            this.kaydetEbtn.TabIndex = 9;
            this.kaydetEbtn.Text = "Kaydet-E";
            this.kaydetEbtn.UseVisualStyleBackColor = true;
            this.kaydetEbtn.Click += new System.EventHandler(this.kaydetEbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(37, 170);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(452, 189);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(305, 98);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(89, 23);
            this.listelebtn.TabIndex = 11;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // listeleEbtn
            // 
            this.listeleEbtn.Location = new System.Drawing.Point(305, 126);
            this.listeleEbtn.Name = "listeleEbtn";
            this.listeleEbtn.Size = new System.Drawing.Size(89, 23);
            this.listeleEbtn.TabIndex = 12;
            this.listeleEbtn.Text = "Listele E";
            this.listeleEbtn.UseVisualStyleBackColor = true;
            this.listeleEbtn.Click += new System.EventHandler(this.listeleEbtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(400, 39);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(89, 23);
            this.silbtn.TabIndex = 13;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // silebtn
            // 
            this.silebtn.Location = new System.Drawing.Point(400, 70);
            this.silebtn.Name = "silebtn";
            this.silebtn.Size = new System.Drawing.Size(89, 23);
            this.silebtn.TabIndex = 14;
            this.silebtn.Text = "Sil-E";
            this.silebtn.UseVisualStyleBackColor = true;
            this.silebtn.Click += new System.EventHandler(this.silebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(400, 98);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(89, 23);
            this.guncellebtn.TabIndex = 15;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // guncelleebtn
            // 
            this.guncelleebtn.Location = new System.Drawing.Point(400, 126);
            this.guncelleebtn.Name = "guncelleebtn";
            this.guncelleebtn.Size = new System.Drawing.Size(89, 23);
            this.guncelleebtn.TabIndex = 16;
            this.guncelleebtn.Text = "Güncelle-E";
            this.guncelleebtn.UseVisualStyleBackColor = true;
            this.guncelleebtn.Click += new System.EventHandler(this.guncelleebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 389);
            this.Controls.Add(this.guncelleebtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.listeleEbtn);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kaydetEbtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.rolcmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parolatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanicitxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanicitxt;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rolcmb;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button kaydetEbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.Button listeleEbtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button silebtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button guncelleebtn;
    }
}

