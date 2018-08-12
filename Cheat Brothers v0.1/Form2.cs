using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Net;
using System.Collections.Specialized;
using APISender;
using System.Threading;

namespace Cheat_Brothers_v0._1.Resources
{
    public partial class Form2 : MaterialForm
    {
        private DialogResult result;

        public Form2()
        {
            InitializeComponent();
            new Mutex(true, "RobloxCrashDumpUploaderMutex"); //MUITO IMPORTANTE, ANTI-BAN DO ROBLOX!
            MaterialSkinManager instance = MaterialSkinManager.Instance;
            instance.AddFormToManage(this);
            instance.Theme = MaterialSkinManager.Themes.DARK;
            instance.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple700, Primary.DeepPurple800, Accent.DeepPurple100, TextShade.WHITE);

        }

        private static Form2 instance;
        public static Form2 getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new Form2();
            else;
            instance.BringToFront();
            return instance;
                
        }

        public void SendDiscordWebHook(string webhook, string msg)
        {
            SENDER.Post(webhook, new NameValueCollection
            {

                {
                    "content",
                    msg
                }
            });
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://web.roblox.com/install/setup.ashx", @"\Player.exe");
                MessageBox.Show("Feito!");
            }
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SendDiscordWebHook(flatTextBox1.Text, flatTextBox2.Text); 
        }


        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função é bem útil se você está infectado por um COOKIE LOGGER (programa que manda seus cookies para algum local, geralmente para algum canal do Discord,  que possibilita de eles entrarem na sua conta). Após clicar em OK, o limpador irá baixar a versão mais recente do ROBLOX e será limpa. Caso você tenha uma conexão ruim, é bem possível que o download falhe.", "RBXLimpador", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            string LocalUserRoblox = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Roblox\\Versions", "RobloxPlayerBeta.exe", SearchOption.AllDirectories).FirstOrDefault<string>();
            bool flag = LocalUserRoblox == null;
            if (!flag)
            {
                string str = LocalUserRoblox.Replace("\\RobloxPlayerBeta.exe", "");
                bool flag2 = File.Exists(str + "\\RobloxPlayerLauncher.exe");

                if (flag2)
                {
                    File.Delete(str + "\\RobloxPlayerLauncher.exe");
                }
                File.Copy("", str + "\\RobloxPlayerLauncher.exe");
                File.Delete("/.RobloxPlayerLauncher.exe");
                MessageBox.Show("ok");
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Versão do ROBLOX neste momento: " + new WebClient().DownloadString("http://setup.roblox.com/version"), "ROBLOX Checker");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void timer2_Tick(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
