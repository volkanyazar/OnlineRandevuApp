using OnlineRandevuSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSystemApp
{
    public partial class MainMenuForm : Form
    {
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
            DataTable dataTable = new DataTable();
            UserModel usr2 = new UserModel();
            usr2.Id = 2;
            usr2.FirstName = "ali";
            usr2.LastName = "dah";
            usr2.Email = "aliATTTTT";
            usr2.UserName = "ali";

            UserModel usr3 = new UserModel();

            usr3.Id = 3;
            usr3.FirstName = "alivef";
            usr3.LastName = "dajjh";
            usr3.Email = "asATTTTT";
            usr3.UserName = "hhg";
            UserModel usr4 = new UserModel();

            usr4.Id = 4;
            usr4.FirstName = "esra";
            usr4.LastName = "gdd";
            usr4.Email = "aesraATTTTT";
            usr4.UserName = "jjh";

            UserModel usr5 = new UserModel();

            usr5.Id = 5;
            usr5.FirstName = "nata";
            usr5.LastName = "hggg";
            usr5.Email = "naasATTTTT";
            usr5.UserName = "jjjssa";

            List<UserModel> users = new List<UserModel>
            {
                usr2,
                usr3,
                usr4,
                usr5
            };



            dataTable.Columns.Add("Id", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("FirstName", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("LastName", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Email", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Username", typeof(string)).ReadOnly = true;

            DataRow firstRow = dataTable.NewRow();
            firstRow["Id"] = _user.Id;
            firstRow["FirstName"] = _user.FirstName;
            firstRow["LastName"] = _user.LastName;
            firstRow["Email"] = _user.Email;
            firstRow["Username"] = _user.UserName;

            dataTable.Rows.Add(firstRow);

            foreach (var item in users)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = item.Id;
                row["FirstName"] = item.FirstName;
                row["LastName"] = item.LastName;
                row["Email"] = item.Email;
                row["Username"] = item.UserName;

                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;
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
    }
}
