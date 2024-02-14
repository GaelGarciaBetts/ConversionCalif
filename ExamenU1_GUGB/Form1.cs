using System;
using System.Windows.Forms;

namespace ExamenU1_GUGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_text_Click(object sender, EventArgs e)
        {

        }

        private void btn_conv_Click(object sender, EventArgs e)
        {
            double calif = double.Parse(txt_calif.Text); 

            if (calif > 100)
            {
                MessageBox.Show("Esta calificación es inválida, por favor, ingresa una calificación válida. :Dc");
            }
            else
            {
                MessageBox.Show("Tu calificación en sistema alfabético es: " + CalcularCalif(calif));
            }
        }
        private string CalcularCalif(double calif)
        {
            if (calif >= 90 && calif <= 100)
            {
                return "A";
            }
            else if (calif >= 80 && calif < 90)
            {
                return "B";
            }
            else if (calif >= 70 && calif < 80)
            {
                return "C";
            }
            else if (calif >= 60 && calif < 70)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
