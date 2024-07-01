using Newtonsoft.Json;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using OnlineRandevuSystemApp.Models;
using OnlineRandevuSystemApp.Models.Utilities;
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

            if (tcOnlineApp.SelectedTab == pageIletisim)
            {
                this.label10.Text = "Bize Ulaşın\r\nSistemimiz ilgili sorularınız, randevu talepleriniz veya geri bildirimleriniz için bizimle iletişime geçebilirsiniz. Aşağıdaki bilgiler aracılığıyla bize ulaşabilirsiniz.\r\nAdres:\r\nXXXX Ltd. A.Ş\r\nÜniversiteler Mahallesi, Bilkent Caddesi No:1\r\nÇankaya, Ankara\r\nTelefon:\r\nRandevu: 0555 555 55 55\r\nGenel Bilgi: 0312 222 22 22\r\nE-posta:\r\ninfo@xxxxx.com.tr\r\nÇalışma Saatleri:\r\nPazartesi - Cuma: 08:00 - 17:00\r\nCumartesi: 09:00 - 13:00\r\nPazar: Kapalı\r\nOnline Randevu Alma\r\nOnline randevu almak için lütfen Online Randevu sayfasına gidin ve formu doldurun. Randevu talepleriniz en kısa sürede işleme alınacaktır.";
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
            dataTable.Columns.Add("Hastane", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Bölüm", typeof(string)).ReadOnly = true;

            foreach (var item in randevuInfo?.Data)
            {
                DataRow row = dataTable.NewRow();
                row["Randevu No"] = item.RandevoNo;
                row["Randevu Tarihi"] = item.RandevuTarihi.Value.ToString("MM/dd/yyyy");
                row["Randevu Saati"] = item.RandevuSaati;
                row["Doktor Adı Soyadı"] = item.DoktorAdSoyad;
                row["Hastane"] = item.Hastane;
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

        private void ResetForm()
        {
            btnControl.Enabled = true;
            btnControl.Visible = true;
            btnVazgec.Enabled = false;
            btnVazgec.Visible = false;
            btnSendRandevous.Enabled = false;
            richTextBox1.Text = string.Empty;
            comboBoxDoctor.SelectedIndex = -1;
            comboBoxDoctor.Text = string.Empty;
            comboBoxDoctor.Items.Clear();

            comboBoxDepartment.SelectedIndex = -1;
            comboBoxDepartment.Text = string.Empty;
            comboBoxDepartment.Items.Clear();
            comboBoxHospital.Text = string.Empty;

            dateTimePickerRandevousDate.Value = new DateTime(1753, 1, 1);
            dateTimePickerRandevousTime.Value = new DateTime(2024, 1, 1, 0, 0, 0);
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

        private async void btnControl_Click(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedItem is KeyValuePair<int, string> selectedDepartment)
            {
                var doctorInfo = await GetDoctorInfoByDepartmentIdAsync(selectedDepartment.Key);
                var dtpDate = dateTimePickerRandevousDate.Value.Date;
                var dtpTime = dateTimePickerRandevousTime.Value.TimeOfDay;

                foreach (var item in doctorInfo?.Data)
                {
                    if (item.StartDate.HasValue && item.StartHour.HasValue && item.EndHour.HasValue)
                    {
                        var itemStartDate = item.StartDate.Value.Date;
                        var itemEndDate = item.EndDate.Value.Date;
                        var itemStartTime = item.StartHour.Value.TimeOfDay;
                        var itemEndTime = item.EndHour.Value.TimeOfDay;

                        if ((dtpDate >= itemStartDate && dtpDate <= itemEndDate) && (dtpTime >= itemStartTime && dtpTime <= itemEndTime))
                        {
                            richTextBox1.Text += $"{item.SicilNo}    {item.FirstName}    {item.LastName}\n";
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Randevu için ön kontrol başarılı: Randdevu talebinizi oluşturabilirsiniz...", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSendRandevous.Enabled = true;
                btnControl.Enabled = false;
                btnControl.Visible = false;
                btnVazgec.Enabled = true;
                btnVazgec.Visible = true;
            }
            else
            {
                MessageBox.Show("İlgili tarih ve saat aralığında randevu alınabilecek uygun doktor bulunmamaktadır...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private async Task<BaseResponse<RandevousModel>> AddRandevousAsync(RandevousModel randevousModel)
        {
            string apiUrl = $"{this.apiUrl}/randevous/addRandevousAsync";

            var response = new BaseResponse<RandevousModel>();

            using (var client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(randevousModel);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync(apiUrl, content);
                    var resultContent = await result.Content.ReadAsStringAsync();

                    response = JsonConvert.DeserializeObject<BaseResponse<RandevousModel>>(resultContent);

                    if (response.Data == null)
                    {
                        MessageBox.Show("Randevu ekleneme işlemi başarısız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.tcOnlineApp.SelectedTab = pageRandevularim;
                        MessageBox.Show("Randevu başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Visible = false;
            this.btnSendRandevous.Enabled = false;
            this.btnControl.Enabled = true;
            this.btnControl.Visible = true;
        }

        private async void btnMakeRandevous_Click(object sender, EventArgs e)
        {
            if (comboBoxDoctor.SelectedItem is KeyValuePair<int, string> selectedDoctor)
            {
                DateTime selectedDate = dateTimePickerRandevousDate.Value;
                DateTime selectedTime = dateTimePickerRandevousTime.Value;

                RandevousModel rndvs = new RandevousModel()
                {
                    Date = selectedDate,
                    Hour = selectedTime.ToString("HH:mm"),
                    DoctorId = selectedDoctor.Key,
                    Name = "GENEL MUAYENE",
                    UserId = this._user.Id,
                };
                await AddRandevousAsync(rndvs);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Doktor Bilgileri Hatalı Tekrar Deneyiniz...", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}