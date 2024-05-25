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
            UndoMenuEffects();
            ActiveMenuEffect(hakkımızdaToolStripMenuItem);
            ToggleOnSelectedPanel(panel3);
            this.lblWelcome.Text = $"Hoş Geldiniz, {_user.FirstName} {_user.LastName}";
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

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(hakkımızdaToolStripMenuItem);
            ToggleOnSelectedPanel(panel3);
        }

        private void randevularımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(randevularımToolStripMenuItem);
            ToggleOnSelectedPanel(panel1);
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(departmanlarToolStripMenuItem);
            ToggleOnSelectedPanel(panel4);
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(doktorlarToolStripMenuItem);
            ToggleOnSelectedPanel(panel5);
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(iletişimToolStripMenuItem);
            ToggleOnSelectedPanel(panel6);
        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoMenuEffects();
            ActiveMenuEffect(sSSToolStripMenuItem);
            ToggleOnSelectedPanel(panel7);
        }

        private void ToggleOnSelectedPanel(Panel panel)
        {
            var panelItems = new List<Panel>()
            {
                panel1,
                panel3,
                panel4,
                panel5,
                panel6,
                panel7
            };

            foreach (var pnl in panelItems)
            {
                pnl.Visible = false;
            }

            panel.Visible = true;
        }

        private void ActiveMenuEffect(ToolStripMenuItem menuItem)
        {
            menuItem.ForeColor = Color.Red;
            menuItem.BackColor = Color.Green;
        }

        private void UndoMenuEffects()
        {
            var menuItems = new List<ToolStripMenuItem>()
            {
                hakkımızdaToolStripMenuItem,
                doktorlarToolStripMenuItem,
                iletişimToolStripMenuItem,
                departmanlarToolStripMenuItem,
                randevularımToolStripMenuItem,
                sSSToolStripMenuItem
            };
            foreach (var menu in menuItems)
            {
                menu.ForeColor = Color.DarkBlue;
                menu.BackColor = Color.Pink;
            }
        }
    }
}
