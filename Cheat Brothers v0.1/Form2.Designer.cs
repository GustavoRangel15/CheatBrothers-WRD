namespace Cheat_Brothers_v0._1.Resources
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string Name { get; private set; }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.INFO = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.WEBHOOK = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.ROBLOX_CLIENT = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.FTP = new System.Windows.Forms.TabPage();
            this.flatTextBox5 = new FlatUI.FlatTextBox();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flatTextBox4 = new FlatUI.FlatTextBox();
            this.flatTextBox3 = new FlatUI.FlatTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.INFO.SuspendLayout();
            this.WEBHOOK.SuspendLayout();
            this.ROBLOX_CLIENT.SuspendLayout();
            this.FTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(801, 30);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.INFO);
            this.materialTabControl1.Controls.Add(this.WEBHOOK);
            this.materialTabControl1.Controls.Add(this.ROBLOX_CLIENT);
            this.materialTabControl1.Controls.Add(this.FTP);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 99);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(801, 351);
            this.materialTabControl1.TabIndex = 1;
            // 
            // INFO
            // 
            this.INFO.Controls.Add(this.materialLabel1);
            this.INFO.Location = new System.Drawing.Point(4, 22);
            this.INFO.Name = "INFO";
            this.INFO.Padding = new System.Windows.Forms.Padding(3);
            this.INFO.Size = new System.Drawing.Size(793, 325);
            this.INFO.TabIndex = 0;
            this.INFO.Text = "INFO";
            this.INFO.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(449, 38);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Realmente não tem muita coisa aqui mas no futuro terá bastante \r\nfunções, como ti" +
    "rar Cookies Loggers do PC.\r\n";
            // 
            // WEBHOOK
            // 
            this.WEBHOOK.Controls.Add(this.materialRaisedButton1);
            this.WEBHOOK.Controls.Add(this.flatTextBox2);
            this.WEBHOOK.Controls.Add(this.flatTextBox1);
            this.WEBHOOK.Location = new System.Drawing.Point(4, 22);
            this.WEBHOOK.Name = "WEBHOOK";
            this.WEBHOOK.Padding = new System.Windows.Forms.Padding(3);
            this.WEBHOOK.Size = new System.Drawing.Size(793, 325);
            this.WEBHOOK.TabIndex = 1;
            this.WEBHOOK.Text = "WEBHOOK/API";
            this.WEBHOOK.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(364, 19);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "ENVIAR";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Location = new System.Drawing.Point(6, 42);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(352, 29);
            this.flatTextBox2.TabIndex = 1;
            this.flatTextBox2.Text = "Mensagem da Webhook";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(6, 7);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(352, 29);
            this.flatTextBox1.TabIndex = 0;
            this.flatTextBox1.Text = "URL da Webhook (Discord)";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // ROBLOX_CLIENT
            // 
            this.ROBLOX_CLIENT.Controls.Add(this.materialRaisedButton3);
            this.ROBLOX_CLIENT.Controls.Add(this.materialRaisedButton2);
            this.ROBLOX_CLIENT.Location = new System.Drawing.Point(4, 22);
            this.ROBLOX_CLIENT.Name = "ROBLOX_CLIENT";
            this.ROBLOX_CLIENT.Size = new System.Drawing.Size(793, 325);
            this.ROBLOX_CLIENT.TabIndex = 2;
            this.ROBLOX_CLIENT.Text = "ROBLOX CLIENT";
            this.ROBLOX_CLIENT.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(3, 45);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(151, 36);
            this.materialRaisedButton3.TabIndex = 3;
            this.materialRaisedButton3.Text = "VERSÃO DO ROBLOX";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click_1);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(3, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(143, 36);
            this.materialRaisedButton2.TabIndex = 2;
            this.materialRaisedButton2.Text = " Limpar o Roblox ";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // FTP
            // 
            this.FTP.Controls.Add(this.flatTextBox5);
            this.FTP.Controls.Add(this.materialRaisedButton4);
            this.FTP.Controls.Add(this.flatTextBox4);
            this.FTP.Controls.Add(this.flatTextBox3);
            this.FTP.Location = new System.Drawing.Point(4, 22);
            this.FTP.Name = "FTP";
            this.FTP.Size = new System.Drawing.Size(793, 325);
            this.FTP.TabIndex = 3;
            this.FTP.Text = "FTP";
            this.FTP.UseVisualStyleBackColor = true;
            // 
            // flatTextBox5
            // 
            this.flatTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox5.FocusOnHover = false;
            this.flatTextBox5.Location = new System.Drawing.Point(3, 73);
            this.flatTextBox5.MaxLength = 32767;
            this.flatTextBox5.Multiline = false;
            this.flatTextBox5.Name = "flatTextBox5";
            this.flatTextBox5.ReadOnly = false;
            this.flatTextBox5.Size = new System.Drawing.Size(262, 29);
            this.flatTextBox5.TabIndex = 3;
            this.flatTextBox5.Text = "Servidor FTP";
            this.flatTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox5.UseSystemPasswordChar = false;
            this.flatTextBox5.TextChanged += new System.EventHandler(this.flatTextBox5_TextChanged);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(271, 31);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(116, 36);
            this.materialRaisedButton4.TabIndex = 2;
            this.materialRaisedButton4.Text = "Ver arquivos";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // flatTextBox4
            // 
            this.flatTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox4.FocusOnHover = false;
            this.flatTextBox4.Location = new System.Drawing.Point(3, 38);
            this.flatTextBox4.MaxLength = 32767;
            this.flatTextBox4.Multiline = false;
            this.flatTextBox4.Name = "flatTextBox4";
            this.flatTextBox4.ReadOnly = false;
            this.flatTextBox4.Size = new System.Drawing.Size(262, 29);
            this.flatTextBox4.TabIndex = 1;
            this.flatTextBox4.Text = "Senha";
            this.flatTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox4.UseSystemPasswordChar = false;
            // 
            // flatTextBox3
            // 
            this.flatTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox3.FocusOnHover = false;
            this.flatTextBox3.Location = new System.Drawing.Point(3, 3);
            this.flatTextBox3.MaxLength = 32767;
            this.flatTextBox3.Multiline = false;
            this.flatTextBox3.Name = "flatTextBox3";
            this.flatTextBox3.ReadOnly = false;
            this.flatTextBox3.Size = new System.Drawing.Size(262, 29);
            this.flatTextBox3.TabIndex = 0;
            this.flatTextBox3.Text = "Usuário";
            this.flatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox3.UseSystemPasswordChar = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "FUNÇÕES BETA/SECRETAS";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.materialTabControl1.ResumeLayout(false);
            this.INFO.ResumeLayout(false);
            this.INFO.PerformLayout();
            this.WEBHOOK.ResumeLayout(false);
            this.WEBHOOK.PerformLayout();
            this.ROBLOX_CLIENT.ResumeLayout(false);
            this.ROBLOX_CLIENT.PerformLayout();
            this.FTP.ResumeLayout(false);
            this.FTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage INFO;
        private System.Windows.Forms.TabPage WEBHOOK;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatTextBox flatTextBox1;
        private System.Windows.Forms.TabPage ROBLOX_CLIENT;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage FTP;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private FlatUI.FlatTextBox flatTextBox4;
        private FlatUI.FlatTextBox flatTextBox3;
        private FlatUI.FlatTextBox flatTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}