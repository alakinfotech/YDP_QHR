using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QHRLoginForm.QHRServiceReference;
using System.Security.Cryptography;

namespace QHRLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            QhrServiceClient QhrClient = new QhrServiceClient();
            string csUserID = tBoxUID.Text;
            string csPwd = tBoxPwd.Text;
            string csInformation="Invalid";
            MyLogin login = QhrClient.GetMyLoginByUserId(csUserID);
            MyPatient patient = QhrClient.GetMyPatientByUserId(csUserID);
            if (login == null)
            {
                csInformation = "Incorrect Username.";
                DisplayMessage(csInformation);
                return;
            }
            if (login.Status == 0)
            {
                csInformation = "The user is not activated";
                DisplayMessage(csInformation);
                return;
            }
            if (Encode(csPwd) != login.Password)
            {
                csInformation = "Incorrect Password.";
                DisplayMessage(csInformation);
                return;
            }
            else
            {
                csInformation = "Valid Login";
                DisplayMessage(csInformation);
                return;
            }
            
        }

        void DisplayMessage(string Message)
        {
            MessageBox.Show(Message);
        }

        /// MD5 
        /// </summary>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public string Encode(string strPassword)
        {
            if (strPassword == null || strPassword == "")
            {
                return null;
            }
            byte[] result = Encoding.Default.GetBytes(strPassword);
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tBoxUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pwd_Click(object sender, EventArgs e)
        {

        }

        private void w_Click(object sender, EventArgs e)
        {

        }

        private void tBoxPwd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
