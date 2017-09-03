namespace NetworkCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubnetMask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHostRange = new System.Windows.Forms.TextBox();
            this.textBoxBroadcast = new System.Windows.Forms.TextBox();
            this.textBoxNetwork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPv4 Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(29, 89);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(96, 20);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            // 
            // textBoxSubnetMask
            // 
            this.textBoxSubnetMask.Location = new System.Drawing.Point(28, 142);
            this.textBoxSubnetMask.Name = "textBoxSubnetMask";
            this.textBoxSubnetMask.Size = new System.Drawing.Size(96, 20);
            this.textBoxSubnetMask.TabIndex = 4;
            this.textBoxSubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Network Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Broadcast Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Host Address Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // textBoxHostRange
            // 
            this.textBoxHostRange.Location = new System.Drawing.Point(26, 308);
            this.textBoxHostRange.Name = "textBoxHostRange";
            this.textBoxHostRange.Size = new System.Drawing.Size(191, 20);
            this.textBoxHostRange.TabIndex = 10;
            this.textBoxHostRange.Text = "192.168.255.255 - 255.255.255.255";
            this.textBoxHostRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBroadcast
            // 
            this.textBoxBroadcast.Location = new System.Drawing.Point(26, 269);
            this.textBoxBroadcast.Name = "textBoxBroadcast";
            this.textBoxBroadcast.Size = new System.Drawing.Size(96, 20);
            this.textBoxBroadcast.TabIndex = 11;
            // 
            // textBoxNetwork
            // 
            this.textBoxNetwork.Location = new System.Drawing.Point(26, 230);
            this.textBoxNetwork.Name = "textBoxNetwork";
            this.textBoxNetwork.Size = new System.Drawing.Size(96, 20);
            this.textBoxNetwork.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Given an IPv4 address and a subnet mask,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(25, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "the network, broadcast and first/last host";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(25, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "addresses will be calculated!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(260, 344);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNetwork);
            this.Controls.Add(this.textBoxBroadcast);
            this.Controls.Add(this.textBoxHostRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSubnetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubnetMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHostRange;
        private System.Windows.Forms.TextBox textBoxBroadcast;
        private System.Windows.Forms.TextBox textBoxNetwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

