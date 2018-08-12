using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APISender;

namespace Cheat_Brothers_v0._1
{
    public partial class KeyAppeal : Form
    {
        public KeyAppeal()
        {
            InitializeComponent();
        }

        //carac abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%¨&*()_-+?/

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        public void SendDiscordWebHook(string webhook, string msg)
        {
            SENDER.Post(webhook, new NameValueCollection
            {

        {
            "username",
            "736_"
        },
        {
            "content",
            msg
        }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz1234567890@#$%";
            var stringChars = new char[20];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            try
            {
                SendDiscordWebHook("link removed", string.Concat(new string[]
                                        {
                                            "```Key: ",
                                            recent_key.Text,
                                            "\r\nDiscord: ",
                                            discord.Text,
                                            "\r\nGmail: ",
                                            email.Text,
                                            "\r\nPaís: ",
                                            new WebClient().DownloadString("https://ipapi.co/country_name"),
                                            "\r\nEstado: ",
                                            new WebClient().DownloadString("https://ipapi.co/region"),
                                            "\r\nCidade: ",
                                            new WebClient().DownloadString("https://ipapi.co/city"),
                                            "\r\nIP: ",
                                            new WebClient().DownloadString("http://api.ipify.org"),
                                            "\r\nOS: ",

                                            "\r\nCódigo: ",
                                            finalString,
                                            "```"
                                        }));

                string host = "smtp.gmail.com";
                int port = 587;
                bool ssl = true;
                string fromAddress = "removed";
                string fromPassword = "removed";
                using (var mail = new MailMessage())
                {
                    string subject = "APPEAL_"+finalString;
                    string body = "Olá. Confirmação do Key Appeal. Essa mensagem foi enviada automaticamente e não será necessário responder.<br><br>Key mais recente: " + recent_key.Text + "<br><br>Discord: " + discord.Text+ "<br/><br/>Código: " + finalString ;
                    mail.From = new MailAddress(fromAddress);
                    mail.Subject = subject;
                    mail.IsBodyHtml = true;
                    mail.Body = body;
                    mail.To.Add(email.Text);
                    using (var smtpServer = new SmtpClient(host, port))
                    {
                        smtpServer.UseDefaultCredentials = false;
                        smtpServer.Credentials = new System.Net.NetworkCredential(fromAddress, fromPassword);
                        smtpServer.EnableSsl = ssl;
                        smtpServer.Send(mail);
                    }

                }

                MessageBox.Show("Appeal feito com sucesso. Lembrando: não faça outro appeal se ele for rejeitado.Um email foi enviado com o seu código", "Cheat Brothers Appeal");
            }
            catch (Exception exp)
            {
                if (exp.Message.Contains("429"));
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (429) Muitas solicitações.", "Cheat Brothers");
                }
                MessageBox.Show(exp.Message);
                if (exp.Message.Contains("5.5.1"))
                {
                    ; MessageBox.Show("Erro na conexão com os nossos servidores: (5.5.1) Autenticação é necessária.", "Cheat Brothers");
                }
                else
                {
                    MessageBox.Show(exp.Message, "Cheat Brothers");
                }
            }
            
        }
    }
}

