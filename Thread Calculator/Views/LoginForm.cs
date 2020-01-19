using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadCalculatorClassLibrary;

namespace Thread_Calculator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        LoginData data = new LoginData();

        private void btn_login_Click(object sender, EventArgs e)
        {

           
            data.SetTypedPass = txt_passTextbox.Text;


            if (data.GetPass == data.SetTypedPass)
            {
                data.GetAttempts = 3;
               
                Diagnostics frm = new Diagnostics();
                frm.Show();
                closeForm();
            }
            else
            {
                data.GetAttempts--;
                txt_passTextbox.Text = "";

                if (data.GetAttempts == 2)
                {
                    MessageBox.Show("Where did you learn to type?", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    lbl_attempts.Text = (data.GetAttempts.ToString() + " attempts remaining!");
                }
                else if (data.GetAttempts == 1)
                {
                    MessageBox.Show("Hey! Don`t do that!", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    lbl_attempts.Text = (data.GetAttempts.ToString() + " attempt remaining!");
                }


            }
            if (data.GetAttempts == 0)
            {

             


                try
                {
                    // Get client username
                    string userName = Environment.UserName;

                                                                    //from                          // to recipients 
                    MailMessage mail = new MailMessage(userName + "xxx@yourdomain.com", "xxx@yourdomain.com, xxx@yourdomain.com");
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Host = "outlook.yourdomain.com";
                    mail.Subject = "Unauthorised access attempt.";
                    mail.Body = "UNIFIED THREAD CALCULATOR\n\nUnauthorised access attempt by: " + userName.ToUpper() + " on " + DateTime.Now + ".";
                    client.Send(mail);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    closeForm();
                }

            }
        }

        public void closeForm()
        {
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_passTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }










    }
