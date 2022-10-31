using System;
using System.Net;

namespace confsiera1
{
    public partial class Form1 : Form
    {
        string url = "http://200.40.49.38:80/login?admin=admin&password=siera";
        public Form1()
        {
            InitializeComponent();
            GetHtpp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetHtpp() 
        {
            try
            {
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                MessageBox.Show("Acceso Login Exitoso!" + oResponse) ;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);
            }
        }
    }
}