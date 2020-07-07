namespace ndppp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.organikBosalt_BTN = new System.Windows.Forms.Button();
            this.organik_BTN = new System.Windows.Forms.Button();
            this.kagit_BTN = new System.Windows.Forms.Button();
            this.cam_BTN = new System.Windows.Forms.Button();
            this.metal_BTN = new System.Windows.Forms.Button();
            this.kagitBosalt_BTN = new System.Windows.Forms.Button();
            this.camBosalt_BTN = new System.Windows.Forms.Button();
            this.metalBosalt_BTN = new System.Windows.Forms.Button();
            this.organik_LB = new System.Windows.Forms.ListBox();
            this.kagit_LB = new System.Windows.Forms.ListBox();
            this.cam_LB = new System.Windows.Forms.ListBox();
            this.metal_LB = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yeniOyun_BTN = new System.Windows.Forms.Button();
            this.cikis_BTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sure_LBL = new System.Windows.Forms.Label();
            this.puan_LBL = new System.Windows.Forms.Label();
            this.organik_PB = new System.Windows.Forms.ProgressBar();
            this.kagit_PB = new System.Windows.Forms.ProgressBar();
            this.cam_PB = new System.Windows.Forms.ProgressBar();
            this.metal_PB = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 254);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATIK KUTULARI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(24, 21);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(292, 224);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(514, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 254);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(350, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 254);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(350, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 254);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(511, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 254);
            this.label6.TabIndex = 6;
            // 
            // organikBosalt_BTN
            // 
            this.organikBosalt_BTN.Location = new System.Drawing.Point(350, 285);
            this.organikBosalt_BTN.Name = "organikBosalt_BTN";
            this.organikBosalt_BTN.Size = new System.Drawing.Size(152, 30);
            this.organikBosalt_BTN.TabIndex = 7;
            this.organikBosalt_BTN.Text = "BOŞALT";
            this.organikBosalt_BTN.UseVisualStyleBackColor = true;
            this.organikBosalt_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // organik_BTN
            // 
            this.organik_BTN.Location = new System.Drawing.Point(350, 61);
            this.organik_BTN.Name = "organik_BTN";
            this.organik_BTN.Size = new System.Drawing.Size(152, 34);
            this.organik_BTN.TabIndex = 8;
            this.organik_BTN.Text = "ORGANİK ATIK";
            this.organik_BTN.UseVisualStyleBackColor = true;
            this.organik_BTN.Click += new System.EventHandler(this.organik_BTN_Click);
            // 
            // kagit_BTN
            // 
            this.kagit_BTN.Location = new System.Drawing.Point(514, 61);
            this.kagit_BTN.Name = "kagit_BTN";
            this.kagit_BTN.Size = new System.Drawing.Size(149, 34);
            this.kagit_BTN.TabIndex = 9;
            this.kagit_BTN.Text = "KAĞIT";
            this.kagit_BTN.UseVisualStyleBackColor = true;
            this.kagit_BTN.Click += new System.EventHandler(this.kagit_BTN_Click);
            // 
            // cam_BTN
            // 
            this.cam_BTN.Location = new System.Drawing.Point(350, 334);
            this.cam_BTN.Name = "cam_BTN";
            this.cam_BTN.Size = new System.Drawing.Size(152, 33);
            this.cam_BTN.TabIndex = 10;
            this.cam_BTN.Text = "CAM";
            this.cam_BTN.UseVisualStyleBackColor = true;
            this.cam_BTN.Click += new System.EventHandler(this.cam_BTN_Click);
            // 
            // metal_BTN
            // 
            this.metal_BTN.Location = new System.Drawing.Point(511, 334);
            this.metal_BTN.Name = "metal_BTN";
            this.metal_BTN.Size = new System.Drawing.Size(152, 33);
            this.metal_BTN.TabIndex = 11;
            this.metal_BTN.Text = "METAL";
            this.metal_BTN.UseVisualStyleBackColor = true;
            this.metal_BTN.Click += new System.EventHandler(this.metal_BTN_Click);
            // 
            // kagitBosalt_BTN
            // 
            this.kagitBosalt_BTN.Location = new System.Drawing.Point(511, 285);
            this.kagitBosalt_BTN.Name = "kagitBosalt_BTN";
            this.kagitBosalt_BTN.Size = new System.Drawing.Size(152, 30);
            this.kagitBosalt_BTN.TabIndex = 12;
            this.kagitBosalt_BTN.Text = "BOŞALT";
            this.kagitBosalt_BTN.UseVisualStyleBackColor = true;
            this.kagitBosalt_BTN.Click += new System.EventHandler(this.kagitBosalt_BTN_Click);
            // 
            // camBosalt_BTN
            // 
            this.camBosalt_BTN.Location = new System.Drawing.Point(350, 560);
            this.camBosalt_BTN.Name = "camBosalt_BTN";
            this.camBosalt_BTN.Size = new System.Drawing.Size(152, 28);
            this.camBosalt_BTN.TabIndex = 13;
            this.camBosalt_BTN.Text = "BOŞALT";
            this.camBosalt_BTN.UseVisualStyleBackColor = true;
            this.camBosalt_BTN.Click += new System.EventHandler(this.camBosalt_BTN_Click);
            // 
            // metalBosalt_BTN
            // 
            this.metalBosalt_BTN.Location = new System.Drawing.Point(511, 560);
            this.metalBosalt_BTN.Name = "metalBosalt_BTN";
            this.metalBosalt_BTN.Size = new System.Drawing.Size(152, 28);
            this.metalBosalt_BTN.TabIndex = 14;
            this.metalBosalt_BTN.Text = "BOŞALT";
            this.metalBosalt_BTN.UseVisualStyleBackColor = true;
            this.metalBosalt_BTN.Click += new System.EventHandler(this.metalBosalt_BTN_Click);
            // 
            // organik_LB
            // 
            this.organik_LB.FormattingEnabled = true;
            this.organik_LB.ItemHeight = 16;
            this.organik_LB.Location = new System.Drawing.Point(366, 101);
            this.organik_LB.Name = "organik_LB";
            this.organik_LB.Size = new System.Drawing.Size(120, 148);
            this.organik_LB.TabIndex = 15;
            // 
            // kagit_LB
            // 
            this.kagit_LB.FormattingEnabled = true;
            this.kagit_LB.ItemHeight = 16;
            this.kagit_LB.Location = new System.Drawing.Point(529, 101);
            this.kagit_LB.Name = "kagit_LB";
            this.kagit_LB.Size = new System.Drawing.Size(120, 148);
            this.kagit_LB.TabIndex = 16;
            // 
            // cam_LB
            // 
            this.cam_LB.FormattingEnabled = true;
            this.cam_LB.ItemHeight = 16;
            this.cam_LB.Location = new System.Drawing.Point(366, 373);
            this.cam_LB.Name = "cam_LB";
            this.cam_LB.Size = new System.Drawing.Size(120, 148);
            this.cam_LB.TabIndex = 17;
            // 
            // metal_LB
            // 
            this.metal_LB.FormattingEnabled = true;
            this.metal_LB.ItemHeight = 16;
            this.metal_LB.Location = new System.Drawing.Point(529, 373);
            this.metal_LB.Name = "metal_LB";
            this.metal_LB.Size = new System.Drawing.Size(120, 148);
            this.metal_LB.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 313);
            this.label7.TabIndex = 19;
            // 
            // yeniOyun_BTN
            // 
            this.yeniOyun_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yeniOyun_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyun_BTN.ForeColor = System.Drawing.Color.White;
            this.yeniOyun_BTN.Location = new System.Drawing.Point(24, 289);
            this.yeniOyun_BTN.Name = "yeniOyun_BTN";
            this.yeniOyun_BTN.Size = new System.Drawing.Size(292, 47);
            this.yeniOyun_BTN.TabIndex = 20;
            this.yeniOyun_BTN.Text = "YENİ OYUN";
            this.yeniOyun_BTN.UseVisualStyleBackColor = false;
            this.yeniOyun_BTN.Click += new System.EventHandler(this.yeniOyun_BTN_Click);
            // 
            // cikis_BTN
            // 
            this.cikis_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cikis_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_BTN.ForeColor = System.Drawing.Color.White;
            this.cikis_BTN.Location = new System.Drawing.Point(24, 526);
            this.cikis_BTN.Name = "cikis_BTN";
            this.cikis_BTN.Size = new System.Drawing.Size(292, 47);
            this.cikis_BTN.TabIndex = 21;
            this.cikis_BTN.Text = "ÇIKIŞ";
            this.cikis_BTN.UseVisualStyleBackColor = false;
            this.cikis_BTN.Click += new System.EventHandler(this.cikis_BTN_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 38);
            this.label8.TabIndex = 22;
            this.label8.Text = "SURE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 38);
            this.label9.TabIndex = 23;
            this.label9.Text = "PUAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sure_LBL
            // 
            this.sure_LBL.BackColor = System.Drawing.Color.White;
            this.sure_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure_LBL.Location = new System.Drawing.Point(24, 373);
            this.sure_LBL.Name = "sure_LBL";
            this.sure_LBL.Size = new System.Drawing.Size(292, 51);
            this.sure_LBL.TabIndex = 24;
            this.sure_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puan_LBL
            // 
            this.puan_LBL.BackColor = System.Drawing.Color.White;
            this.puan_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_LBL.Location = new System.Drawing.Point(24, 462);
            this.puan_LBL.Name = "puan_LBL";
            this.puan_LBL.Size = new System.Drawing.Size(292, 51);
            this.puan_LBL.TabIndex = 25;
            this.puan_LBL.Text = "0";
            this.puan_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organik_PB
            // 
            this.organik_PB.Location = new System.Drawing.Point(350, 256);
            this.organik_PB.Name = "organik_PB";
            this.organik_PB.Size = new System.Drawing.Size(152, 23);
            this.organik_PB.TabIndex = 26;
            // 
            // kagit_PB
            // 
            this.kagit_PB.Cursor = System.Windows.Forms.Cursors.Default;
            this.kagit_PB.Location = new System.Drawing.Point(511, 256);
            this.kagit_PB.Name = "kagit_PB";
            this.kagit_PB.Size = new System.Drawing.Size(152, 23);
            this.kagit_PB.TabIndex = 27;
            // 
            // cam_PB
            // 
            this.cam_PB.Location = new System.Drawing.Point(350, 531);
            this.cam_PB.Name = "cam_PB";
            this.cam_PB.Size = new System.Drawing.Size(152, 23);
            this.cam_PB.TabIndex = 28;
            // 
            // metal_PB
            // 
            this.metal_PB.Location = new System.Drawing.Point(511, 531);
            this.metal_PB.Name = "metal_PB";
            this.metal_PB.Size = new System.Drawing.Size(152, 23);
            this.metal_PB.TabIndex = 29;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 597);
            this.Controls.Add(this.metal_PB);
            this.Controls.Add(this.cam_PB);
            this.Controls.Add(this.kagit_PB);
            this.Controls.Add(this.organik_PB);
            this.Controls.Add(this.puan_LBL);
            this.Controls.Add(this.sure_LBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cikis_BTN);
            this.Controls.Add(this.yeniOyun_BTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.metal_LB);
            this.Controls.Add(this.cam_LB);
            this.Controls.Add(this.kagit_LB);
            this.Controls.Add(this.organik_LB);
            this.Controls.Add(this.metalBosalt_BTN);
            this.Controls.Add(this.camBosalt_BTN);
            this.Controls.Add(this.kagitBosalt_BTN);
            this.Controls.Add(this.metal_BTN);
            this.Controls.Add(this.cam_BTN);
            this.Controls.Add(this.kagit_BTN);
            this.Controls.Add(this.organik_BTN);
            this.Controls.Add(this.organikBosalt_BTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ATİK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button organikBosalt_BTN;
        private System.Windows.Forms.Button organik_BTN;
        private System.Windows.Forms.Button kagit_BTN;
        private System.Windows.Forms.Button cam_BTN;
        private System.Windows.Forms.Button metal_BTN;
        private System.Windows.Forms.Button kagitBosalt_BTN;
        private System.Windows.Forms.Button camBosalt_BTN;
        private System.Windows.Forms.Button metalBosalt_BTN;
        private System.Windows.Forms.ListBox organik_LB;
        private System.Windows.Forms.ListBox kagit_LB;
        private System.Windows.Forms.ListBox cam_LB;
        private System.Windows.Forms.ListBox metal_LB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button yeniOyun_BTN;
        private System.Windows.Forms.Button cikis_BTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sure_LBL;
        private System.Windows.Forms.Label puan_LBL;
        private System.Windows.Forms.ProgressBar organik_PB;
        private System.Windows.Forms.ProgressBar kagit_PB;
        private System.Windows.Forms.ProgressBar cam_PB;
        private System.Windows.Forms.ProgressBar metal_PB;
        private System.Windows.Forms.Timer timer;
    }
}

