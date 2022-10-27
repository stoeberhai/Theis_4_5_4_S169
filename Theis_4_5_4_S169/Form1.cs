namespace Theis_4_5_4_S169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;

            LblInput.Text = "a = " + a + "\nb = " + b + "\nc = " + c + "\nd = " + d;

            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c, d);
        }


        private double Addiere(double x, int y, double z=0, int q=0)
        {
            return x+y+z+q;
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7;
            
            LblInput.Text = "a = " + a + "\nb = " + b + "\nc = " + c;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c);

        }

        private void BtnAnzeigen3_Click(object sender, EventArgs e)
        {
            double a = 4.5;
            int b = 7;
            LblInput.Text = "a = " + a + "\nb = " + b;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b);

        }
    }
}