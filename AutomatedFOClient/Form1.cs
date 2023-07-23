using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedFOClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            doSend();
           
        }

        private void doSend()
        {
            if (txtConfNumber.Text.Length < 1)
            {
                MessageBox.Show("Confirmation number cant be null ");
                return;
            }

            if (!chkPartReceived.Checked)
            {
                MessageBox.Show("Part must be received, Please try again ");
                chkPartReceived.Checked = true;
                return;
            }

             doSendEmail(makeMessage());
        }

        /**
         *  message  = "confnum:"+conf_number
                    +"\n step1:"+step1_part_received
                    +"\n step2:"+step2_proc_started
                    +"\n step3:"+step3_proc_finished
                    +"\n step4:"+step4_qc_finished
                    +"\n step5:"+step5_sent_delivery
                    +"\n";
         * 
         * 
         */
        private void doSendEmail(string htmlString)
        {
            Console.WriteLine("Email sending ...");
            try
            {
                lblMsg.Text = "";
               MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("halauto.foparts@gmail.com");
                message.To.Add(new MailAddress("kamesh.shankaran@halliburton.com"));
                message.CC.Add(new MailAddress("skameshh@gmail.com"));
                message.Subject = "[FOParts]-Test";
                message.IsBodyHtml = false; //to make message body as html
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("halauto.foparts@gmail.com", "hvbzudpwcdwzjwzu");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine("Email send success ...");
                lblMsg.ForeColor = Color.DarkGreen;
                lblMsg.Text = "Submitted successfully";
            }
            catch(Exception ee)
            {
                Console.WriteLine("Email send failed ..."+ee.Message);
                // MessageBox.Show("Error in submitting  " + ee.Message);
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Submit failed, Please check internet connection.";
                return;
            }
           
        }

        private string makeMessage()
        {
            //"confnum:13579135 \n step1:ON \n step2:ON \n step3:OFF \n step4:OFF \n step5:OFF"
            StringBuilder str = new StringBuilder();
            str.Append("confnum:" +txtConfNumber.Text);
            str.Append("step1:"+ (chkPartReceived.Checked?"ON":"OFF"));
            str.Append("step2:" + (chkPartProcStarted.Checked ? "ON" : "OFF"));
            str.Append("step3:" + (chkPartProcEnd.Checked ? "ON" : "OFF"));
            str.Append("step4:" + (chkPartQCDone.Checked ? "ON" : "OFF"));
            str.Append("step5:" + (chkPartSentDelv.Checked ? "ON" : "OFF"));

            return str.ToString();
        }

        private void doStep2(bool step2)
        {
            if (step2)
            {
                chkPartReceived.Checked = true;
            }
        }

        private void doStep3(bool step3)
        {
            if (step3)
            {
                chkPartReceived.Checked = true;
                chkPartProcStarted.Checked = true;
            }
        }

        private void doStep4(bool step4)
        {
            if (step4)
            {
                chkPartReceived.Checked = true;
                chkPartProcStarted.Checked = true;
                chkPartProcEnd.Checked = true;
            }
        }

        private void doStep5(bool step5)
        {
            if (step5)
            {
                chkPartReceived.Checked = true;
                chkPartProcStarted.Checked = true;
                chkPartQCDone.Checked = true;
            }
        }


        private void chkPartProcStarted_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("process = "+ chkPartProcStarted.Checked);
            //lblMsg.Text = "process = " + chkPartProcStarted.Checked;
            doStep2(chkPartProcStarted.Checked);
        }

              

        private void chkPartProcEnd_CheckedChanged(object sender, EventArgs e)
        {
            doStep3(chkPartProcEnd.Checked);
        }

        private void chkPartQCDone_CheckedChanged(object sender, EventArgs e)
        {
            doStep4(chkPartQCDone.Checked);
        }

        private void chkPartSentDelv_CheckedChanged(object sender, EventArgs e)
        {
            doStep5(chkPartSentDelv.Checked);
        }
    }
}
