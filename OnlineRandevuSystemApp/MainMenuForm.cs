using OnlineRandevuSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm(UserModel user)
        {
            InitializeComponent();
            this.lblWelcome.Text = $"Hoş Geldiniz, {user.FirstName} {user.LastName}";
        }
    }
}
