namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String toplam;
        int sayi1;
        int sayi2;
        String islem;
        int sonuc;



        private void button1_Click(object sender, EventArgs e)
        {

            sonucGoster.Text=sonucGoster.Text+"0";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayi1 = int.Parse(sonucGoster.Text);

            sonucGoster.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = "*";
            sayi1 = int.Parse(sonucGoster.Text);

            sonucGoster.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi2=int.Parse(sonucGoster.Text);

            if (islem.Equals("+"))
            {
                sonuc = sayi1 + sayi2;
            }
            if (islem.Equals("-"))
            {
                sonuc = sayi1 - sayi2;
            }
            if (islem.Equals("*"))
            {
                sonuc = sayi1 * sayi2;
            }
            if (islem.Equals("/"))
            {
                sonuc = sayi1 / sayi2;
            }

            sonucGoster.Text = sonuc+" ";   

        }

        private void button16_Click(object sender, EventArgs e)
        {
            sonucGoster.Clear();
            sonuc = 0;
            sayi1 = 0;
            sayi2=  0;
        }

        private void ikiBtn_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sonucGoster.Text = sonucGoster.Text + "8";
        }

        private void cikarmaBtn_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayi1 = int.Parse(sonucGoster.Text);

            sonucGoster.Clear();
        }

        private void bolmeBtn_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayi1 = int.Parse(sonucGoster.Text);

            sonucGoster.Clear();
        }
    }
}