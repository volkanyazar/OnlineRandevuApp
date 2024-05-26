namespace OnlineRandevuSystemApp
{
    partial class MainMenuForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcOnlineApp = new System.Windows.Forms.TabControl();
            this.pageHakkimizda = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pageRandevularim = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageDepartmanlar = new System.Windows.Forms.TabPage();
            this.pageDoktorlar = new System.Windows.Forms.TabPage();
            this.pageIletisim = new System.Windows.Forms.TabPage();
            this.pageSss = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcOnlineApp.SuspendLayout();
            this.pageHakkimizda.SuspendLayout();
            this.pageRandevularim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(10, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(434, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selma YARDIMCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hazırlayan : ";
            // 
            // tcOnlineApp
            // 
            this.tcOnlineApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOnlineApp.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcOnlineApp.Controls.Add(this.pageHakkimizda);
            this.tcOnlineApp.Controls.Add(this.pageRandevularim);
            this.tcOnlineApp.Controls.Add(this.pageDepartmanlar);
            this.tcOnlineApp.Controls.Add(this.pageDoktorlar);
            this.tcOnlineApp.Controls.Add(this.pageIletisim);
            this.tcOnlineApp.Controls.Add(this.pageSss);
            this.tcOnlineApp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcOnlineApp.Location = new System.Drawing.Point(3, 41);
            this.tcOnlineApp.Multiline = true;
            this.tcOnlineApp.Name = "tcOnlineApp";
            this.tcOnlineApp.SelectedIndex = 0;
            this.tcOnlineApp.ShowToolTips = true;
            this.tcOnlineApp.Size = new System.Drawing.Size(659, 288);
            this.tcOnlineApp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOnlineApp.TabIndex = 7;
            this.tcOnlineApp.SelectedIndexChanged += new System.EventHandler(this.tcOnlineApp_SelectedIndexChanged);
            // 
            // pageHakkimizda
            // 
            this.pageHakkimizda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageHakkimizda.Controls.Add(this.label3);
            this.pageHakkimizda.Location = new System.Drawing.Point(4, 25);
            this.pageHakkimizda.Name = "pageHakkimizda";
            this.pageHakkimizda.Padding = new System.Windows.Forms.Padding(3);
            this.pageHakkimizda.Size = new System.Drawing.Size(651, 259);
            this.pageHakkimizda.TabIndex = 0;
            this.pageHakkimizda.Text = "Hakkımızda";
            this.pageHakkimizda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // pageRandevularim
            // 
            this.pageRandevularim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageRandevularim.Controls.Add(this.dataGridView1);
            this.pageRandevularim.Location = new System.Drawing.Point(4, 25);
            this.pageRandevularim.Name = "pageRandevularim";
            this.pageRandevularim.Padding = new System.Windows.Forms.Padding(3);
            this.pageRandevularim.Size = new System.Drawing.Size(651, 259);
            this.pageRandevularim.TabIndex = 1;
            this.pageRandevularim.Text = "Randevularım";
            this.pageRandevularim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // pageDepartmanlar
            // 
            this.pageDepartmanlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageDepartmanlar.Location = new System.Drawing.Point(4, 25);
            this.pageDepartmanlar.Name = "pageDepartmanlar";
            this.pageDepartmanlar.Size = new System.Drawing.Size(651, 259);
            this.pageDepartmanlar.TabIndex = 2;
            this.pageDepartmanlar.Text = "Departmanlar";
            this.pageDepartmanlar.UseVisualStyleBackColor = true;
            // 
            // pageDoktorlar
            // 
            this.pageDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageDoktorlar.Location = new System.Drawing.Point(4, 25);
            this.pageDoktorlar.Name = "pageDoktorlar";
            this.pageDoktorlar.Size = new System.Drawing.Size(651, 259);
            this.pageDoktorlar.TabIndex = 3;
            this.pageDoktorlar.Text = "Doktorlar";
            this.pageDoktorlar.UseVisualStyleBackColor = true;
            // 
            // pageIletisim
            // 
            this.pageIletisim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageIletisim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pageIletisim.Location = new System.Drawing.Point(4, 25);
            this.pageIletisim.Name = "pageIletisim";
            this.pageIletisim.Size = new System.Drawing.Size(651, 259);
            this.pageIletisim.TabIndex = 4;
            this.pageIletisim.Text = "İletişim";
            this.pageIletisim.UseVisualStyleBackColor = true;
            // 
            // pageSss
            // 
            this.pageSss.BackColor = System.Drawing.Color.Transparent;
            this.pageSss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageSss.Location = new System.Drawing.Point(4, 25);
            this.pageSss.Name = "pageSss";
            this.pageSss.Size = new System.Drawing.Size(651, 259);
            this.pageSss.TabIndex = 5;
            this.pageSss.Text = "S.S.S";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.tcOnlineApp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 373);
            this.panel1.TabIndex = 8;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Online Randevu Sistemi";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.tcOnlineApp.ResumeLayout(false);
            this.pageHakkimizda.ResumeLayout(false);
            this.pageHakkimizda.PerformLayout();
            this.pageRandevularim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage pageHakkimizda;
        private System.Windows.Forms.TabPage pageRandevularim;
        private System.Windows.Forms.TabPage pageDepartmanlar;
        private System.Windows.Forms.TabPage pageDoktorlar;
        private System.Windows.Forms.TabPage pageIletisim;
        private System.Windows.Forms.TabPage pageSss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcOnlineApp;
    }
}