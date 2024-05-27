using Newtonsoft.Json;
using OnlineRandevuSystemApp.Models;
using OnlineRandevuSystemApp.Models.Utilities;
using OnlineRandevuSystemApp.RandevousForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp
{
    public partial class MainMenuForm : Form
    {
        private string apiUrl = "https://localhost:5001/api";
        private UserModel _user;
        public MainMenuForm(UserModel user)
        {
            _user = user;
            InitializeComponent();
        }

        private void OnStartForm()
        {
            this.lblWelcome.Text = $"Hoş Geldiniz, {_user.FirstName} {_user.LastName}";
            this.label3.Text = "Lorem Ipsum is simply dummy text of the \nprinting and typesetting industry. \nLorem Ipsum has been the industry's standard \ndummy text ever since the 1500s, \nwhen an unknown printer took a galley of type and scrambled it to make a type specimen book. \nIt has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. \nIt was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, \nand more recently with desktop \npublishing software like Aldus PageMaker \nincluding versions of Lorem Ipsum";
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            OnStartForm();
        }

        private void tcOnlineApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcOnlineApp.SelectedTab == pageRandevularim)
            {
                LoadRandevousData();
            }
        }

        private async void LoadRandevousData()
        {
            var randevuInfo = await GetRandevousInfoByUserIdAsync();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Randevu No", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Randevu Tarihi", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Randevu Saati", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Doktor Adı Soyadı", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Bölüm", typeof(string)).ReadOnly = true;

            foreach (var item in randevuInfo?.Data)
            {
                DataRow row = dataTable.NewRow();
                row["Randevu No"] = item.RandevoNo;
                row["Randevu Tarihi"] = item.RandevuTarihi;
                row["Randevu Saati"] = item.RandevuSaati;
                row["Doktor Adı Soyadı"] = item.DoktorAdSoyad;
                row["Bölüm"] = item.Bolum;

                dataTable.Rows.Add(row);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }

        private async Task<BaseResponse<List<RandevousInfoModel>>> GetRandevousInfoByUserIdAsync()
        {
            string userUrl = $"{this.apiUrl}/randevous/getByUserId/" + _user.Id;

            var response = new BaseResponse<List<RandevousInfoModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(userUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<RandevousInfoModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Randevu bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private void ActiveMenuEffect(ToolStripMenuItem menuItem)
        {
            menuItem.ForeColor = Color.Red;
            menuItem.BackColor = Color.Green;
        }

        private void UndoMenuEffects()
        {
            //var menuItems = new List<ToolStripMenuItem>()
            //{
            //    hakkımızdaToolStripMenuItem,
            //    doktorlarToolStripMenuItem,
            //    iletişimToolStripMenuItem,
            //    departmanlarToolStripMenuItem,
            //    randevularımToolStripMenuItem,
            //    sSSToolStripMenuItem
            //};
            //foreach (var menu in menuItems)
            //{
            //    menu.ForeColor = Color.DarkBlue;
            //    menu.BackColor = Color.Pink;
            //}
        }

        private void btnMakeRandevous_Click(object sender, EventArgs e)
        {
            RandevousAddForm randevousForm = new RandevousAddForm(this._user);
            randevousForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            randevousForm.Show();
        }
    }
}
