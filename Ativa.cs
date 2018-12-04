using System;

using System.Windows.Forms;

namespace Arca_de_Noe
{
    public partial class Ativa : Form
    {
        string chave;
        public Boolean ativado = false;
        public Ativa(string serie,string token)
        {
            InitializeComponent();
            lblSerie.Text = serie;
            chave = token;

        }



        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (btnAtivar.Text == "Ativar")
            {
            
                if (txtToken.Text == chave)
                {
                    ativado = true;
                }
                else
                {
                    MessageBox.Show("Chave Inválida ");
                }
            }
           
            this.Close();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked==true)
            {
                this.btnAtivar.Text ="Ativar";
                this.txtToken.Enabled = true;
                
            }
            else
            {
               this.btnAtivar.Text = "Cancelar";
                this.txtToken.Enabled = false;

            }
           
            
        }

      
    }
}
