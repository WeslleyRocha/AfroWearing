using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Afro_Wearing
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {
                barra.Value = barra.Value += 2;
            }
            else
            {
                TimeSplash.Enabled = false;
                this.Visible = false;

                PHome PGHome = new TelaSplash.PHome();
                PGHome.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
