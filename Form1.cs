using System.Diagnostics.Eventing.Reader;

namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4, prom;
            cal1 = double.Parse(textBox1.Text);
            cal2 = double.Parse(textBox2.Text);
            cal3 = double.Parse(textBox3.Text);
            cal4 = double.Parse(textBox4.Text);
            prom = (cal1 + cal2 + cal3 + cal4) / 4;

            if (prom > 6.0)
                if ((cal1 > 6.0) & (cal2 > 6.0) & (cal3 > 6.0) & (cal4 > 6.0))
                    MessageBox.Show("Aprobado con " + prom);
                else MessageBox.Show("Reprobado");
            else MessageBox.Show("Reprobado");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}