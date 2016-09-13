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
            //Clientes = new List<Cliente>();
            CadastroCliente cadCliente = new CadastroCliente();
            //cadCliente.ClientesList = Clientes;
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
        }
    }
}
