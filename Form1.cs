using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void kontrolButon_Click(object sender, EventArgs e)
        {
            long _tcNo = long.Parse(txtTC.Text);
            int _dt = int.Parse(dt.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(_tcNo, isim.Text,soyisim.Text, _dt);
                }

            }
            catch (Exception)
            {

                throw;
            }

            MessageBox.Show(durum.ToString());

        }
    }
}
