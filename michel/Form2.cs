using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clesio
{
    public partial class Form2 : Form
    {

        List<Proprietarios> cl = new List<Proprietarios>();
    
        
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_marcaCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_proprietario.Clear();
            textBoxNumBi.Clear();
            textBoxNumCarta.Clear();
            txt_matriculaCarro.Clear();
            txt_modeloCarro.Clear();
            guiaPagamento.Clear();
            nr_verbete.Clear();
            checkBoxSexoM.Enabled = false;
            checkBoxSexoF.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cl.Add(new Proprietarios()
            {

                

                Nome = txt_proprietario.Text, NumBI = textBoxNumBi.Text, NumCarta = textBoxNumCarta.Text, DatadeNascimento = dateTimenascimentoCliente.Value,
                Matricula = txt_matriculaCarro.Text,
                Modelo = txt_modeloCarro.Text,

                TipodeCombustivel = comboBoxTipoCombus.SelectedIndex,
                Tipodeveiculo = comboBoxTipodeVeiculo.SelectedIndex,
                Numdoguia = guiaPagamento.Text,
                Numdeverbete = nr_verbete.Text,
                DatadeFabrico1 = data_fabrico.Value,
                DatadeImportacao1 = data_importacao.Value
            });

           
                
            MessageBox.Show("Gravado com sucesso");



        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cl;
       



        }
    }
}
