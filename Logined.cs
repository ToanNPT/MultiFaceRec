using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using Emgu.CV;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace MultiFaceRec
{
    public partial class Logined : Form
    {
        public User u;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int NumLabels;
        ConnectionData conn;
        bool rs;

        public Logined()
        {
            InitializeComponent();
            u = new User();
            
        }
        public Logined(User user)
        {
            InitializeComponent();
            this.u = new User(user);
            txtFirstName.Text = user.firstname;
            txtLastName.Text = user.lastname;
            txtUserName.Text = user.username;
            txtPassword.Text = user.password;

        }
        private void bedit_Click(object sender, EventArgs e)
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPassword.Enabled = true;
            txtUserName.Enabled = true;

            bsave.Enabled = true;
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            conn = new ConnectionData();
            string sqlstr = "update users set firstname = "+ "'" + txtFirstName.Text+"', "
                + "lastname = " + "'" + txtLastName.Text + "', "
                + "username = " + "'" + txtUserName.Text + "', "
                + "password = " + "'" + txtPassword.Text + "' "
                + "where id = " + "'" + u.id +"'";
            rs = conn.ExcuteNonQuerry(sqlstr, CommandType.Text);
            if (rs)
            {
                MessageBox.Show("Update successfully");

                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt32(Labels[0]);
                string[] s = new string[NumLabels + 2];
                int dem = 0;
                foreach (string p in Labels)
                {
                    s[dem] = p;
                    dem++;
                }
                    
                for (int i = 1; i <= NumLabels; i++ )
                {
                    if(s[i].Equals(u.username))
                    {
                        s[i] = txtUserName.Text;
                    }
                }
                File.Delete(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");

                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", NumLabels.ToString() + "%");
                for (int i = 1; i <= NumLabels; i++)
                {
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", s[i].ToString() + "%");
                }
                u = conn.getInfo(txtUserName.Text);
                txtFirstName.Text = u.firstname;
                txtLastName.Text = u.lastname;
                txtUserName.Text = u.username;
                txtPassword.Text = u.password;
            }          
            bsave.Enabled = false;

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            bsave.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;

            txtFirstName.Text = u.firstname;
            txtLastName.Text = u.lastname;
            txtUserName.Text = u.username;
            txtPassword.Text = u.password;
        }   
    }
}
