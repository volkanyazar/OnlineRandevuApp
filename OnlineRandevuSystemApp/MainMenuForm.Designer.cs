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
            this.btnMakeRandevous = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageHastaneler = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pageDepartmanlar = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pageDoktorlar = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.pageIletisim = new System.Windows.Forms.TabPage();
            this.pageOnlineRandevu = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerRandevousDate = new System.Windows.Forms.DateTimePicker();
            this.btnSendRandevous = new System.Windows.Forms.Button();
            this.dateTimePickerRandevousTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxHospital = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tcOnlineApp.SuspendLayout();
            this.pageHakkimizda.SuspendLayout();
            this.pageRandevularim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pageHastaneler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pageDepartmanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pageDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.pageOnlineRandevu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(683, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selma YARDIMCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(455, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 39);
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
            this.tcOnlineApp.Controls.Add(this.pageHastaneler);
            this.tcOnlineApp.Controls.Add(this.pageDepartmanlar);
            this.tcOnlineApp.Controls.Add(this.pageDoktorlar);
            this.tcOnlineApp.Controls.Add(this.pageIletisim);
            this.tcOnlineApp.Controls.Add(this.pageOnlineRandevu);
            this.tcOnlineApp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcOnlineApp.Location = new System.Drawing.Point(4, 50);
            this.tcOnlineApp.Margin = new System.Windows.Forms.Padding(4);
            this.tcOnlineApp.Multiline = true;
            this.tcOnlineApp.Name = "tcOnlineApp";
            this.tcOnlineApp.SelectedIndex = 0;
            this.tcOnlineApp.ShowToolTips = true;
            this.tcOnlineApp.Size = new System.Drawing.Size(993, 363);
            this.tcOnlineApp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOnlineApp.TabIndex = 7;
            this.tcOnlineApp.SelectedIndexChanged += new System.EventHandler(this.tcOnlineApp_SelectedIndexChanged);
            // 
            // pageHakkimizda
            // 
            this.pageHakkimizda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageHakkimizda.Controls.Add(this.label3);
            this.pageHakkimizda.Location = new System.Drawing.Point(4, 29);
            this.pageHakkimizda.Margin = new System.Windows.Forms.Padding(4);
            this.pageHakkimizda.Name = "pageHakkimizda";
            this.pageHakkimizda.Padding = new System.Windows.Forms.Padding(4);
            this.pageHakkimizda.Size = new System.Drawing.Size(985, 321);
            this.pageHakkimizda.TabIndex = 0;
            this.pageHakkimizda.Text = "Hakkımızda";
            this.pageHakkimizda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(960, 292);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // pageRandevularim
            // 
            this.pageRandevularim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageRandevularim.Controls.Add(this.btnMakeRandevous);
            this.pageRandevularim.Controls.Add(this.dataGridView1);
            this.pageRandevularim.Location = new System.Drawing.Point(4, 29);
            this.pageRandevularim.Margin = new System.Windows.Forms.Padding(4);
            this.pageRandevularim.Name = "pageRandevularim";
            this.pageRandevularim.Padding = new System.Windows.Forms.Padding(4);
            this.pageRandevularim.Size = new System.Drawing.Size(985, 321);
            this.pageRandevularim.TabIndex = 1;
            this.pageRandevularim.Text = "Randevularım";
            this.pageRandevularim.UseVisualStyleBackColor = true;
            // 
            // btnMakeRandevous
            // 
            this.btnMakeRandevous.BackColor = System.Drawing.Color.Gold;
            this.btnMakeRandevous.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMakeRandevous.ForeColor = System.Drawing.Color.Purple;
            this.btnMakeRandevous.Location = new System.Drawing.Point(695, 234);
            this.btnMakeRandevous.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeRandevous.Name = "btnMakeRandevous";
            this.btnMakeRandevous.Size = new System.Drawing.Size(160, 28);
            this.btnMakeRandevous.TabIndex = 1;
            this.btnMakeRandevous.Text = "RANDEVU YAP";
            this.btnMakeRandevous.UseVisualStyleBackColor = false;
            this.btnMakeRandevous.Click += new System.EventHandler(this.btnMakeRandevous_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(979, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // pageHastaneler
            // 
            this.pageHastaneler.Controls.Add(this.dataGridView2);
            this.pageHastaneler.Location = new System.Drawing.Point(4, 29);
            this.pageHastaneler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageHastaneler.Name = "pageHastaneler";
            this.pageHastaneler.Size = new System.Drawing.Size(985, 321);
            this.pageHastaneler.TabIndex = 7;
            this.pageHastaneler.Text = "Hastaneler";
            this.pageHastaneler.UseVisualStyleBackColor = true;
            this.pageHastaneler.Click += new System.EventHandler(this.pageHastaneler_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(979, 315);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pageDepartmanlar
            // 
            this.pageDepartmanlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageDepartmanlar.Controls.Add(this.dataGridView3);
            this.pageDepartmanlar.Location = new System.Drawing.Point(4, 29);
            this.pageDepartmanlar.Margin = new System.Windows.Forms.Padding(4);
            this.pageDepartmanlar.Name = "pageDepartmanlar";
            this.pageDepartmanlar.Size = new System.Drawing.Size(985, 321);
            this.pageDepartmanlar.TabIndex = 2;
            this.pageDepartmanlar.Text = "Departmanlar";
            this.pageDepartmanlar.UseVisualStyleBackColor = true;
            this.pageDepartmanlar.Click += new System.EventHandler(this.pageDepartmanlar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(979, 315);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // pageDoktorlar
            // 
            this.pageDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageDoktorlar.Controls.Add(this.dataGridView4);
            this.pageDoktorlar.Location = new System.Drawing.Point(4, 29);
            this.pageDoktorlar.Margin = new System.Windows.Forms.Padding(4);
            this.pageDoktorlar.Name = "pageDoktorlar";
            this.pageDoktorlar.Size = new System.Drawing.Size(985, 321);
            this.pageDoktorlar.TabIndex = 3;
            this.pageDoktorlar.Text = "Doktorlar";
            this.pageDoktorlar.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(979, 313);
            this.dataGridView4.TabIndex = 1;
            // 
            // pageIletisim
            // 
            this.pageIletisim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageIletisim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pageIletisim.Location = new System.Drawing.Point(4, 29);
            this.pageIletisim.Margin = new System.Windows.Forms.Padding(4);
            this.pageIletisim.Name = "pageIletisim";
            this.pageIletisim.Size = new System.Drawing.Size(985, 321);
            this.pageIletisim.TabIndex = 4;
            this.pageIletisim.Text = "İletişim";
            this.pageIletisim.UseVisualStyleBackColor = true;
            // 
            // pageOnlineRandevu
            // 
            this.pageOnlineRandevu.Controls.Add(this.comboBoxDoctor);
            this.pageOnlineRandevu.Controls.Add(this.label9);
            this.pageOnlineRandevu.Controls.Add(this.comboBoxDepartment);
            this.pageOnlineRandevu.Controls.Add(this.comboBoxHospital);
            this.pageOnlineRandevu.Controls.Add(this.label7);
            this.pageOnlineRandevu.Controls.Add(this.label8);
            this.pageOnlineRandevu.Controls.Add(this.btnControl);
            this.pageOnlineRandevu.Controls.Add(this.label6);
            this.pageOnlineRandevu.Controls.Add(this.label5);
            this.pageOnlineRandevu.Controls.Add(this.dateTimePickerRandevousTime);
            this.pageOnlineRandevu.Controls.Add(this.btnSendRandevous);
            this.pageOnlineRandevu.Controls.Add(this.dateTimePickerRandevousDate);
            this.pageOnlineRandevu.Controls.Add(this.label4);
            this.pageOnlineRandevu.Controls.Add(this.richTextBox1);
            this.pageOnlineRandevu.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageOnlineRandevu.Location = new System.Drawing.Point(4, 29);
            this.pageOnlineRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageOnlineRandevu.Name = "pageOnlineRandevu";
            this.pageOnlineRandevu.Size = new System.Drawing.Size(985, 330);
            this.pageOnlineRandevu.TabIndex = 6;
            this.pageOnlineRandevu.Text = "Online Randevu";
            this.pageOnlineRandevu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "İlgili Tarih ve Saat Aralığında Online Randevu Veren Doktor Listesi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.tcOnlineApp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 468);
            this.panel1.TabIndex = 8;
            // 
            // dateTimePickerRandevousDate
            // 
            this.dateTimePickerRandevousDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerRandevousDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRandevousDate.Location = new System.Drawing.Point(597, 132);
            this.dateTimePickerRandevousDate.Name = "dateTimePickerRandevousDate";
            this.dateTimePickerRandevousDate.Size = new System.Drawing.Size(369, 24);
            this.dateTimePickerRandevousDate.TabIndex = 2;
            this.dateTimePickerRandevousDate.Value = new System.DateTime(1753, 1, 1, 9, 36, 0, 0);
            // 
            // btnSendRandevous
            // 
            this.btnSendRandevous.Enabled = false;
            this.btnSendRandevous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendRandevous.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSendRandevous.Location = new System.Drawing.Point(721, 279);
            this.btnSendRandevous.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendRandevous.Name = "btnSendRandevous";
            this.btnSendRandevous.Size = new System.Drawing.Size(247, 28);
            this.btnSendRandevous.TabIndex = 3;
            this.btnSendRandevous.Text = "Randevu Talebi Gönder";
            this.btnSendRandevous.UseVisualStyleBackColor = true;
            this.btnSendRandevous.Click += new System.EventHandler(this.btnSendRandevous_Click);
            // 
            // dateTimePickerRandevousTime
            // 
            this.dateTimePickerRandevousTime.CustomFormat = "HH:mm";
            this.dateTimePickerRandevousTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRandevousTime.Location = new System.Drawing.Point(597, 182);
            this.dateTimePickerRandevousTime.Name = "dateTimePickerRandevousTime";
            this.dateTimePickerRandevousTime.ShowUpDown = true;
            this.dateTimePickerRandevousTime.Size = new System.Drawing.Size(369, 24);
            this.dateTimePickerRandevousTime.TabIndex = 4;
            this.dateTimePickerRandevousTime.Value = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(417, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tarih Seçiniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(418, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Saat Seçiniz:";
            // 
            // btnControl
            // 
            this.btnControl.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnControl.FlatAppearance.BorderSize = 3;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnControl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnControl.Location = new System.Drawing.Point(422, 270);
            this.btnControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(139, 47);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "KONTROL ET";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(417, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Departman Seçiniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(417, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hastane Seçiniz:";
            // 
            // comboBoxHospital
            // 
            this.comboBoxHospital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxHospital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxHospital.FormattingEnabled = true;
            this.comboBoxHospital.Location = new System.Drawing.Point(597, 32);
            this.comboBoxHospital.Name = "comboBoxHospital";
            this.comboBoxHospital.Size = new System.Drawing.Size(370, 25);
            this.comboBoxHospital.TabIndex = 10;
            this.comboBoxHospital.SelectedIndexChanged += new System.EventHandler(this.comboBoxHospital_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(597, 82);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(370, 25);
            this.comboBoxDepartment.TabIndex = 11;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(598, 228);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(370, 25);
            this.comboBoxDoctor.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(418, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Doktor Seçiniz:";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 471);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Randevu Sistemi";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.tcOnlineApp.ResumeLayout(false);
            this.pageHakkimizda.ResumeLayout(false);
            this.pageRandevularim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pageHastaneler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pageDepartmanlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pageDoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.pageOnlineRandevu.ResumeLayout(false);
            this.pageOnlineRandevu.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcOnlineApp;
        private System.Windows.Forms.Button btnMakeRandevous;
        private System.Windows.Forms.TabPage pageOnlineRandevu;
        private System.Windows.Forms.TabPage pageHastaneler;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevousDate;
        private System.Windows.Forms.Button btnSendRandevous;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevousTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxHospital;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label9;
    }
}