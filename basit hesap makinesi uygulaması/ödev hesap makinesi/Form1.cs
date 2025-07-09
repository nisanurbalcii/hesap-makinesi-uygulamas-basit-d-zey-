namespace ödev_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (int.TryParse(textBox1.Text, out sayi1) && int.TryParse(textBox2.Text, out sayi2))
            {
                label3.Text = ((float)(sayi1 + sayi2)).ToString();
            }
            else
            {
                MessageBox.Show("lütfen nümerik sayı giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (int.TryParse(textBox1.Text, out sayi1) && int.TryParse(textBox2.Text, out sayi2))
            {
                label3.Text = ((float)(sayi1 * sayi2)).ToString();
            }
            else
            {
                MessageBox.Show("lütfen nümerik sayı giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (int.TryParse(textBox1.Text, out sayi1) && int.TryParse(textBox2.Text, out sayi2))
            {
                label3.Text = ((float)sayi1 - sayi2).ToString();
                
            }
            else
            {
                MessageBox.Show("lütfen nümerik sayı giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (int.TryParse(textBox1.Text, out sayi1) && int.TryParse(textBox2.Text, out sayi2))
            {
                if (sayi2 != 0)
                    label3.Text = ((float)sayi1 / sayi2).ToString();
                else
                {
                    MessageBox.Show("2.sayı 0 olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("lütfen nümerik sayı giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (int.TryParse(textBox1.Text, out sayi1) && int.TryParse(textBox2.Text, out sayi2))
            {
                label3.Text = ((float)(sayi1 % sayi2)).ToString();
            }
            else
            {
                MessageBox.Show("lütfen nümerik sayı giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
