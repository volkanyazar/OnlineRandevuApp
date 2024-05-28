using Newtonsoft.Json;
using OnlineRandevuSystemApp.Models;
using OnlineRandevuSystemApp.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp.RandevousForms
{
    public partial class RandevousAddForm : Form
    {
        private string apiUrl = "https://localhost:5001/api";
        private UserModel _user;
        public RandevousAddForm(UserModel user)
        {
            _user = user;
            InitializeComponent();
        }

        private async void btnSendRandevous_Click(object sender, EventArgs e)
        {
            RandevousModel rndvs = new RandevousModel()
            {
                Date = DateTime.Now,
                Hour = "13:30",
                DoctorId = 1,
                Name = "Giriş",
                UserId = this._user.Id,
            };
            await AddRandevousAsync(rndvs);
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
                        this.Close();
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

    }
}
