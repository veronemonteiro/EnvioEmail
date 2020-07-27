using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Mime;

using VMTech.Email;
using VMTech.Util;
using System.IO;

namespace VMTech.EnviarEmail
{
    public partial class Envio : Form
    {
        List<String> erro;
        List<String> _emails;
        List<String> destinatarios;
        List<Anexo> atach;
        String dirAtual;
        String arqConfig;
        ConfiguracaoBE config;
        OpenFileDialog abrirArquivo;

        public Envio()
        {
            InitializeComponent();

            pnStatus.Visible = false;
            abrirArquivo = new OpenFileDialog();
            config = new ConfiguracaoBE();
            erro = new List<String>();
            _emails = new List<String>();
            destinatarios = new List<String>();
            dirAtual = Directory.GetCurrentDirectory();
            arqConfig = "EmailConfig.txt";
                        
            dgvConfig.Columns.Add("Email", "E-Mail");
            dgvConfig.Columns["Email"].Width = 300;
            dgvConfig.Columns.Add("SMTP", "Servidor SMTP");
            dgvConfig.Columns["SMTP"].Width = 250;
            dgvConfig.Columns.Add("Porta", "Porta");
            dgvConfig.Columns["Porta"].Width = 80;
            dgvConfig.Columns.Add("SSL", "SSL");
            dgvConfig.Columns["SSL"].Width = 30;
            dgvConfig.Columns.Add("Cred", "Cred.");
            dgvConfig.Columns["Cred"].Width = 30;

            dgvConfig.ReadOnly = true;

            dgvAnexos.Columns.Add("FileName", "Arquivo Anexo");
            dgvAnexos.Columns["FileName"].Width = 350;
            dgvAnexos.Columns.Add("Acao", "   ");
            dgvAnexos.Columns["Acao"].Width = 30;
            dgvAnexos.Columns["Acao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            
            dgvAnexos.ReadOnly = true;

            atach = new List<Anexo>();

            Point loc = new Point();
            loc.X = 13;
            loc.Y = 4;
            pnDe.Location = loc;
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            MensagemBE mensagem = new MensagemBE();
            mensagem.Destinatario = txtPara.Text;
            mensagem.Remetente = txtDe.Text;
            mensagem.Assunto = txtAssunto.Text;
            mensagem.Mensagem = txtMensagem.Text;

            erro = new List<String>();

            this.Enabled = false;
            pnStatus.Visible = true;
            pnStatus.Enabled = true;
            lbEnv.Enabled = true;
            lbQtd.Enabled = true;

            if (destinatarios.Count() == 0)
            {
                lbQtd.Text = "1 de 1";
                Form.ActiveForm.Refresh();
                AcaoEnviar(mensagem);
            }
            else
            {
                var x = 0;
                foreach (var des in destinatarios)
                {
                    x++;
                    lbQtd.Text = x.ToString() + " de " + destinatarios.Count().ToString();
                    Form.ActiveForm.Refresh();
                    var le = Diversos.SepararTexto(des, ';');
                    if (le.Count() > 0)
                    {
                        mensagem.Destinatario = le[0];
                        if (le.Count() > 1)
                            mensagem.Assunto = le[1];
                        AcaoEnviar(mensagem);
                    }
                }
            }

            this.Enabled = true;
            pnStatus.Visible = false;

            if (erro.Count() > 0)
            {
                erro.Insert(0, "Alguns erros foram encontrados: \n");
                ValidaErros();
            }
            else
                MessageBox.Show("Processo de envio de e-mail concluído com sucesso...");

            this.Enabled = true;
        }

        private void AcaoEnviar(MensagemBE mensagem)
        {
            # region Funcionando por DLL
            if (mensagem.Remetente == "")
                MessageBox.Show("Email do remetente deve ser preenchido.");
            else if (!Validar.Email(mensagem.Remetente, erro))
                MessageBox.Show("Email do remetente não é válido.");
            else if (mensagem.Destinatario == "")
                MessageBox.Show("Email do destinatário deve ser preenchido.");
            else if (!Validar.Email(mensagem.Destinatario, erro))
                mensagem.Destinatario = mensagem.Destinatario;
            else if (mensagem.Assunto == "")
                MessageBox.Show("O Assunto deve ser preenchido.");
            else if (mensagem.Mensagem == "")
                MessageBox.Show("A mensagem esta em branco.");
            else
            {
                Email.Email send = new Email.Email();

                if (atach.Count() > 0)
                {
                    mensagem.Anexos = new List<Anexo>();
                    mensagem.Anexos = atach;
                }
                
                List<String> listaErros = send.Enviar(mensagem, config);
                if(listaErros != null && listaErros.Count() > 0)
                {
                    foreach (var err in listaErros)
                    {
                        erro.Add(err);
                    }
                }
            # endregion

                # region FunfandoLocal
                //try
                //{
                //    MailMessage email = new MailMessage();
                //    email.From = new MailAddress("verone@gmail.com");
                //    email.To.Add(txtPara.Text);
                //    email.Priority = MailPriority.Normal;
                //    email.IsBodyHtml = true;
                //    email.Subject = txtAssunto.Text;
                //    email.Body = txtMensagem.Text;
                //    email.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                //    email.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

                //    SmtpClient client = new SmtpClient();
                //    client.Host = "smtp.gmail.com";
                //    client.Port = 587; //465 ou 587
                //    client.UseDefaultCredentials = false;
                //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //    NetworkCredential netCred = new NetworkCredential(txtDe.Text, "Vermont159951");
                //    client.Credentials = netCred;

                //    client.EnableSsl = true;



                //    client.Send(email);

                //    MessageBox.Show("Funfou!");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Erro: " + ex.Message);
                //}
                # endregion
            }
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog anexaArquivo = new OpenFileDialog();
            anexaArquivo.InitialDirectory = @"C:\";
            anexaArquivo.Title = "Anexar Arquivo";

            if (anexaArquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Anexo arq = new Anexo();
                    Stream file = File.OpenRead(anexaArquivo.FileName);

                    arq.ArquivoStream = file;
                    arq.NomeArquivo = anexaArquivo.SafeFileName;

                    atach.Add(arq);

                    dgvAnexos.Rows.Add(arq.NomeArquivo, " X ");                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void dgvAnexos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAnexos.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dgvAnexos.CurrentCell != null && dgvAnexos.CurrentCell.Value != null)
                {
                    try
                    {
                        atach.RemoveAt(dgvAnexos.CurrentCell.RowIndex);
                        dgvAnexos.Rows.RemoveAt(dgvAnexos.CurrentCell.RowIndex);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Essa linha não pode ser excluida"); 
                    }                    
                }
            }
        }

        public Boolean ValidaErros()
        {
            if (erro.Count() > 0)
            {
                String str = "";

                foreach (var item in erro)
                {
                    str += item + "\n";
                }

                MessageBox.Show(str);

                erro = new List<String>();

                return true;
            }
            else
                return false;
        }

        private void btSelecioneDe_Click(object sender, EventArgs e)
        {
            dgvConfig.Rows.Clear();

            if (Arquivo.Existe(dirAtual, arqConfig, erro))
            {
                _emails = Arquivo.Ler(dirAtual, arqConfig, erro);
                ValidaErros();
                foreach (var item in _emails)
                {
                    List<String> linha = Diversos.SepararTexto(item, ';');
                    dgvConfig.Rows.Add(linha[0], linha[2], linha[3], linha[4] == "1" ? "Sim" : "Não", linha[5] == "1" ? "Sim" : "Não");
                }
            }

            pnDe.Visible = true;
        }

        private void btSelecionePara_Click(object sender, EventArgs e)
        {            
            abrirArquivo.InitialDirectory = @"C:\";
            abrirArquivo.Filter = "Texo (*.txt; *.csv)|*.txt;*.csv";
            abrirArquivo.Title = "Selecione o arquivo com a lista  de E-mails";

            String caminho;

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                caminho = abrirArquivo.FileName.Replace(abrirArquivo.SafeFileName, "");
                destinatarios = Arquivo.Ler(caminho, abrirArquivo.SafeFileName, erro);
                txtPara.Text = abrirArquivo.FileName.Replace("\\", @"\");                
            }
        }

        private void dgvConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConfig.CurrentCell.ColumnIndex.Equals(0) || dgvConfig.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dgvConfig.CurrentCell != null && dgvConfig.CurrentCell.Value != null)
                {
                    try
                    {
                        List<String> linha = Diversos.SepararTexto(_emails[dgvConfig.CurrentCell.RowIndex], ';');
                        txtEmailConfig.Text = linha[0];
                        txtSenhaConfig.Text = linha[1];
                        txtSMTPConfig.Text = linha[2];
                        txtPortaConfig.Text = linha[3];
                        ckSSLConfig.Checked = linha[4] == "1" ? true : false;
                        ckCredencialConfig.Checked = linha[5] == "1" ? true : false;
                        CamposConfig(false);
                        btAcao.Text = "Alterar";
                        btAcao2.Visible = true;
                        btAcao2.Text = "Apagar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Essa linha não pode ser excluida");
                    }
                }
            }
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            switch (btAcao.Text)
            {
                case "Adicionar" :
                    if (ValidaConfig())
                    {
                        String texto = txtEmailConfig.Text + ";" + txtSenhaConfig.Text + ";" + txtSMTPConfig.Text + ";" + txtPortaConfig.Text + ";" + (ckSSLConfig.Checked == true ? "1" : "0") + ";" + (ckCredencialConfig.Checked == true ? "1" : "0") + ";";
                        _emails.Add(texto);
                        if (!Arquivo.Existe(dirAtual, arqConfig, erro))
                            Arquivo.Criar(dirAtual, arqConfig, texto, erro);
                        else
                            Arquivo.Escrever(dirAtual, arqConfig, texto, erro);

                        if (!ValidaErros())
                        {
                            dgvConfig.Rows.Add(txtEmailConfig.Text, txtSMTPConfig.Text, txtPortaConfig.Text, ckSSLConfig.Checked == true ? "Sim" : "Não", ckCredencialConfig.Checked == true ? "Sim" : "Não");
                            dgvConfig.CurrentCell = dgvConfig.Rows[dgvConfig.Rows.Count - 2].Cells[0];
                            CamposConfig(false);
                            btAcao.Text = "Alterar";
                            btAcao2.Visible = true;
                            btAcao2.Text = "Apagar";
                        }
                    }
                    break;
                case "Alterar" :
                    CamposConfig(true);
                    btAcao.Text = "Confirma";
                    btAcao2.Text = "Voltar";
                    break;
                case "Confirma":
                    _emails.RemoveAt(dgvConfig.CurrentCell.RowIndex);
                    String text = txtEmailConfig.Text + ";" + txtSenhaConfig.Text + ";" + txtSMTPConfig.Text + ";" + txtPortaConfig.Text + ";" + (ckSSLConfig.Checked == true ? "1" : "0") + ";" + (ckCredencialConfig.Checked == true ? "1" : "0") + ";";
                    _emails.Add(text);
                    AtualizaArquivo();
                    dgvConfig.CurrentCell = dgvConfig.Rows[dgvConfig.Rows.Count - 2].Cells[0];
                    CamposConfig(false);
                    btAcao.Text = "Alterar";
                    btAcao2.Visible = true;
                    btAcao2.Text = "Apagar";
                    break;
            }
        }

        private void btAcao2_Click(object sender, EventArgs e)
        {
            switch (btAcao2.Text)
            {
                case "Apagar" :
                    _emails.RemoveAt(dgvConfig.CurrentCell.RowIndex);
                    AtualizaArquivo();
                    Limpar();
                    break;
                case "Voltar" :
                    CamposConfig(false);
                    btAcao.Text = "Alterar";
                    btAcao2.Text = "Apagar";
                    break;
            }
        }

        private void AtualizaArquivo()
        {
            dgvConfig.Rows.Clear();

            if (Arquivo.Existe(dirAtual, arqConfig, erro))
                Arquivo.Excluir(dirAtual, arqConfig, erro);

            foreach (var texto in _emails)
            {
                if (!Arquivo.Existe(dirAtual, arqConfig, erro))
                    Arquivo.Criar(dirAtual, arqConfig, texto, erro);
                else
                    Arquivo.Escrever(dirAtual, arqConfig, texto, erro);
            }
            
            foreach (var item in _emails)
            {
                List<String> linha = Diversos.SepararTexto(item, ';');
                dgvConfig.Rows.Add(linha[0], linha[2], linha[3], linha[4] == "1" ? "Sim" : "Não", linha[5] == "1" ? "Sim" : "Não");
            }
        }

        private void btCancelaConfig_Click(object sender, EventArgs e)
        {
            Limpar();
            pnDe.Visible = false;
        }


        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();            
        }

        private void Limpar()
        {
            txtEmailConfig.Text = "";
            txtSenhaConfig.Text = "";
            txtSMTPConfig.Text = "";
            txtPortaConfig.Text = "";
            ckSSLConfig.Checked = false;
            ckCredencialConfig.Checked = false;
            CamposConfig(true);
            btAcao.Text = "Adicionar";
            btAcao2.Text = "Apagar";
            btAcao2.Visible = false;
        }

        private void CamposConfig(Boolean status_)
        {
            txtEmailConfig.Enabled = status_;
            txtSenhaConfig.Enabled = status_;
            txtSMTPConfig.Enabled = status_;
            txtPortaConfig.Enabled = status_;
            ckSSLConfig.Enabled = status_;
            ckCredencialConfig.Enabled = status_;
        }

        private Boolean ValidaConfig()
        {
            var retorno = false;

            if (txtEmailConfig.Text == "")
                MessageBox.Show("O E-mail de Saída não foi informado.");
            else if (!Validar.Email(txtEmailConfig.Text, erro))
                ValidaErros();
            else if (txtSenhaConfig.Text == "")
                MessageBox.Show("A senha não foi informada.");
            else if (txtSMTPConfig.Text == "")
                MessageBox.Show("O servidor SMTP não foi informado.");
            else if (txtPortaConfig.Text == "")
                MessageBox.Show("Porta não informada.");
            else
                retorno = true;

            return retorno;
        }

        private void btConfirmarConfig_Click(object sender, EventArgs e)
        {
            if(ValidaConfig())
            {
                txtDe.Text = txtEmailConfig.Text;
                config.EmailSaida = txtEmailConfig.Text;
                config.Senha = txtSenhaConfig.Text;
                config.SMTP = txtSMTPConfig.Text;
                config.Porta = Convert.ToInt32(txtPortaConfig.Text);
                config.SSL = ckSSLConfig.Checked;
                config.CredenciaisPadrao = ckCredencialConfig.Checked;
                pnDe.Visible = false;
            }
        }

        private void txtPortaConfig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
               

        



    }
}
