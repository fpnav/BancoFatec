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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToDecimal(textBox1.Text);



        }
    }
}
