using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosuYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsoluzaklik, ikinciatsoluzaklik, ucuncuatsoluzaklik;
        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label6.Text);
            derece++;
            label6.Text = derece.ToString();

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

            if(birinciatingenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("Bir Numaralı Koşucu Kazandı");
            }
            if(ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("İki Numaralı Koşucu Kazandı");
            }
            if(ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("Üç Numaralı Koşucu Kazandı");
            }
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklik = pictureBox1.Left;
            ikinciatsoluzaklik = pictureBox2.Left;
            ucuncuatsoluzaklik = pictureBox3.Left;
        }
    }
}
