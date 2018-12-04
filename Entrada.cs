using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Arca_de_Noe
{
    public partial class Entrada : Form
    {

        private string pacienteTemp = "";// para organizar fila de chamadas anteriores
        private string salaTemp = "";// para organizar fila de chamadas anteriores
        private string data_de_hoje = DateTime.Today.ToShortDateString(); //dia/mes/ano
        private string CriptoPlus;//criptografa chave de acesso
        private Saida saida = new Saida(); //instaciando o segundo painel de chamada 
        private string cliTemp; // para organizar fila de chamadas anteriores

        public Entrada()
        {
            InitializeComponent();
            
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // inicio do painel de entrada
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void Form1_Load(object sender, EventArgs e)
        {

            Identifica id = new Identifica(); //cria uma id unica para o computador 
            string id_digital = id.Valor().ToString(); //guarda a id
            lblRegistro.Text = id_digital; // exibe a identificação digital do comutador no canto inferior esquerdo do painel
            lbldata.Text = data_de_hoje;// mostra o dia atual no canto superior do painel a direita
            CriptoPlus = Cripto(lblRegistro.Text + DateTime.Now.ToShortDateString() + "30"); // gera um token para ativar o uso por + 30 dias
          //  MessageBox.Show("numero que deve ser gerado pelo ativador --> " + CriptoPlus);
            Ativado();

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)// click no botão Adicionar
        {
            int pos = dgvFila.RowCount; //conta quantos registros ha na fila de espera
            dgvFila.Rows.Insert(pos, txbPet.Text, txbCliente.Text);//adiciona um registra no final da fila
            txbPet.Text = ""; // apaga o que foi digitado na textBox
            txbCliente.Text = "";// apaga o que foi digitado na textBox
            txbPet.Focus(); // direciona o cursor dentro da textBox "Nome do Pet"
            if (pos >= 0) // Se houver pelo menos 1 registro na fila de chamada
            {
                btnProximo.Enabled = true; // o botão "Próximo" é habilitado
            }

        }

        private void BtnProximo_Clic(object sender, EventArgs e) //Click no botão próximo
        {
            string pet = dgvFila.Rows[0].Cells[0].Value.ToString(); //carrega o valor do primeiro campo ("Nome do Pet") da primeira linha da fila de chamada
            string cli = dgvFila.Rows[0].Cells[1].Value.ToString(); //carrega o valor do segundo ("nome do Clçiente") campo da primeira linha da fila de chamada
            Chamada(pet, cli);//prepara a chamada para uma sala
            PopularSaída(pet, cli); //Manda as informações da chamada para a tela de saída
            SystemSounds.Asterisk.Play(); //toca um som do sistema para avisar uma nova chamada
        }

        private void AbrirChamada_Click(object sender, EventArgs e) // Click no botão. Abre a tela de saída para clientes visualizarem a chamada
        {
            saida.Show();
        }

        private void abrirPainelToolStripMenuItem_Click(object sender, EventArgs e)// Click no menu dropbox .Abre a tela de saída para clientes visualizarem a chamada
        {
            saida.Show();
        }

        private void fecharPainelToolStripMenuItem_Click(object sender, EventArgs e)// Click no menu dropbox .Fecha a tela de saída para clientes visualizarem a chamada
        {
            saida.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)// Click no menu dropbox . Fecha o programa
        {
            Close();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)// Click no menu dropbox . Abre tela Quem Somos
        {
            QuemSomos quem = new QuemSomos();
            quem.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)// Click no menu dropbox . Abre tela de Ajuda
        {
            Help help = new Help();
            help.Show();
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // Fim do codigo de carregamento do programa

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        //Funções usadas no código principal

        private void Chamada(string pet, string cli) //inicia a fila de chamada ao clicar no botão Próximo
        {
            int sala = 0; //inicia uma sala

            if (dgvFila.RowCount > 0) //se houver um registro para ser chamado
            {
                dgvFila.Rows.RemoveAt(dgvFila.TabIndex);//apaga o primeiro registro da fila de chamada
                lblSendoChamado.Text = cli;   //mostra o nome de quem está sendo chamado
                lblRecente2.Text = lblRecente1.Text; //fila dos chamados
                lblRecente1.Text = pacienteTemp;//fila dos chamados
                pacienteTemp = pet;//troca na fila dos chamados
                lblCli_b.Text = lblCli_a.Text;//troca na fila dos chamados
                lblCli_a.Text = cliTemp;//troca na fila dos chamados
                cliTemp = cli;//troca na fila dos chamados
                lblSala_b.Text = lblSala_a.Text;//troca na fila dos chamados
                lblSala_a.Text = salaTemp;//troca na fila dos chamados
                salaTemp = sala.ToString();//troca na fila dos chamados

                if (dgvFila.RowCount < 1) // quando não houver nenhum cliente na fila de chamada
                {
                    btnProximo.Enabled = false;
                }

                while (sala == 0 || sala > 99) //será aceito salas de 01 a 99
                {
                   
                    Sala salaNum = new Sala(); //instanciando a janela para escolher a sala

                    salaNum.ShowDialog(); //aguarda o valor de retorno

                    string a = salaNum.numSala.Value.ToString();//obtem o numero da sala

                    int.TryParse(a, out sala); // tenta converter "a" 
                }

                if (sala < 10) // adiciona o "0" nas salas de 1 a 9
                {
                    salaTemp = "0" + sala.ToString();
                }
                else
                {
                    salaTemp = sala.ToString();
                }
            }
        }

        // mostra informações na tela de saída
        private void PopularSaída(string pet, string cli)
        {
            saida.lbpNumSala.Text = salaTemp;
            saida.lbpPet.Text = pet;
            saida.lbpCli.Text = cli;
            saida.lbpAnterior_a.Text = lblRecente1.Text;
            saida.lbpAnterior_b.Text = lblRecente2.Text;
            saida.lbpCliente_A.Text = lblCli_a.Text;
            saida.lbpCliente_B.Text = lblCli_b.Text;
            saida.lbpSala_a.Text = lblSala_a.Text;
            saida.lbpSala_b.Text = lblSala_b.Text;
        }



        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //este método ativa e salva a data  da chave de uso para contagem regressiva
        private void AtivarReg(string criptoPlus)
        {
            string token_temp;
            RegistryKey data = Registry.CurrentUser.CreateSubKey("data_atual"); // acessa a entrada no registro do windows

            DateTime data2; //cria uma variavel do tipo DateTime
            DateTime data_hoje = DateTime.Today; //cria uma variavel do tipo DateTime com a data do dia atual
            data2 = data_hoje.AddDays(30); // soma 30 dias a mais.

           
            
            token_temp = data.GetValue("token").ToString(); // recupera chave do registro

            if (token_temp != criptoPlus)

            {
                MessageBox.Show("tokem temp-> "+token_temp+ " ---- criptoPlus -> "+ criptoPlus);
                data.SetValue("expira", data2.ToShortDateString());// escreve a data de expiração no registro
                data.SetValue("atual", lbldata.Text);// escreve a data atual no registro para proteger contra crack
                data.SetValue("dataregistro", lbldata.Text);// escreve a data de ativação no registro
                data.SetValue("token", criptoPlus);//ativa o novo token
            }
            else
            {
               
                MessageBox.Show("Chave de uso inválida!");
            } MessageBox.Show("tokem temp-> " + token_temp + " ---- criptoPlus -> " + criptoPlus);
            Ativado();           
            data.Close();
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Verifica quantos dias faltam para uma nova ativação;
        private void Ativado()
        {
            DateTime data_registrada;
            DateTime data_expira;
            TimeSpan crack,expira;
            int resultado_crack = 0;
            int resultado_expira = 0;

            try
            {

                string data_registro_temp;
                string data_expira_temp;
                RegistryKey verificaReg = Registry.CurrentUser.CreateSubKey("data_atual"); //acessa a entrada no registro do windows
                data_registro_temp = verificaReg.GetValue("dataregistro").ToString();//salva a entrada do registro em uma string
                data_expira_temp = verificaReg.GetValue("expira").ToString();
                data_registrada = DateTime.Parse(data_registro_temp);// salva a entrada convertida em uma data
                data_expira = DateTime.Parse(data_expira_temp);

            }
            catch
            {
                RegistryKey data = Registry.CurrentUser.CreateSubKey("data_atual");// se não houver este registro...
              
                data.SetValue("dataregistro", DateTime.Today.ToShortDateString());//cria o registro
                data.SetValue("token", "");//cria uma entrada para o token
                data.SetValue("expira", DateTime.Today.ToShortDateString());
                data_registrada = DateTime.Today; //retorna a data atual
                data_expira = data_registrada;
            }

            crack = data_registrada - DateTime.Today; // Verifica se a data do computador não foi atrazada
            expira = data_expira - DateTime.Today;
            resultado_crack = Convert.ToInt32(crack.TotalDays.ToString());//converte o calculo para um inteiro
            resultado_expira = Convert.ToInt32(expira.TotalDays.ToString());
            

            if (resultado_crack >0)
            {
               MessageBox.Show("Houve algum problema com a data do seu computador!!");//caso o usuario modifique a data
               this.Text = "Adquira uma nova Chave de uso!";
            }
            else if (resultado_crack == 0 && resultado_expira ==0)
            {
                this.Text = "Adquira uma nova Chave de uso!";
            }
            else
            {
                this.Text = "Expira em " + resultado_expira + " dias";
                btnAdicionar.Enabled = true;
            }
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static string Cripto(string text) //Cria um token
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
                return hash;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        private void adquirirMais30DiasToolStripMenuItem_Click(object sender, EventArgs e) //menu superior para ativar
        {
            Ativa ativa = new Ativa(lblRegistro.Text,this.CriptoPlus); //instancia a janela de ativação
            
            ativa.ShowDialog(); //esperando o retorno
            

            if (ativa.ativado)
            {
                MessageBox.Show("chamando ativador");
                AtivarReg(CriptoPlus);//valida a ativação
            }
          

        }




        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    } 

}
