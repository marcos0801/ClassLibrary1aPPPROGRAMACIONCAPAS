using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIUwin
{
    public partial class FrmEcuacion : Form
    {
        public FrmEcuacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a,b,c,X1,X2;

            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            string msg1 = "", msg2 = "";
            

            X1 = ClassLibrary1aPPPROGRAMACIONCAPAS.Ecuacion.X1(a, b, c, out msg1);
            X2 = ClassLibrary1aPPPROGRAMACIONCAPAS.Ecuacion.X1(a, b, c, out msg2);
            
            if (msg1 .Length == 0)
            {
                this.txtX1.Text = X1.ToString("0.00");
            }
            else
            {
                this.txtX1.Text = msg1;

            }

             if (msg2 .Length == 0)
                this.txtX2.Text = X2.ToString("0.00");
            else
             this.txtX2.Text = msg2;


                
        }

        private void txtX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngetX1_Click(object sender, EventArgs e)
        {
            double a, b, c, X1;

            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            try
            {
                X1  = ClassLibrary1aPPPROGRAMACIONCAPAS.Ecuacion.getX1(a, b, c);
                this.txtX1.Text = X1.ToString("0.00");
            }
            catch(Exception  eX1)
            {
                MessageBox.Show(eX1.Message.ToString());
            }
 
           
           
        }
    }
}
