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
    public partial class FrmCacaNiquel: Form
    {
        private Random sorteio = new Random();
        private int niquel1, niquel2, niquel3;
        private int contaGiro = 0;
        private int contaNiquel = 1;
        public FrmCacaNiquel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrSorteioGeral_Tick(object sender, EventArgs e)
        {
            MostraNiquel();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            btnJogar.Text = "&Stop";
            tmrNiquel.Enabled = true;

        }

        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
            contaGiro++;
            if (contaNiquel == 1)
            {
                niquel1 = sorteio.Next(0, 10);
                lblNiquel1.Text = niquel1.ToString();
            }
            else if (contaNiquel == 2)
            {
                niquel2 = sorteio.Next(0, 10);
                lblNiquel2 .Text = niquel2.ToString();
            }
            else if (contaNiquel == 3)
            {
                niquel3 = sorteio.Next(0,10);
                lblNiquel3 .Text = niquel3.ToString();
            }
            else
            {
                //atingiu a condição de término
                tmrNiquel.Enabled = false;
                Ganhou();
                lblNiquel1.Text = String.Empty;
                lblNiquel2.Text = String.Empty;
                lblNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
            }
            if (contaGiro == 10)
            {
                contaNiquel++;
                contaGiro = 0;
            }

        }

        private void lblNiquel1_Click(object sender, EventArgs e)
        {

        }

        private void btGirar_Click(object sender, EventArgs e)
        {
            MostraNiquel();
        }

        private void FrmCacaNiquel_Load(object sender, EventArgs e)
        {

        }

        private void MostraNiquel()
        {
            niquel1 = sorteio.Next(0, 10);
            niquel2 = sorteio.Next(0, 10);
            niquel3 = sorteio.Next(0, 10);
            lblNiquel1.Text = niquel1.ToString();
            lblNiquel2.Text = niquel2.ToString();
            lblNiquel3.Text = niquel3.ToString();
        }

        private void Ganhou()
        {
            if (niquel1 == niquel2 && niquel2 == niquel3)
            {
                MessageBox.Show("Parabéns vc ganhou um milhão!\n\n" +
                         "Sequência: " + niquel1.ToString() + " - " +
                                         niquel2.ToString() + " - " +
                                         niquel3.ToString(),
                                         "Tigrinho Wins!!!",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (niquel1 == niquel2 || niquel1 == niquel3 || niquel2 == niquel3)
            {
                MessageBox.Show("Parabéns vc ganhou meio milhão!\n\n" +
                         "Sequência: " + niquel1.ToString() + " - " +
                                         niquel2.ToString() + " - " +
                                         niquel3.ToString(),
                                         "Tigrinho Wins!!!",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Que pena, você só ganhou um milhinho!\n\n" +
                         "Sequência: " + niquel1.ToString() + " - " +
                                         niquel2.ToString() + " - " +
                                         niquel3.ToString(),
                                         "Tigrinho Wins!!!",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
