namespace OnlineRandevuSystemApp.RandevousForms
{
    partial class RandevousAddForm
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
            this.btnSendRandevous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendRandevous
            // 
            this.btnSendRandevous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendRandevous.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSendRandevous.Location = new System.Drawing.Point(157, 192);
            this.btnSendRandevous.Name = "btnSendRandevous";
            this.btnSendRandevous.Size = new System.Drawing.Size(185, 23);
            this.btnSendRandevous.TabIndex = 0;
            this.btnSendRandevous.Text = "Randevu İsteği Gönder";
            this.btnSendRandevous.UseVisualStyleBackColor = true;
            this.btnSendRandevous.Click += new System.EventHandler(this.btnSendRandevous_Click);
            // 
            // RandevousAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnSendRandevous);
            this.Name = "RandevousAddForm";
            this.Text = "Randevu Kaydı Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendRandevous;
    }
}