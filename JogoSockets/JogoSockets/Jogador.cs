using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoSockets
{
    public partial class Jogador : Form
    {
        // Trata o nome do jogador
        private string tipoJogador;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        // Necessário para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack( string strMensagem );
        // Necessário para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack( string strMotivo );
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int porta;
        private bool conectado;
        private string jogada;
        private bool suaVez;

        public Jogador()
        {
           // Na saida da aplicação : desconectar
           Application.ApplicationExit += new EventHandler(OnApplicationExit);
           InitializeComponent();
        }
        
        private void btnConectar_Click( object sender , EventArgs e )
        {
            //Se não estiver conectando aguarda a conexão
            if ( conectado == false )
            {
                //Inicializa a conexão
                InicializaConexao();
            }
            else //Se está conectado então desconecta
            {
                FechaConexao( "Desconectado a pedido do usuario." );
            }
        }

        private void InicializaConexao()
        {
            try
            {
                // Trata o endereço IP informado em um objeto IPAdress
                enderecoIP = IPAddress.Parse( txtServidorIP.Text );
                porta = Convert.ToInt32(txtServidorPorta.Text);
                // Inicia uma nova conexão TCP com o servidor
                tcpServidor = new TcpClient();
                tcpServidor.Connect( enderecoIP , porta );

                //Ajudará verificar se estamos conectados ou não
                conectado = true;

                //Prepara o jogador
                tipoJogador = ObterJogador();

                //Desabilitar e habilitar campos
                txtServidorIP.Enabled = false;
                txtServidorPorta.Enabled = false;
                rbtnJogadorO.Enabled = false;
                rbtnJogadorX.Enabled = false;
                labelStatus.Text = "CONECTANDO...";
                labelOla.Text = "Olá Jogador,";
                labelVezJogada.Text = "Por favor aguarde, seu adversário ainda não seu conectou."; //É a sua vez! Faça sua jogada.

                //Envia o tipo de jogador ao servidor
                stwEnviador = new StreamWriter( tcpServidor.GetStream() );
                stwEnviador.WriteLine( tipoJogador );
                stwEnviador.Flush();

                //Iniciar a Thread para receber as jogadas e nova comunicação
                mensagemThread = new Thread( new ThreadStart( RecebeMensagens ) );
                mensagemThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Erro : " + ex.Message , "Erro na conexão com servidor" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            }
        }

        private void RecebeMensagens()
        {
            //recebe a resposta do servidor
            strReceptor = new StreamReader( tcpServidor.GetStream() );
            string conResposta = strReceptor.ReadLine();

            //Se o primeiro caracter da resposta for 1 a conexão foi feita com sucesso
            if ( conResposta [ 0 ] == '1' )
            {
                //Atualiza a tela para informar que esta conectado
                this.Invoke( new AtualizaLogCallBack( this.AtualizaLog ) , new object [] { "CONECTADO" } );
                labelStatus.Text = "CONECTADO";
            }
            else //Se o primeiro caractere não for 1 a conexão falhou
            {
                string motivo = "Não conectado: ";
                //Extrai o motivo da mensagem, que começan no 3º caractere
                motivo += conResposta.Substring( 2 , conResposta.Length - 2 );
                //Atualiza o formulário com o motivo da falha de conexão
                this.Invoke( new FechaConexaoCallBack( this.FechaConexao ) , new object [] { motivo } );
                //Sai do método
                return;
            }

            //Enquanto estiver conectao le as jogados que estão chegando do servidor e checa se o oponente está conectado
            while ( conectado )
            {
                //exibe log no textbox
                this.Invoke( new AtualizaLogCallBack( this.AtualizaLog ) , new object [] { strReceptor.ReadLine() } );
            }
        }

        private void AtualizaLog(string strMensagem )
        {
            //Anexa o texto ao final de cada linha
            txtLogs.AppendText( strMensagem + "\r\n" );
        }

        //Envia a jogada para o servidor
        private void EnviaJogada()
        {
            if ( suaVez )
            {
                stwEnviador.WriteLine( jogada );
                stwEnviador.Flush();
                suaVez = false;
            }
            jogada = "";
        }

        //Fecha a conexão com o servidor
        private void FechaConexao(string motivo )
        {
            //Mostra o motivo por que a conexão encerrou
            txtLogs.AppendText( motivo + "\r\n" );
            //Habilita e desabilita os controles apropriados no formulario
            txtServidorIP.Enabled = true;
            txtServidorPorta.Enabled = true;
            rbtnJogadorO.Enabled = true;
            rbtnJogadorX.Enabled = true;
        }


        // O tratador de evento para a saida da aplicação
        public void OnApplicationExit( object sender , EventArgs e )
        {
            if ( conectado == true )
            {
                // Fecha as conexões, streams, etc...
                conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();
            }
        }

        public string ObterJogador()
        {
            //
            if ( rbtnJogadorX.Checked )
            {
                return "X";
            }
            else if ( rbtnJogadorO.Checked )
            {
                return "O";
            }
            else
            {
                return "Desconhecido";
            }
        }
    }
}
