namespace Servidor
{
    partial class Servidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LabStatus = new System.Windows.Forms.Label();
            this.TxtPorta = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.TxtIp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnIniciar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LabStatus);
            this.groupBox2.Controls.Add(this.TxtPorta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(75, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(389, 290);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servidor";
            // 
            // TxtIp
            // 
            this.TxtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIp.Location = new System.Drawing.Point(139, 86);
            this.TxtIp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIp.MaxLength = 300;
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(192, 36);
            this.TxtIp.TabIndex = 19;
            this.TxtIp.Text = "192.168.0.20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Porta:";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.White;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(171, 217);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(108, 46);
            this.BtnIniciar.TabIndex = 17;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "IP:";
            // 
            // LabStatus
            // 
            this.LabStatus.AutoSize = true;
            this.LabStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.LabStatus.Location = new System.Drawing.Point(211, 23);
            this.LabStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabStatus.Name = "LabStatus";
            this.LabStatus.Size = new System.Drawing.Size(153, 31);
            this.LabStatus.TabIndex = 15;
            this.LabStatus.Text = "Desligado!";
            // 
            // TxtPorta
            // 
            this.TxtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorta.Location = new System.Drawing.Point(139, 149);
            this.TxtPorta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPorta.MaxLength = 4;
            this.TxtPorta.Name = "TxtPorta";
            this.TxtPorta.Size = new System.Drawing.Size(192, 36);
            this.TxtPorta.TabIndex = 11;
            this.TxtPorta.Text = "8888";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(75, 356);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(389, 373);
            this.txtLogs.TabIndex = 16;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 768);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Servidor";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabStatus;
        private System.Windows.Forms.TextBox TxtPorta;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.TextBox txtLogs;
    }
}

