using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.KvadratnaJednadžba.Gui
{
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void resultDisplay2_Load(object sender, EventArgs e)
        {

        }

        private void buttonEvalute_Click(object sender, EventArgs e)
        {
            resultDisplay.FillResults();
        }

        private void QuadraticEquation_Load(object sender, EventArgs e)
        {

        }
    }
}
