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
    public partial class Form1 : Form
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Conta> Contas = new List<Conta>();

        public Form1()
        {
            InitializeComponent();

        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Clientes;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = Clientes;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = Contas;
            comboBox2.DisplayMember = "Numero";
            comboBox2.ValueMember = "Id";

        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroConta cadastroConta = new CadastroConta();
            cadastroConta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clienteId = Convert.ToInt32(comboBox1.SelectedValue);
            var contaId = Convert.ToInt32(comboBox2.SelectedValue);

            var ClienteObj = Clientes.Find(x => x.Id == clienteId);
            var ContaObj = Contas.Find(x => x.Id == contaId);

            ClienteObj.Conta = ContaObj;

            this.Hide();
            GerenciamentoConta gConta = new GerenciamentoConta(ClienteObj);
            gConta.Show();

        }
    }
}
