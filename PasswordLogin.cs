using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class PasswordLogin : Form
    {
        ConnectionData conn;
        public PasswordLogin()
        {
            InitializeComponent();
            conn = new ConnectionData();
        }

        private void bsignin_Click(object sender, EventArgs e)
        {
            string sqlstring = "select * from users where username = " + "'"+txtusername.Text + "' "+
                " and password = " + "'"+ txtpassword.Text +"'";
            string err = "";
            bool check = conn.CheckUser(sqlstring, CommandType.Text,ref err);
            if(check)
            {
                
                DialogResult rs = MessageBox.Show("You Signed in successfully, press 'Yes' to move to the Face Authentication", "Vertify",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(rs == DialogResult.Yes)
                {
                    //Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    this.Hide();
                    //String firstname = conn.getusername(txtusername.Text);
                    FaceLogin f = new FaceLogin();
                    f.namelogined = txtusername.Text;
                    //f.username = txtusername.Text;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Sorry, we can't find your account, please try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up f = new Sign_Up();
            f.Show();
        }
    }
}
