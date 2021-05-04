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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            String nome, password;
            nome = txt_nome.Text;
            password = txt_password.Text;

            if (check(nome,password))
            {
                Console.WriteLine("bem vindo ao sistema");
                Form3 form3 = new Form3();
                Form1 form1 = new Form1();
                form3.Show();
                

               
            

            }
            else
            {
                Console.WriteLine("dados invalidos");
            }

        }
        public Boolean check(String user, String senha)
        {

            return user.Equals("Clesio") && senha.Equals("1234");
        }
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
