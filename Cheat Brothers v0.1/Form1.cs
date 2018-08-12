using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using Cheat_Brothers_v0._1.Resources;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
using FastColoredTextBoxNS;
using System.Windows.Input;
using FlatUI;
// haha naice brou, you deobifuscated it, you're a jenious
// parabains vose decompilol o xioat, vc é o jeniu
namespace Cheat_Brothers_v0._1
{
    public partial class Form1 : Form
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);

        public string Nothing { get; private set; }

        public Form1()
        {
            InitializeComponent();
            new Mutex(true, "RobloxCrashDumpUploaderMutex");//anti-ban do roblox que não funciona mais
            bool flag = Process.GetProcessesByName("Roblox Player Beta").Length == 0;
            if (flag)
            {
                this.InjectCheck.ForeColor = Color.Red;
                this.InjectCheck.Text = "Esperando injeção...";
            }
            string WhiteList = File.ReadAllText("./ArquivosConfig/whitelist.json");

            if (File.ReadAllText("./ArquivosConfig/mainconfig.json").Contains("isWhitelistSaved = true"))

            {
                flatTextBox4.Text = WhiteList;

            }
            //if (File.ReadAllText("./ArquivosConfig/mainconfig.json").Contains("isTopMost = true"))

            //{
              //  this.flatCheckBox1.Checked = true;
              //  base.TopMost = true;

            //}
            else
            {
            }

            WebClient request = new WebClient();
            string Vers = "0.1";
            string NovaAtt = request.DownloadString("http://brothersof.tk/updates/ui_version.txt");
            string att = request.DownloadString("http://brothersof.tk/updates/ui_version.txt");
            NovaAtt = new WebClient().DownloadString("http://brothersof.tk/updates/ui_version.txt");
            timer2.Start(); NovaAtt = new WebClient().DownloadString("http://brothersof.tk/updates/ui_version.txt");
            if (att.Contains(Vers))
            {
                MessageBox.Show("Checagem de atualização terminada. Sua versão está atualizada. VERSÃO: " + att, "Cheat Brothers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                var result = MessageBox.Show("Sua versão está desatualizada. É recomendado atualizar. Continuar?", "Cheat Brothers", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    new WebClient().DownloadFile("http://brothersof.tk/updates/CheatBrothersLatest.exe", "./Cheat Brothers v" + att + ".exe");
                    MessageBox.Show("Conclúido. Agora a versão mais atualizada já foi baixada, agora abra o Cheat Brothers v" + (att) + ". Feche essa versão e abra a mais recente.");
                }

            }

        ;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
            if (flag)
            {
                this.InjectCheck.Text = "Esperando injeção...";
            }
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
            if (flag)
            {
                MessageBox.Show("ABRE ROBLOX PRIMEIRO SEU RETARDADO DO CARALHO", "Cheat B... PAU NO CU TU É BURRO ABRE O ROBLOX PRIMEIRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Form1.LaunchExploit();
                this.InjectCheck.Text = "           Injetado!";
                this.InjectCheck.ForeColor = Color.DarkGreen;
            }

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            SendLimitedLuaScript(script);
            SendLuaCScript(script);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void flatLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btools_Click(object sender, EventArgs e)
        {

        }

        private void fogo1_Click(object sender, EventArgs e)
        {


        }

        private void force1_Click(object sender, EventArgs e)
        {


        }

        private void smoke1_Click(object sender, EventArgs e)
        {

        }

        private void partic1_Click(object sender, EventArgs e)
        {

        }

        private void kill_Click(object sender, EventArgs e)
        {

        }

        private void partic0_Click(object sender, EventArgs e)
        {

        }

        private void fogo0_Click(object sender, EventArgs e)
        {

        }

        private void force0_Click(object sender, EventArgs e)
        {

        }

        private void smoke0_Click(object sender, EventArgs e)
        {

        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {

        }

        private void flatButton8_Click(object sender, EventArgs e)
        {

        }

        private void flatButton9_Click(object sender, EventArgs e)
        {


        }

        private void ScriptAPI() // nunca usado
        {
            //string script = fastColoredTextBox1.Text;
            //if (script.Contains("getglobal")) ;
           // {
                //se o textbox tivesse getglobal seria executado como LUAC
            //}
            //else
            //{
                //executaria qualquer merda se não tivesse getglobal
            //}

        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog1.Title = "Salvar";
                this.saveFileDialog1.Filter = "Lua & Text (*.txt; *.lua)|*.txt; * .lua";
                bool flag2 = this.saveFileDialog1.ShowDialog() == DialogResult.OK;
                bool flag3 = flag2;
                bool flag4 = flag3;
                if (flag4)
                {
                    File.WriteAllText(this.saveFileDialog1.FileName, this.fastColoredTextBox1.Text);
                }
            }
            catch
            {
            }
        }

        private void flatButton8_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();

        }

        private static void COR_NF()
        {
            string message = "A função que você soliticou não foi adicionada ou está corrompida.";
            string caption = "Função corrompida/não adicionada";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);
        }

        private static void BETA()
        {
            string message = "A função que você soliticou está em beta. É possível que haja bugs e funções corrompidas.";
            string caption = "Função em desenvolvimento";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);
        }

        private void flatCheckBox1_CheckedChanged_1(object sender)
        {

        }

        private void flatButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uma atualização do roblox fez com q essa merda parasse de funfar");


        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uma atualização do roblox fez com q essa merda parasse de funfar");

        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uma atualização do roblox fez com q essa merda parasse de funfar");


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void partic0_Click_1(object sender, EventArgs e)
        {

        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uma atualização do roblox fez com q essa merda parasse de funfar");


        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            SendLimitedLuaScript("local mouse = game.Players.LocalPlayer:GetMouse()\nmouse.Button1Down:connect(function()\nlocal obj = mouse.Target\nlocal xplosion = Instance.new(\"Explosion\", game.Workspace)\nxplosion.Position = obj.Position\nobj: Remove()\nend)");
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            BETA();

        }


        private void open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Documentos de texto|*.txt|Scripts em LUA|*.lua|Documento de LUAC|*.luac",
                ValidateNames = true,
                Multiselect = false
            })
            {
                bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
                if (flag)
                {
                    try
                    {
                        Stream stream;
                        bool flag2 = (stream = openFileDialog.OpenFile()) != null;
                        if (flag2)
                        {
                            using (stream)
                            {
                                this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: não foi possível ler arquivo do disco. Tente executar o exploit em administrador. Erro original: " + ex.Message);
                    }
                }
            }
        }

        private void LaunchToolForm()
        {
            Form2 form = Form2.getInstance(); //ligação do sistema para não abrir múltiplos forms.
            form.Show();
        }

        private void flatButton10_Click_1(object sender, EventArgs e)
        {
            WhiteListChecker();
        }

        private void SaveWhitelist()
        {
            string WhiteList = flatTextBox4.Text;

            if (File.ReadAllText("./ArquivosConfig/mainconfig.json").Contains("isWhitelistSaved = false"))

            {
                var result = MessageBox.Show("Whitelist aceita. Deseja salvar ela? Assim você não precisará colocar ela toda vez que entrar no exploit!", "Cheat Brothers", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete("./ArquivosConfig/whitelist.json");
                    File.Create("./ArquivosConfig/whitelist.json");
                    File.AppendAllText("./ArquivosConfig/whitelist.json", WhiteList);
                    string wh = File.ReadAllText("./ArquivosConfig/mainconfig.json");
                    wh = wh.Replace("isWhitelistSaved = false", "isWhitelistSaved = true");
                    File.WriteAllText("./ArquivosConfig/mainconfig.json", wh);
                }
            }
            else
            {
                MessageBox.Show("Whitelist aceita.", "Cheat Brothers");
            }
        }

        private void WhiteListChecker()
        {
            try
            {
                WebClient wc = new WebClient();

                string recieve = wc.DownloadString("http://brothersof.tk/checkName.php?q=" + flatTextBox4.Text); //sistema de autenticação básico. Se o usuário estiver na lista de usuário aparecerá "yes", se não estiver aparecerá "no".
                string IsInTrial = wc.DownloadString("http://brothersof.tk/checkTrial.php"); // sistema de trial que nunca foi usado. 1 = trial, 0= sem trial

                if (recieve.Contains("yes"))
                {
                    SaveWhitelist();
                    LaunchToolForm();
                }

                else
                {
                    MessageBox.Show("Essa whitelist é inválida ou foi desativada.", "Cheat Brothers");

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("400"))
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (400) Syntax inválida.", "Cheat Brothers");
                }
                if (ex.Message.Contains("401"))
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (401) Autenticação necessária.", "Cheat Brothers");
                }
                if (ex.Message.Contains("403"))
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (403) Proibido.", "Cheat Brothers");
                }
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (404) Não Encontrado.", "Cheat Brothers");
                }
                if (ex.Message.Contains("500"))
                {
                    MessageBox.Show("Erro entre a conexão com os nossos servidores: (500) Erro interno do servidor.", "Cheat Brothers");
                }
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }


        private static void MEMBRO()
        {
            string message = "na vdd só qm é da equipe da cheat brothers e ajuda no desenvolvimento tem a key anyways";
            string caption = "rapaz";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);
        }

        private static void FORGOT_KEY()
        {
            KeyAppeal appealkey = new KeyAppeal();
            appealkey.Show();
        }

        private void flatButton12_Click_1(object sender, EventArgs e)
        {
            MEMBRO();
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            FORGOT_KEY();
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {

        }

        private void flatButton14_Click_1(object sender, EventArgs e)
        {
            string tp_user = this.flatTextBox5.Text;
            Form1.SendLimitedLuaScript("for i = 1,50 do wait(.06) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(game:GetService('Players'). " + tp_user + " .Character.UpperTorso.Position) + Vector3.new(1,0,0) end");
        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.PlayerGui.MainGui.Nitro.Name = 'Nitr' game:GetService('Players').LocalPlayer.PlayerGui.ProductGui.Nitro:Destroy() b = Instance.new('Model', game:GetService('Players').LocalPlayer.PlayerGui.ProductGui) b.Name = 'Nitro'");
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2");
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 30");
        }

        private void flatButton18_Click(object sender, EventArgs e)
        {
        }

        private void flatButton19_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Workspace').Doors:ClearAllChildren()");
        }

        private void flatButton20_Click(object sender, EventArgs e)
        {
            string message = "Usando isso você será incapaz de entrar no museu ou pegar helicópteros dos policiais.";
            string caption = "Atenção!";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                Form1.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.TeamValue.Value = 'Police'");
            }


        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void flatTabControl1_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {

        }

        private void flatButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção: você precisa ter a gamepass de Duffel Bag para fazer funcionar!", "Cheat Brothers");
            Form1.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
        }

        private void flatButton30_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Workspace').Lasers:ClearAllChildren()");
        }

        private void flatButton22_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1078.45, 153.904, 1176.52) + Vector3.new(1,0,0) end");
        }

        private void flatButton23_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1063.02, 117.562, 1218.757) + Vector3.new(1,0,0) end");
        }

        private void flatButton24_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1132.674, 100.412, 1230.48) + Vector3.new(1,0,0) end");
        }

        private void flatButton25_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32.214, 2.67609, 818.648926) + Vector3.new(1,0,0) end");
        }

        private void flatButton26_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1548.20093, 17.7475166, 701.546997) + Vector3.new(1,0,0) end");
        }

        private void flatButton27_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(137.325, 17.878, 1320.123) + Vector3.new(1,0,0) end");
        }

        private void flatButton28_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i=1,32 do\nwait(0.2)\ngame:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-221.723099, 17.8924026, 1578.80261) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton29_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-222.339157, 17.9125443, 1575.82336) + Vector3.new(1,0,0) end");
        }

        private void flatButton32_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript("wait(0.5)\nplrs = nil\nfor _,p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplrs = p\nend\nend\nwhile true do\nwait(0.1)\nfor _, v in pairs(plrs:GetChildren()) do\nif v.TeamColor ~= plrs.LocalPlayer.TeamColor and not v.Character.Head:FindFirstChild(\"BillboardGui\") then --   ~=\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\nh = Instance.new(\"Frame\",i)\nh.Size = UDim2.new(2,0,1,0)\nh.AnchorPoint = Vector2.new(0.25, 0)\nh.BackgroundColor3 = Color3.new(1,0,0)\nh.BorderSizePixel = 0\nh.BackgroundTransparency = 0.4\nend\nend\nend");
        }

        private void flatButton33_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript("while wait(0.3) do\nfor _, p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplr = p.LocalPlayer\nteam = plr.TeamColor\nfor _, v in pairs(p:GetChildren()) do\nif v.Name ~= plr.Name and v.TeamColor ~= team then\nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Name = (\"OverRemove\")\nf = Instance.new(\"Frame\",i)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\ni.ExtentsOffset = Vector3.new(0,3.5,0)\nf.Size = UDim2.new(1,0,1,0)\nf.BorderSizePixel = 0\nf.BackgroundColor3 = Color3.new(1,0,0)\nelseif v.TeamColor == team then \nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\nend\nend\nend\nend\nend");
        }
        private void flatButton3_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton3_Click_1(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Workspace').Banks.Bank.Door:Destroy()\ngame:GetService('Workspace').Banks.Bank.TriggerDoor:Destroy()");
        }

        private void flatButton18_Click_1(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.PlayerGui.MainGui.Ammo.Current:Destroy()");
        }

        private void flatButton30_Click_1(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.25) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
        }

        private void flatButton34_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    local plr = game:GetService('Players').LocalPlayer\n    local p = Instance.new('Part', workspace)\n    p.Size = Vector3.new(30,0.5,30)\n    p.Anchored = true\n    p.Position = plr.Character.HumanoidRootPart.Position + Vector3.new(0,15,0)\n    plr.Character:MoveTo(p.Position + Vector3.new(0,1,0))\n    spawn(function()\n        while p.Parent do\n            wait(1)\n            if (plr.Character.HumanoidRootPart.Position - p.Position).magnitude > 20 then\n                p:Destroy()\n            end\n        end\n    end)\n\n\n\n\n\n\n\n");
        }

        private void flatButton35_Click(object sender, EventArgs e)
        {

        }

        private void flatButton36_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Criminal:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,0,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
        }

        private void flatButton37_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("while true do for i, v in pairs(game.Teams.Police:GetPlayers()) do p = game:GetService('Players') e = Instance.new('BoxHandleAdornment') e.Color3 = Color3.new(0,0,1) e.Size = Vector3.new(2,1.6,1) e.ZIndex = 1 e.AlwaysOnTop = true e.Parent = game:GetService('Workspace') e.Adornee = v.Character.UpperTorso end wait(5) e:Destroy() end");
        }

        private void flatButton38_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Prisoner:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,77,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
        }

        private void flatButton39_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1453.4, 25.6, 201.4) end");
        }

        private void flatButton35_Click_1(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1112.11475, 101.16069, 1290.57654) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton40_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton41_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1355.2417, 18, -1531.86047) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton42_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-111.571999, 17.6169529, 541.515747) + Vector3.new(1,0,0)\n    end\n");
        }

        private void flatButton43_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) + Vector3.new(1,0,0)\n    end\n");
        }

        private void flatButton44_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
        }

        private void flatButton45_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-956.153564, 19.8500576, -1451.23572) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton46_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) + Vector3.new(1,0,0)\n    end\n");
        }

        private void flatButton47_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("    for i=1,32 do\n   wait(0.2)\n    game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(571.526733, 16.66436, -470.50943) + Vector3.new(1,0,0)\n    end");
        }

        private void flatButton48_Click(object sender, EventArgs e)
        {
            string ESP3 = new WebClient().DownloadString("http://brothersof.tk/loadstring/esp3_9a65991384d7493f9b722b440cc52619.txt");
            SendLimitedLuaScript(ESP3);
        }

        private void flatButton48_Click_1(object sender, EventArgs e)
        {
            string ESP3 = new WebClient().DownloadString("http://brothersof.tk/loadstring/esp3_9a65991384d7493f9b722b440cc52619.txt");
            SendLimitedLuaScript(ESP3);
        }

        private void flatButton33_Click_1(object sender, EventArgs e)
        {
            SendLimitedLuaScript("while wait(0.3) do\nfor _, p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplr = p.LocalPlayer\nteam = plr.TeamColor\nfor _, v in pairs(p:GetChildren()) do\nif v.Name ~= plr.Name and v.TeamColor ~= team then\nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Name = (\"OverRemove\")\nf = Instance.new(\"Frame\",i)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\ni.ExtentsOffset = Vector3.new(0,3.5,0)\nf.Size = UDim2.new(1,0,1,0)\nf.BorderSizePixel = 0\nf.BackgroundColor3 = Color3.new(1,0,0)\nelseif v.TeamColor == team then \nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\nend\nend\nend\nend\nend");
        }

        private void flatButton32_Click_1(object sender, EventArgs e)
        {
            SendLimitedLuaScript("wait(0.5)\nplrs = nil\nfor _,p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplrs = p\nend\nend\nwhile true do\nwait(0.1)\nfor _, v in pairs(plrs:GetChildren()) do\nif v.TeamColor ~= plrs.LocalPlayer.TeamColor and not v.Character.Head:FindFirstChild(\"BillboardGui\") then --   ~=\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\nh = Instance.new(\"Frame\",i)\nh.Size = UDim2.new(2,0,1,0)\nh.AnchorPoint = Vector2.new(0.25, 0)\nh.BackgroundColor3 = Color3.new(1,0,0)\nh.BorderSizePixel = 0\nh.BackgroundTransparency = 0.4\nend\nend\nend");
        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Função desabilitada nesta versão. Cheque novamente na próxima atualização.", "Cheat Brothers");
            //bool flag = this.flatTextBox1.Text == "cmds";
            //if (flag)
            //{
            //    this.richTextBox2.Text = "Cheat Brothers CMD\nEscreva \"cmds\" para a lista de comandos.\n\nkill me\nfloat me\nnofloat me\nchat me {mensagem}\nff me\nblockhead me\nnolimbs me\nnoarms me\nnolegs me\nfire me\nnofire me\nsparkles me\nnosparkles me\nsmoke me\nnosmoke me\nbtools me";
            //}
        }

        private void flatButton5_Click_1(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.DarkRed;
            this.fastColoredTextBox1.ServiceLinesColor = Color.DarkRed;
            this.formSkin1.Refresh();
        }

        private void flatButton7_Click_1(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Teal;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Teal;
            this.formSkin1.Refresh();
        }

        private void flatButton9_Click_1(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Orange;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Orange;
            this.formSkin1.Refresh();
        }

        private void flatButton50_Click(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.DarkGreen;
            this.fastColoredTextBox1.ServiceLinesColor = Color.DarkGreen;
            this.formSkin1.Refresh();
        }

        private void flatButton49_Click(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Black;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Black;
            this.formSkin1.Refresh();
        }

        private void flatButton51_Click(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.DarkMagenta;
            this.fastColoredTextBox1.ServiceLinesColor = Color.DarkMagenta;
            this.formSkin1.Refresh();
        }

        private void flatButton31_Click(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Yellow;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Yellow;
            this.formSkin1.Refresh();
        }

        private void flatButton6_Click_1(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Blue;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Blue;
            this.formSkin1.Refresh();
        }

        private void flatButton11_Click_1(object sender, EventArgs e)
        {
            this.formSkin1.FlatColor = Color.Aqua;
            this.fastColoredTextBox1.ServiceLinesColor = Color.Aqua;
            this.formSkin1.Refresh();
        }

        private void flatButton52_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.formSkin1.FlatColor = colorDialog1.Color;
                this.fastColoredTextBox1.ServiceLinesColor = colorDialog1.Color;
                this.formSkin1.Refresh();
            }
        }

        private void flatCheckBox1_CheckedChanged_2(object sender)
        {
            if (flatCheckBox1.Checked) 
            {
                base.TopMost = true;
            }
            else
            {
                base.TopMost = false;
            }
        }

        private void flatButton67_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'RifleSWAT' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton71_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'ShieldSWAT' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton69_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'ShootingRange' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'AK47' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton72_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Pistol' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton70_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Shotgun' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton68_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Glider' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Glider' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton74_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Binoculars' then v.CFrame = CFrame.new(hit) end end end end end");
        }

        private void flatButton75_Click(object sender, EventArgs e)
        {
            Form1.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Flashlight' then v.CFrame = CFrame.new(hit) end end end end end");
        }
    }
}


