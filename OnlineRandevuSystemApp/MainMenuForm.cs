using Newtonsoft.Json;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.label3.Text = "Misyonumuz\r\nBiz, Sistem Yönetimi olarak, kullanıcılarımıza en hızlı ve en güvenilir online randevu hizmetini sunmayı hedefliyoruz. Gelişen teknoloji ile birlikte sağlık, güzellik, danışmanlık gibi çeşitli sektörlerde randevu almayı daha kolay ve erişilebilir hale getirmek için çalışıyoruz. Misyonumuz, kullanıcılarımızın hayatını kolaylaştırmak ve zamanlarını daha verimli kullanmalarını sağlamak.\r\n\r\nVizyonumuz\r\nVizyonumuz, online randevu sistemleri arasında lider konuma gelerek, dünya genelinde milyonlarca kullanıcının ilk tercihi olmaktır. Yenilikçi çözümlerimiz ve kullanıcı odaklı yaklaşımımızla, sektördeki en ileri teknolojileri sunmayı hedefliyoruz.\r\n\r\nDeğerlerimiz\r\nGüvenilirlik: Kullanıcılarımızın bilgilerini güvenli bir şekilde saklayarak, randevu süreçlerinin sorunsuz ve güvenli bir şekilde işlemesini sağlıyoruz.\r\n\r\nKullanıcı Odaklılık: Kullanıcı deneyimini ön planda tutarak, herkesin kolayca kullanabileceği, anlaşılır ve etkili bir platform sunuyoruz.\r\nYenilikçilik: Sürekli gelişen teknolojiye ayak uydurarak, kullanıcılarımıza en yeni ve en etkili çözümleri sunmak için çalışıyoruz.\r\nMüşteri Memnuniyeti: Kullanıcılarımızın ihtiyaçlarını ve geri bildirimlerini dikkate alarak, hizmetlerimizi sürekli olarak geliştiriyoruz.";
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

            if (tcOnlineApp.SelectedTab == pageHastaneler)
            {
                LoadHospitalData();
            }

            if (tcOnlineApp.SelectedTab == pageDepartmanlar)
            {
                LoadDepartmentData();
            }

            if (tcOnlineApp.SelectedTab == pageDoktorlar)
            {
                LoadDoctorData();
            }

            if (tcOnlineApp.SelectedTab == pageOnlineRandevu)
            {
                LoadHospitalComboBoxData();
                btnSendRandevous.Enabled = false;
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

        private async void LoadDoctorData()
        {
            var doctorInfo = await GetDoctorInfoAsync();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Sicil No", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Doktor Adı", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Doktor Soyadı", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Tc Nosu", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Branşı", typeof(string)).ReadOnly = true;

            foreach (var item in doctorInfo?.Data)
            {
                DataRow row = dataTable.NewRow();
                row["Sicil No"] = item.SicilNo;
                row["Doktor Adı"] = item.FirstName;
                row["Doktor Soyadı"] = item.LastName;
                row["Tc Nosu"] = item.TcNo;
                row["Branşı"] = item.DepartmentAd;

                dataTable.Rows.Add(row);
            }

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.DataSource = dataTable;
        }

        private async void LoadHospitalData()
        {
            var hospitalInfo = await GetHospitalInfoAsync();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Hastane Kodu", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Hastane Adı", typeof(string)).ReadOnly = true;

            foreach (var item in hospitalInfo?.Data)
            {
                DataRow row = dataTable.NewRow();
                row["Hastane Kodu"] = item.HospitalCode;
                row["Hastane Adı"] = item.Name;

                dataTable.Rows.Add(row);
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dataTable;
        }

        private async void LoadDepartmentData()
        {
            var departmentInfo = await GetDepartmentInfoAsync();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Departman Id", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Departman Adı", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Departmanın Bağlı Olduğu Hastane", typeof(string)).ReadOnly = true;

            foreach (var item in departmentInfo?.Data)
            {
                DataRow row = dataTable.NewRow();
                row["Departman Id"] = item.Id;
                row["Departman Adı"] = item.Name;
                row["Departmanın Bağlı Olduğu Hastane"] = item.HospitalAd;

                dataTable.Rows.Add(row);
            }

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = dataTable;
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

        private async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfoAsync()
        {
            string doctorUrl = $"{this.apiUrl}/doctor/getDoctorInfo";

            var response = new BaseResponse<List<DoctorInfoModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(doctorUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<DoctorInfoModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Doktor bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async Task<BaseResponse<List<HospitalModel>>> GetHospitalInfoAsync()
        {
            string hospitalUrl = $"{this.apiUrl}/hospital/getAllHospital";

            var response = new BaseResponse<List<HospitalModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(hospitalUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<HospitalModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Hastane bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfoAsync()
        {
            string departmentUrl = $"{this.apiUrl}/department/getDepartmentInfo";

            var response = new BaseResponse<List<DepartmentInfoModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(departmentUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<DepartmentInfoModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Departman bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfoByHospitalIdAsync(int hospitalId)
        {
            string departmentUrl = $"{this.apiUrl}/department/getDepartmentInfoByHospitalId/" + hospitalId;

            var response = new BaseResponse<List<DepartmentInfoModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(departmentUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<DepartmentInfoModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Departman bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfoByDepartmentIdAsync(int departmentId)
        {
            string doctorUrl = $"{this.apiUrl}/doctor/getDoctorInfoByDepartmentId/" + departmentId;

            var response = new BaseResponse<List<DoctorInfoModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(doctorUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<DoctorInfoModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Doktor bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            randevousForm.FormClosed += (s, args) => { this.Show(); this.LoadRandevousData(); };
            this.Hide();
            randevousForm.Show();
        }

        private void pageHastaneler_Click(object sender, EventArgs e)
        {
        }

        private void pageDepartmanlar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnSendRandevous_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerRandevousDate.Value;
            DateTime selectedTime = dateTimePickerRandevousTime.Value;

            MessageBox.Show("Seçilen Tarih: " + selectedDate.Date.ToString() + "\nSeçilen Tarih Saat: " + selectedTime.ToString("HH:mm"));
            btnControl.Enabled = true;
            btnSendRandevous.Enabled = false;
        }

        private async void LoadHospitalComboBoxData()
        {
            var hospitalInfo = await GetHospitalInfoAsync();

            foreach (var item in hospitalInfo?.Data)
            {
                comboBoxHospital.Items.Add(new KeyValuePair<int, string>(item.Id, item.Name));
            }

            comboBoxHospital.DisplayMember = "Value";
            comboBoxHospital.ValueMember = "Key";

            comboBoxHospital.SelectedIndexChanged += comboBoxHospital_SelectedIndexChanged;
        }

        private async Task LoadDepartmentComboBoxData(int hospitalId)
        {
            var departmentInfo = await GetDepartmentInfoByHospitalIdAsync(hospitalId);

            comboBoxDepartment.Items.Clear();

            foreach (var item in departmentInfo?.Data)
            {
                comboBoxDepartment.Items.Add(new KeyValuePair<int, string>(item.Id, item.Name));
            }

            comboBoxDepartment.DisplayMember = "Value";
            comboBoxDepartment.ValueMember = "Key";

            comboBoxDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
        }

        private async void comboBoxHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHospital.SelectedItem is KeyValuePair<int, string> selectedHospital)
            {
                int selectedHospitalId = selectedHospital.Key;
                comboBoxDoctor.Items.Clear();
                comboBoxDepartment.Items.Clear();

                comboBoxDoctor.SelectedIndex = -1;
                comboBoxDoctor.Text = string.Empty;
                comboBoxDoctor.Items.Clear();

                comboBoxDepartment.SelectedIndex = -1;
                comboBoxDepartment.Text = string.Empty;
                comboBoxDepartment.Items.Clear();

                await LoadDepartmentComboBoxData(selectedHospitalId);
            }
        }

        private async Task LoadDoctorComboBoxData(int departmentId)
        {
            var doctorInfo = await GetDoctorInfoByDepartmentIdAsync(departmentId);

            comboBoxDoctor.Items.Clear();

            foreach (var item in doctorInfo?.Data)
            {
                comboBoxDoctor.Items.Add(new KeyValuePair<int, string>(item.Id, item.FirstName + " " + item.LastName));
            }

            comboBoxDoctor.DisplayMember = "Value";
            comboBoxDoctor.ValueMember = "Key";
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onaylandı", "BAŞARILI", MessageBoxButtons.OK);
            btnSendRandevous.Enabled = true;
            btnControl.Enabled = false;
        }

        private async void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedItem is KeyValuePair<int, string> selectedDepartment)
            {
                int selectedDepartmentId = selectedDepartment.Key;

                comboBoxDoctor.SelectedIndex = -1;
                comboBoxDoctor.Text = string.Empty;
                comboBoxDoctor.Items.Clear();

                await LoadDoctorComboBoxData(selectedDepartmentId);
            }
        }
    }
}