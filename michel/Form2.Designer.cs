
namespace Clesio
{
    partial class Form2
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
            this.txt_proprietario = new System.Windows.Forms.TextBox();
            this.txt_matriculaCarro = new System.Windows.Forms.TextBox();
            this.txt_modeloCarro = new System.Windows.Forms.TextBox();
            this.data_fabrico = new System.Windows.Forms.DateTimePicker();
            this.guiaPagamento = new System.Windows.Forms.TextBox();
            this.data_importacao = new System.Windows.Forms.DateTimePicker();
            this.nr_verbete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimenascimentoCliente = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumCarta = new System.Windows.Forms.TextBox();
            this.checkBoxSexoF = new System.Windows.Forms.CheckBox();
            this.checkBoxSexoM = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNumBi = new System.Windows.Forms.TextBox();
            this.comboBoxTipoCombus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipodeVeiculo = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_proprietario
            // 
            this.txt_proprietario.Location = new System.Drawing.Point(147, 58);
            this.txt_proprietario.Name = "txt_proprietario";
            this.txt_proprietario.Size = new System.Drawing.Size(283, 20);
            this.txt_proprietario.TabIndex = 0;
            // 
            // txt_matriculaCarro
            // 
            this.txt_matriculaCarro.Location = new System.Drawing.Point(150, 26);
            this.txt_matriculaCarro.Name = "txt_matriculaCarro";
            this.txt_matriculaCarro.Size = new System.Drawing.Size(330, 20);
            this.txt_matriculaCarro.TabIndex = 1;
            this.txt_matriculaCarro.TextChanged += new System.EventHandler(this.txt_matricula_TextChanged);
            // 
            // txt_modeloCarro
            // 
            this.txt_modeloCarro.Location = new System.Drawing.Point(150, 62);
            this.txt_modeloCarro.Name = "txt_modeloCarro";
            this.txt_modeloCarro.Size = new System.Drawing.Size(330, 20);
            this.txt_modeloCarro.TabIndex = 2;
            this.txt_modeloCarro.TextChanged += new System.EventHandler(this.txt_marcaCarro_TextChanged);
            // 
            // data_fabrico
            // 
            this.data_fabrico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_fabrico.Location = new System.Drawing.Point(150, 98);
            this.data_fabrico.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.data_fabrico.MinDate = new System.DateTime(1853, 1, 1, 0, 0, 0, 0);
            this.data_fabrico.Name = "data_fabrico";
            this.data_fabrico.Size = new System.Drawing.Size(142, 20);
            this.data_fabrico.TabIndex = 3;
            this.data_fabrico.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // guiaPagamento
            // 
            this.guiaPagamento.Location = new System.Drawing.Point(150, 170);
            this.guiaPagamento.Name = "guiaPagamento";
            this.guiaPagamento.Size = new System.Drawing.Size(330, 20);
            this.guiaPagamento.TabIndex = 4;
            // 
            // data_importacao
            // 
            this.data_importacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_importacao.Location = new System.Drawing.Point(150, 135);
            this.data_importacao.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.data_importacao.Name = "data_importacao";
            this.data_importacao.Size = new System.Drawing.Size(142, 20);
            this.data_importacao.TabIndex = 5;
            this.data_importacao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // nr_verbete
            // 
            this.nr_verbete.Location = new System.Drawing.Point(150, 210);
            this.nr_verbete.Name = "nr_verbete";
            this.nr_verbete.Size = new System.Drawing.Size(330, 20);
            this.nr_verbete.TabIndex = 6;
            this.nr_verbete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do proprietario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricula do carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marca e Modelo do carro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data de fabrico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de importacao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numero guia de pagamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numero do verbete";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimenascimentoCliente);
            this.groupBox1.Controls.Add(this.textBoxNumCarta);
            this.groupBox1.Controls.Add(this.checkBoxSexoF);
            this.groupBox1.Controls.Add(this.checkBoxSexoM);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNumBi);
            this.groupBox1.Controls.Add(this.txt_proprietario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 237);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Propretario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Data de Nascimento";
            // 
            // dateTimenascimentoCliente
            // 
            this.dateTimenascimentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimenascimentoCliente.Location = new System.Drawing.Point(147, 160);
            this.dateTimenascimentoCliente.Name = "dateTimenascimentoCliente";
            this.dateTimenascimentoCliente.Size = new System.Drawing.Size(200, 20);
            this.dateTimenascimentoCliente.TabIndex = 15;
            // 
            // textBoxNumCarta
            // 
            this.textBoxNumCarta.Location = new System.Drawing.Point(147, 126);
            this.textBoxNumCarta.Name = "textBoxNumCarta";
            this.textBoxNumCarta.Size = new System.Drawing.Size(283, 20);
            this.textBoxNumCarta.TabIndex = 14;
            // 
            // checkBoxSexoF
            // 
            this.checkBoxSexoF.AutoSize = true;
            this.checkBoxSexoF.Location = new System.Drawing.Point(188, 199);
            this.checkBoxSexoF.Name = "checkBoxSexoF";
            this.checkBoxSexoF.Size = new System.Drawing.Size(32, 17);
            this.checkBoxSexoF.TabIndex = 13;
            this.checkBoxSexoF.Text = "F";
            this.checkBoxSexoF.UseVisualStyleBackColor = true;
            // 
            // checkBoxSexoM
            // 
            this.checkBoxSexoM.AutoSize = true;
            this.checkBoxSexoM.Location = new System.Drawing.Point(147, 198);
            this.checkBoxSexoM.Name = "checkBoxSexoM";
            this.checkBoxSexoM.Size = new System.Drawing.Size(35, 17);
            this.checkBoxSexoM.TabIndex = 12;
            this.checkBoxSexoM.Text = "M";
            this.checkBoxSexoM.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sexo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Numero da Carta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numero do BI";
            // 
            // textBoxNumBi
            // 
            this.textBoxNumBi.Location = new System.Drawing.Point(147, 90);
            this.textBoxNumBi.Name = "textBoxNumBi";
            this.textBoxNumBi.Size = new System.Drawing.Size(283, 20);
            this.textBoxNumBi.TabIndex = 8;
            // 
            // comboBoxTipoCombus
            // 
            this.comboBoxTipoCombus.DisplayMember = "Gasolina";
            this.comboBoxTipoCombus.FormattingEnabled = true;
            this.comboBoxTipoCombus.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Outros"});
            this.comboBoxTipoCombus.Location = new System.Drawing.Point(150, 250);
            this.comboBoxTipoCombus.Name = "comboBoxTipoCombus";
            this.comboBoxTipoCombus.Size = new System.Drawing.Size(330, 21);
            this.comboBoxTipoCombus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo de Combustivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tipo de veiculo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTipodeVeiculo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nr_verbete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxTipoCombus);
            this.groupBox2.Controls.Add(this.data_importacao);
            this.groupBox2.Controls.Add(this.txt_matriculaCarro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.guiaPagamento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_modeloCarro);
            this.groupBox2.Controls.Add(this.data_fabrico);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 330);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Veiculo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxTipodeVeiculo
            // 
            this.comboBoxTipodeVeiculo.FormattingEnabled = true;
            this.comboBoxTipodeVeiculo.Items.AddRange(new object[] {
            "Ligeiro",
            "Pesado"});
            this.comboBoxTipodeVeiculo.Location = new System.Drawing.Point(150, 285);
            this.comboBoxTipodeVeiculo.Name = "comboBoxTipodeVeiculo";
            this.comboBoxTipodeVeiculo.Size = new System.Drawing.Size(330, 21);
            this.comboBoxTipodeVeiculo.TabIndex = 17;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(592, 235);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 42);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(592, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(763, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 603);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listagem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(592, 354);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(120, 49);
            this.buttonListar.TabIndex = 21;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1313, 627);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_proprietario;
        private System.Windows.Forms.TextBox txt_matriculaCarro;
        private System.Windows.Forms.TextBox txt_modeloCarro;
        private System.Windows.Forms.DateTimePicker data_fabrico;
        private System.Windows.Forms.TextBox guiaPagamento;
        private System.Windows.Forms.DateTimePicker data_importacao;
        private System.Windows.Forms.TextBox nr_verbete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoCombus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTipodeVeiculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNumBi;
        private System.Windows.Forms.CheckBox checkBoxSexoM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimenascimentoCliente;
        private System.Windows.Forms.TextBox textBoxNumCarta;
        private System.Windows.Forms.CheckBox checkBoxSexoF;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonListar;
    }
}