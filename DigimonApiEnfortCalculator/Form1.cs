using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigimonApiEnfortCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaTextoDigitado(e);
        }

        private void VerificaTextoDigitado(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;


            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaTextoDigitado(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string verificado = ValidarParametrosAbiDigievolucaoRegrasao(Leveltxt.Text, Nivelcbox, Acaocbbox, Abitxt.Text);
            if (string.IsNullOrEmpty(verificado))
            {
                if (Acaocbbox.SelectedItem.ToString().Equals("Digievolução"))
                {
                    Resultadolbl.Text = CalcularAbiDigievolucao(int.Parse(Leveltxt.Text), Nivelcbox.SelectedItem.ToString(), int.Parse(Abitxt.Text)).ToString();
                }
                else
                {
                    Resultadolbl.Text = CalcularAbiRegrasao(int.Parse(Leveltxt.Text), Nivelcbox.SelectedItem.ToString(), int.Parse(Abitxt.Text)).ToString();
                }
            }
            else
            {
                MessageBox.Show(verificado);
            }
        }

        private int CalcularAbiDigievolucao(int level, string nvevolutivo, int abiatual)
        {
            int abiniveldigimon = RetornaAbiNivelEvolutivo(nvevolutivo);
            return ((level - 1) / 10) + abiniveldigimon + abiatual;
        }
        private int CalcularAbiRegrasao(int level, string nvevolutivo, int abiatual)
        {
            int abiniveldigimon = RetornaAbiRegracao(nvevolutivo);
            return ((level / 5)) + abiniveldigimon + abiatual;
        }
        private int CalculaAbiTreino(int abitreino)
        {
            return (abitreino / 2) + 50;
        }

        private int RetornaAbiNivelEvolutivo(string nivelevolutivo)
        {
            int abinivel = 0;
            switch (nivelevolutivo)
            {
                case "In Training II":
                    abinivel = 0;
                    break;
                case "Rokie":
                    abinivel = 1;
                    break;
                case "Champion":
                    abinivel = 1;
                    break;
                case "Ultimate":
                    abinivel = 2;
                    break;
                case "Mega":
                    abinivel = 2;
                    break;
                case "Ultra":
                    abinivel = 3;
                    break;

            }
            return abinivel;
        }

        private int RetornaAbiRegracao(string nivelevolutivo)
        {
            int abinivel = 0;
            switch (nivelevolutivo)
            {
                case "In Training I":
                    abinivel = 1;
                    break;
                case "In Training II":
                    abinivel = 2;
                    break;
                case "Rokie":
                    abinivel = 3;
                    break;
                case "Champion":
                    abinivel = 4;
                    break;
                case "Ultimate":
                    abinivel = 5;
                    break;
                case "Mega":
                    abinivel = 6;
                    break;


            }
            return abinivel;
        }
        private string ValidarParametrosAbiDigievolucaoRegrasao(string level, ComboBox nivel, ComboBox acao, string abi)
        {
            string erro = "";
            if (String.IsNullOrEmpty(level))
            {
                erro = "Level Precisa ser informado";
            }
            else
            {
                if (int.Parse(level) < 1)
                {

                    erro = "Level invalido";
                }
            }
            if (nivel.SelectedItem == null)
            {
                erro = "Nivel Precisa ser informado";
            }
            if (acao.SelectedItem == null)
            {
                erro = "Acao Precisa ser selecionado";
            }
            if (String.IsNullOrEmpty(abi))
            {
                erro = "Abi Precisa ser informado";
            }
            else
            {
                if (int.Parse(abi) < 5 || int.Parse(abi) > 200)
                {

                    erro = "Abi invalida";
                }
            }
            return erro;
        }

        private string ValidarAbiTreino(string abi)
        {
            string erro = "";
            if (String.IsNullOrEmpty(abi))
            {
                erro = "Abi Precisa ser informado";
            }
            else
            {
                if (int.Parse(abi) < 5 || int.Parse(abi) > 200)
                {

                    erro = "Abi invalida";
                }
            }
            return erro;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Acaocbbox.SelectedItem.ToString().Equals("Regresão") && !Nivelcbox.Items.Contains("In Training I"))
            {
                Nivelcbox.Items.Insert(0, "In Training I");
                Leveltxt.Text = "";
                Abitxt.Text = "";
                Nivelcbox.SelectedIndex = -1;
            }
            else
            {
                Nivelcbox.Items.Remove("In Training I");
                Leveltxt.Text = "";
                Abitxt.Text = "";
                Nivelcbox.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string verificado = ValidarAbiTreino(AbiTreinoTxt.Text);
            if (string.IsNullOrEmpty(verificado))
            {
                ResultadoTreinolbl.Text = CalculaAbiTreino(int.Parse(AbiTreinoTxt.Text)).ToString();
            }
            else
            {
                MessageBox.Show(verificado);
            }

        }

        private void AbiTreinoTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaTextoDigitado(e);
        }

        private void Abitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaTextoDigitado(e);
        }
    }

    }
