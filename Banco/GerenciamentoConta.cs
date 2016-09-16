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
    public partial class GerenciamentoConta : Form
    {
        public Cliente Cliente { get; set; }

        public GerenciamentoConta()
        {
            InitializeComponent();
        }

        public GerenciamentoConta(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            label4.Text = Cliente.Conta.Saldo.ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valorSaque = Convert.ToDecimal(textBox1.Text);
            Cliente.Conta.Saldo -= valorSaque;
            label4.Text = Cliente.Conta.Saldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var valorDeposito = Convert.ToDecimal(textBox2.Text);

        }

        private void GerenciamentoConta_Load(object sender, EventArgs e)
        {

        }
    }
}
