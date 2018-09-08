namespace JogoSockets
{
    partial class Jogador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOla = new System.Windows.Forms.Label();
            this.labelVezJogada = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn3C = new System.Windows.Forms.Button();
            this.btn3B = new System.Windows.Forms.Button();
            this.btn3A = new System.Windows.Forms.Button();
            this.btn2C = new System.Windows.Forms.Button();
            this.btn2B = new System.Windows.Forms.Button();
            this.btn2A = new System.Windows.Forms.Button();
            this.btn1C = new System.Windows.Forms.Button();
            this.btn1B = new System.Windows.Forms.Button();
            this.btn1A = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modoSockets = new System.Windows.Forms.ComboBox();
            this.rbtnJogadorO = new System.Windows.Forms.RadioButton();
            this.rbtnJogadorX = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtServidorPorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JogoSockets.Properties.Resources._1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 517);
            this.panel1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.labelOla);
            this.groupBox3.Controls.Add(this.labelVezJogada);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(266, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 470);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Partida";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "A";
            // 
            // labelOla
            // 
            this.labelOla.AutoSize = true;
            this.labelOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOla.Location = new System.Drawing.Point(24, 32);
            this.labelOla.Name = "labelOla";
            this.labelOla.Size = new System.Drawing.Size(0, 16);
            this.labelOla.TabIndex = 16;
            // 
            // labelVezJogada
            // 
            this.labelVezJogada.AutoSize = true;
            this.labelVezJogada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVezJogada.Location = new System.Drawing.Point(106, 80);
            this.labelVezJogada.Name = "labelVezJogada";
            this.labelVezJogada.Size = new System.Drawing.Size(0, 16);
            this.labelVezJogada.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn3C, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3B, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3A, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn2C, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn2B, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn2A, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn1C, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1B, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1A, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 157);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 300);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btn3C
            // 
            this.btn3C.Location = new System.Drawing.Point(230, 203);
            this.btn3C.Name = "btn3C";
            this.btn3C.Size = new System.Drawing.Size(109, 94);
            this.btn3C.TabIndex = 8;
            this.btn3C.UseVisualStyleBackColor = true;
            // 
            // btn3B
            // 
            this.btn3B.Location = new System.Drawing.Point(116, 203);
            this.btn3B.Name = "btn3B";
            this.btn3B.Size = new System.Drawing.Size(108, 94);
            this.btn3B.TabIndex = 7;
            this.btn3B.UseVisualStyleBackColor = true;
            // 
            // btn3A
            // 
            this.btn3A.Location = new System.Drawing.Point(3, 203);
            this.btn3A.Name = "btn3A";
            this.btn3A.Size = new System.Drawing.Size(107, 94);
            this.btn3A.TabIndex = 6;
            this.btn3A.UseVisualStyleBackColor = true;
            // 
            // btn2C
            // 
            this.btn2C.Location = new System.Drawing.Point(230, 103);
            this.btn2C.Name = "btn2C";
            this.btn2C.Size = new System.Drawing.Size(109, 93);
            this.btn2C.TabIndex = 5;
            this.btn2C.UseVisualStyleBackColor = true;
            // 
            // btn2B
            // 
            this.btn2B.Location = new System.Drawing.Point(116, 103);
            this.btn2B.Name = "btn2B";
            this.btn2B.Size = new System.Drawing.Size(108, 93);
            this.btn2B.TabIndex = 4;
            this.btn2B.UseVisualStyleBackColor = true;
            // 
            // btn2A
            // 
            this.btn2A.Location = new System.Drawing.Point(3, 103);
            this.btn2A.Name = "btn2A";
            this.btn2A.Size = new System.Drawing.Size(107, 93);
            this.btn2A.TabIndex = 3;
            this.btn2A.UseVisualStyleBackColor = true;
            // 
            // btn1C
            // 
            this.btn1C.Location = new System.Drawing.Point(230, 3);
            this.btn1C.Name = "btn1C";
            this.btn1C.Size = new System.Drawing.Size(109, 93);
            this.btn1C.TabIndex = 2;
            this.btn1C.UseVisualStyleBackColor = true;
            // 
            // btn1B
            // 
            this.btn1B.Location = new System.Drawing.Point(116, 3);
            this.btn1B.Name = "btn1B";
            this.btn1B.Size = new System.Drawing.Size(108, 93);
            this.btn1B.TabIndex = 1;
            this.btn1B.UseVisualStyleBackColor = true;
            // 
            // btn1A
            // 
            this.btn1A.BackgroundImage = global::JogoSockets.Properties.Resources.x;
            this.btn1A.Location = new System.Drawing.Point(3, 3);
            this.btn1A.Name = "btn1A";
            this.btn1A.Size = new System.Drawing.Size(107, 93);
            this.btn1A.TabIndex = 0;
            this.btn1A.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.modoSockets);
            this.groupBox2.Controls.Add(this.rbtnJogadorO);
            this.groupBox2.Controls.Add(this.rbtnJogadorX);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 163);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogador e placar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nº de vitórias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modo:";
            // 
            // modoSockets
            // 
            this.modoSockets.FormattingEnabled = true;
            this.modoSockets.Items.AddRange(new object[] {
            "[Selecione]",
            "Síncrono",
            "Assíncrono"});
            this.modoSockets.Location = new System.Drawing.Point(62, 114);
            this.modoSockets.Name = "modoSockets";
            this.modoSockets.Size = new System.Drawing.Size(156, 24);
            this.modoSockets.TabIndex = 13;
            // 
            // rbtnJogadorO
            // 
            this.rbtnJogadorO.AutoSize = true;
            this.rbtnJogadorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJogadorO.Location = new System.Drawing.Point(6, 76);
            this.rbtnJogadorO.Name = "rbtnJogadorO";
            this.rbtnJogadorO.Size = new System.Drawing.Size(90, 20);
            this.rbtnJogadorO.TabIndex = 14;
            this.rbtnJogadorO.TabStop = true;
            this.rbtnJogadorO.Text = "Jogador O";
            this.rbtnJogadorO.UseVisualStyleBackColor = true;
            // 
            // rbtnJogadorX
            // 
            this.rbtnJogadorX.AutoSize = true;
            this.rbtnJogadorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJogadorX.Location = new System.Drawing.Point(8, 40);
            this.rbtnJogadorX.Name = "rbtnJogadorX";
            this.rbtnJogadorX.Size = new System.Drawing.Size(88, 20);
            this.rbtnJogadorX.TabIndex = 13;
            this.rbtnJogadorX.TabStop = true;
            this.rbtnJogadorX.Text = "Jogador X";
            this.rbtnJogadorX.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(130, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(130, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.txtLogs);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtServidorPorta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTestar);
            this.groupBox1.Controls.Add(this.txtServidorIP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 301);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(59, 132);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 16);
            this.labelStatus.TabIndex = 9;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(15, 266);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(93, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // txtServidorPorta
            // 
            this.txtServidorPorta.Location = new System.Drawing.Point(62, 62);
            this.txtServidorPorta.Name = "txtServidorPorta";
            this.txtServidorPorta.Size = new System.Drawing.Size(156, 22);
            this.txtServidorPorta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Logs da conexão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porta:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(123, 266);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(95, 23);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP:";
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(20, 93);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(198, 23);
            this.btnTestar.TabIndex = 4;
            this.btnTestar.Text = "Testar conexão";
            this.btnTestar.UseVisualStyleBackColor = true;
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.Location = new System.Drawing.Point(62, 27);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(156, 22);
            this.txtServidorIP.TabIndex = 5;
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(20, 178);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(198, 79);
            this.txtLogs.TabIndex = 10;
            // 
            // Jogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 516);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jogador";
            this.Text = "Jogo da Velha - Multijogador via Sockets";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelOla;
        private System.Windows.Forms.Label labelVezJogada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn3C;
        private System.Windows.Forms.Button btn3B;
        private System.Windows.Forms.Button btn3A;
        private System.Windows.Forms.Button btn2C;
        private System.Windows.Forms.Button btn2B;
        private System.Windows.Forms.Button btn2A;
        private System.Windows.Forms.Button btn1C;
        private System.Windows.Forms.Button btn1B;
        private System.Windows.Forms.Button btn1A;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox modoSockets;
        private System.Windows.Forms.RadioButton rbtnJogadorO;
        private System.Windows.Forms.RadioButton rbtnJogadorX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtServidorPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogs;
    }
}

