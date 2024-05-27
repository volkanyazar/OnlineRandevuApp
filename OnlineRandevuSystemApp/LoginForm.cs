using Newtonsoft.Json;
using OnlineRandevuSystemApp.Models;
using OnlineRandevuSystemApp.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp
{
    public partial class LoginForm : Form
    {
        private string apiUrl = "https://localhost:5001/api";

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private async Task<BaseResponse<List<UserModel>>> GetUsersAsyncAlt()
        {
            string userUrl = $"{this.apiUrl}/users/getall";

            var response = new BaseResponse<List<UserModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(userUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<UserModel>>>(result);

                    string messageBoxContent = "";
                    if (response.Data != null && response.Data.Count > 0)
                    {
                        foreach (var user in response.Data)
                        {
                            messageBoxContent += $"Id: {user.Id} - Kullanıcı Adı: {user.UserName} - Adı: {user.FirstName} - Soyadı: {user.LastName}\n\n";
                        }
                    }
                    else
                    {
                        messageBoxContent = "Kullanıcı bulunamadı.";
                    }

                    MessageBox.Show(messageBoxContent, "UYARI", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async Task<BaseResponse<List<UserModel>>> GetUsersAsync()
        {
            string userUrl = $"{this.apiUrl}/users/getall";

            var response = new BaseResponse<List<UserModel>>();

            using (var client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(userUrl);
                    response = JsonConvert.DeserializeObject<BaseResponse<List<UserModel>>>(result);

                    if (response.Data == null || response.Data.Count == 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri veritabanında bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"API isteği sırasında bir hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return response;
            }
        }

        private async void Login(string email, string password)
        {
            var users = await GetUsersAsync();
            var userData = new UserModel();
            try
            {
                if (users.Data != null && users.Data.Count > 0)
                {
                    bool isLoginSuccessful = false;
                    foreach (var user in users.Data)
                    {
                        if (user.Email == email && user.Password == password)
                        {
                            isLoginSuccessful = true;
                            userData = user;
                            break;
                        }
                    }

                    if (isLoginSuccessful)
                    {
                        MessageBox.Show("Kullanıcı Girişi Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MainMenuForm frm = new MainMenuForm(userData);
                        frm.FormClosed += (s, args) => this.Show();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Email veya Şifre Hatalıdır!..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    this.txtEmail.Text = null;
                    this.txtPassword.Text = null;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileri Bulunmamaktadır. (Veritabanında Kullanıcı Kaydı Bulunmamaktadır!..)", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriş işlemi sırasında hata oluştu: {ex.Message}", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetUsers_Click(object sender, EventArgs e)
        {
            await GetUsersAsyncAlt();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            Login(email, password);
        }
    }
}