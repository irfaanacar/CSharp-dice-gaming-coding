using System.Diagnostics.Eventing.Reader;

namespace Zaratma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int birinci = 0;
        int ikinci = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = rastgele.Next(1, 7);
            sayi2 = rastgele.Next(1, 7);
            label4.Text = sayi1.ToString();
            label5.Text = sayi2.ToString();

            if (Convert.ToInt32(label4.Text) > (Convert.ToInt32(label5.Text)))
            {
                birinci = birinci + 1;
                label7.Text = birinci.ToString();
            }
            if (Convert.ToInt32(label5.Text) > (Convert.ToInt32(label4.Text)))
            {
                ikinci = ikinci + 1;
                label9.Text = ikinci.ToString();
            }

        }
    }
}

