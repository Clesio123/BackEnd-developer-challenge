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
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        //calculo de taxa
        int ano;
        double valorPagamento;
        int anoactual = 2021;

        int anoimportacao;
        private void button1_Click(object sender, EventArgs e)
        {

            anoimportacao = int.Parse(textBox1.Text);

            ano = anoactual - anoimportacao; 



            if (ano <= 6)
            {
                ValorPagamento = 200.000;
            }

            else if (ano >= 6 && ano <= 12)
            {
                ValorPagamento = 100.000;
            }
            else if (ano > 12 && ano <= 25)
            {
                ValorPagamento = 50.000 ;
            }
            else { };
            labelResultado.Text = ValorPagamento.ToString();
           
        }

        List<Pagamentos> pgm = new List<Pagamentos>();

        public double ValorPagamento { get => valorPagamento; set => valorPagamento = value; }

        private void button2_Click(object sender, EventArgs e)
        {
           
             
            MessageBox.Show("Gravado com sucesso");

            pgm.Add(new Pagamentos() { ValorPagamento = double.Parse(labelResultado.Text  )});


            dataGridView1.DataSource = pgm;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.TableName = "ValorPagamento";
            table.WriteXml(@"C:\Users\User\Desktop\Clesio\myxml.xml");

        }
    }
}
