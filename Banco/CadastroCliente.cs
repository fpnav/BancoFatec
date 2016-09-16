using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banco
{
    public partial class CadastroCliente : Form
    {

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);
            var nome = textBox2.Text;
            var idade = Convert.ToInt32(textBox3.Text);

            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nome;
            cliente.Idade = idade;

            Form1.Clientes.Add(cliente);
            this.Close();

        }

        private void CadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
