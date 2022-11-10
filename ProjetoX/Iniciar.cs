using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoX
{
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
        }

        private void btn_adiciona_Click(object sender, EventArgs e)
        {
            string nom = txb_nome.Text;
            string sobre = txb_sob.Text;
            int idad = 0;

            try
            {
                if (txb_nome.Text == "")
                {
                    MessageBox.Show("O campo não pode ficar em branco espertão");
                }
                else
                if (txb_sob.Text == "")
                {
                    MessageBox.Show("O campo não pode ficar em branco espertão");
                }
                else
                {
                    {
                        if (Regex.IsMatch(txb_nome.Text, @"\d"))
                        {
                            MessageBox.Show("Não Pode conter numero no nome amigão");
                        }
                        else
                        {
                            DateTime dat = DateTime.Parse(txb_idad.Text);
                            idad = DateTime.Now.Year - dat.Year;

                            if (idad > 18)
                            {
                                lbl_boas.Text = "Bem Vindo a Maior festa da sua vida irmaozinho! ";
                                lbl_boas.ForeColor = Color.DarkGreen;
                                lbl_resultado.Text = "Olá " + nom + "  " + sobre + " " + "Voçe Tem " + " " + idad + "  " + "Anos";
                                ptb_imagemcoreeto.Image = Properties.Resources.Aprovado;

                            }
                            else if (idad < 18)
                            {
                                lbl_boas.Text = "Opa Voce nao está atorizado a entrar, Volte quando for maior! ";
                                lbl_boas.ForeColor = Color.DarkRed;
                                lbl_resultado.Text = "Voçe não está na lista" + " " + nom + " " + sobre + " " + "Por ser menor idade";
                                ptb_imagemcoreeto.Image = Properties.Resources.Reprovado;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_resultado.Text = "Algo de errado não está certo";
                MessageBox.Show("Não pode conter letra na data");
            }
            

            

        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            ptb_imagemcoreeto = null;
            txb_nome.Text = null;
            txb_sob.Text = null;
            txb_idad.Text = null;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
