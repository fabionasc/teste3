using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int varValor = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                this.Text = "TESTE";
                this.Text = "Teste Alterado";
            }
            
        }

        private bool IsOnline()
        {
            return (varValor == 4);            
        }
    }
}
