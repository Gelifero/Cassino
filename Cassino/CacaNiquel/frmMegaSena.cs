using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class frmMegaSena: Form
    {
        private Random Mega = new Random();
        private int numeroSorteado;
        private int[,] cartao;
        private char[,] jogoVelha = new char[,] { 
                                                 { 'X', 'O', 'X' },
                                                 { '0', 'X', 'O' },
                                                 { 'X', 'X', 'X' } };
        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void btnSortearNumeros_Click(object sender, EventArgs e)
        {
            //consistência de dados - verificar quantidade de cartões
            if (String.IsNullOrWhiteSpace(txtQtdeCartoes.Text))
            {
                MessageBox.Show("Informe a quantidade de cartões desejadas!!", 
                                 "Mega sena",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                return;
            }

            cartao = new int[Convert.ToInt32(txtQtdeCartoes.Text),6];
            GerarCartoes();
        }

        private void GerarCartoes()
        {
            for (int i=0;i<Convert.ToInt32(txtQtdeCartoes.Text);i++)
            {
                for (int j = 0;j<6;j++)
                {
                    cartao[i, j] = numeroSorteado;
                    numeroSorteado = Mega.Next(1, 61);
                    lblNumeros.Text = Convert.ToString(numeroSorteado)+ "-";
                }
                lstCartoes.Items.Add(lblNumeros.Text);
                lblNumeros.Text = "";
            }
        }
    }
}
