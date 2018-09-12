using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Servidor : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        JogoServidor mainServidor;

        public Servidor()
        {
            InitializeComponent();

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            TxtIp.Text = ip[1].ToString();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (BtnIniciar.Text.Trim() == "Iniciar")
            {
                string porta = TxtPorta.Text;
                if (string.IsNullOrWhiteSpace(porta))
                {
                    MessageBox.Show("Informe a porta que o servidor irá trabalhar!");
                }
                else if (!Regex.IsMatch(porta, "[ ^ 0-9]"))
                {
                    MessageBox.Show("Informe apenas números para a porta do servidor!");
                }

                int portaConexao;
                if (!int.TryParse(porta, out portaConexao))
                {
                    MessageBox.Show("Erro ao converter a porta para inteiro!");
                }

                if (portaConexao < 0 || portaConexao > 65535)
                {
                    MessageBox.Show("Porta inválida! Informe uma porta entre 0 e 65535.");
                    return;
                }

                //Inciar servido
                try
                {
                    // Analisa o endereço IP do servidor informado no textbox
                    IPAddress enderecoIP = IPAddress.Parse(TxtIp.Text);

                    // Cria uma nova instância do objeto JogoServidor
                    mainServidor = new JogoServidor(enderecoIP, portaConexao);

                    // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                    JogoServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                    // Inicia o atendimento das conexões
                    mainServidor.IniciarServidor();

                    //Se der certo, alterar o status
                    TxtIp.ReadOnly = true;
                    TxtPorta.ReadOnly = true;
                    LabStatus.Text = $"Ligado!";
                    LabStatus.ForeColor = System.Drawing.Color.Green;
                    BtnIniciar.Text = "Parar";

                    // Mostra que nos iniciamos o atendimento para conexões
                    txtLogs.AppendText("Monitorando as conexões...\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão : " + ex.Message);
                }
            }
            else if (BtnIniciar.Text.Trim() == "Parar")
            {
                try
                {
                    mainServidor.DesligarServidor();
                    txtLogs.AppendText("Servidor parado...\r\n");
                    
                    //Se der certo, alterar o status
                    TxtIp.ReadOnly = false;
                    TxtPorta.ReadOnly = false;
                    LabStatus.Text = "Desligado!";
                    LabStatus.ForeColor = System.Drawing.Color.DarkRed;
                    BtnIniciar.Text = "Iniciar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operação não programada. Reinicie a aplicação!");
            }
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o logo com mensagens
            txtLogs.AppendText(strMensagem + "\r\n");
        }
    }
}
