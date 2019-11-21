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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
             int num;
            double res;
               
            num = int.Parse(this.txtNum.Text);

            res = ClassLibrary1aPPPROGRAMACIONCAPAS.FACTORIAL.Fact(num);
            this.txtRes.Text = res.ToString();
        }
    }
}
