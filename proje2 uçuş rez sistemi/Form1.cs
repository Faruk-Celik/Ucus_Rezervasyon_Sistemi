namespace proje2_uçuş_rez_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " Nereye: " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Adı Soyadı: " + textBox1.Text + " Tc.NO: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;


        }
    }
}