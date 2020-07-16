namespace DigimonApiEnfortCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Resultadolbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Abitxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nivelcbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Leveltxt = new System.Windows.Forms.TextBox();
            this.Acaocbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultadoTreinolbl = new System.Windows.Forms.Label();
            this.lblResultadoTreino = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AbiTreinoTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.Resultadolbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Abitxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nivelcbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Leveltxt);
            this.groupBox1.Controls.Add(this.Acaocbbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de ganho de abi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Selecione uma acão:";
            // 
            // Resultadolbl
            // 
            this.Resultadolbl.AutoSize = true;
            this.Resultadolbl.Location = new System.Drawing.Point(236, 160);
            this.Resultadolbl.Name = "Resultadolbl";
            this.Resultadolbl.Size = new System.Drawing.Size(0, 15);
            this.Resultadolbl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abitxt
            // 
            this.Abitxt.Location = new System.Drawing.Point(272, 64);
            this.Abitxt.Name = "Abitxt";
            this.Abitxt.Size = new System.Drawing.Size(100, 23);
            this.Abitxt.TabIndex = 6;
            this.Abitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abitxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Abi Atual:";
            // 
            // Nivelcbox
            // 
            this.Nivelcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nivelcbox.FormattingEnabled = true;
            this.Nivelcbox.Items.AddRange(new object[] {
            "In Training II",
            "Rokie",
            "Champion",
            "Ultimate",
            "Mega",
            "Ultra"});
            this.Nivelcbox.Location = new System.Drawing.Point(51, 109);
            this.Nivelcbox.Name = "Nivelcbox";
            this.Nivelcbox.Size = new System.Drawing.Size(121, 23);
            this.Nivelcbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel:";
            // 
            // Leveltxt
            // 
            this.Leveltxt.Location = new System.Drawing.Point(49, 72);
            this.Leveltxt.Name = "Leveltxt";
            this.Leveltxt.Size = new System.Drawing.Size(97, 23);
            this.Leveltxt.TabIndex = 2;
            this.Leveltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Acaocbbox
            // 
            this.Acaocbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acaocbbox.FormattingEnabled = true;
            this.Acaocbbox.Items.AddRange(new object[] {
            "Digievolução",
            "Regresão"});
            this.Acaocbbox.Location = new System.Drawing.Point(128, 20);
            this.Acaocbbox.Name = "Acaocbbox";
            this.Acaocbbox.Size = new System.Drawing.Size(121, 23);
            this.Acaocbbox.TabIndex = 1;
            this.Acaocbbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultadoTreinolbl);
            this.groupBox2.Controls.Add(this.lblResultadoTreino);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.AbiTreinoTxt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular Abi Treino";
            // 
            // ResultadoTreinolbl
            // 
            this.ResultadoTreinolbl.AutoSize = true;
            this.ResultadoTreinolbl.Location = new System.Drawing.Point(272, 66);
            this.ResultadoTreinolbl.Name = "ResultadoTreinolbl";
            this.ResultadoTreinolbl.Size = new System.Drawing.Size(0, 15);
            this.ResultadoTreinolbl.TabIndex = 6;
            // 
            // lblResultadoTreino
            // 
            this.lblResultadoTreino.AutoSize = true;
            this.lblResultadoTreino.Location = new System.Drawing.Point(247, 65);
            this.lblResultadoTreino.Name = "lblResultadoTreino";
            this.lblResultadoTreino.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoTreino.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(179, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Resultado:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AbiTreinoTxt
            // 
            this.AbiTreinoTxt.Location = new System.Drawing.Point(72, 24);
            this.AbiTreinoTxt.Name = "AbiTreinoTxt";
            this.AbiTreinoTxt.Size = new System.Drawing.Size(100, 23);
            this.AbiTreinoTxt.TabIndex = 2;
            this.AbiTreinoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AbiTreinoTxt1_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Abi Atual:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(659, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 130);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Personalitys";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "5% SPD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nimble:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "5% INT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Brainy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "5% DEF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Defender:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "5% ATK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fighter:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "5% SP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lively:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "5% HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durable:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Acaocbbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Leveltxt;
        private System.Windows.Forms.ComboBox Nivelcbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Abitxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultadolbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultadoTreino;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AbiTreinoTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResultadoTreinolbl;
        private System.Windows.Forms.Label label19;
    }
}

