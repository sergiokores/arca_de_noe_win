using System;
using System.Windows.Forms;
using System.IO;

namespace Arca_de_Noe
{
    public partial class novoToken : Form
    {


        private void radioButtonAceito_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAceito.Checked == true)
            {
                btnSim.Enabled = true; 
            }
        }

        private void novoToken_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
