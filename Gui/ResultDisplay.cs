using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadžba;

namespace Vsite.CSharp.KvadratnaJednadžba.Gui
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        public readonly global::KvadratnaJednadžba.QuadraticEquation qe = new global::KvadratnaJednadžba.QuadraticEquation();

        public void FillResults()
        {
            qe.A = (double)numericUpDownA.Value;
            qe.B = (double)numericUpDownB.Value;
            qe.C = (double)numericUpDownC.Value;

            double discriminant = qe.Discriminant;
            textBoxDiscriminant.Text = discriminant.ToString();

            textBoxRoot1.Text = qe.Roots[0].ToString();
            textBoxRoot2.Text = qe.Roots[1].ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
}
