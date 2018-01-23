using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        SoundPlayer sound = new SoundPlayer("Negado.wav");
        //música para erro

        double primeiroNumero = 0, segundoNumero = 0, resultado = 0;
        //guardar numeros digitados

        string operacao;
        //guardar a operação

        bool validaIgual = false, validaOperacao = false;
        //- validaIgual = caso não tenha apertado o igual para finalizar uma operação (false)
        ///não permite que aperte o sinal de novo
        //- validaOperacao = caso já tenha sido inserido uma operação (true) impede que seja
        ///inserido outra


        public Calculadora()
        {
            InitializeComponent();
        }

        private void InserirNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            //captura o botão clicado
            
            if (Resultado.Text == "0" && botao.Text != ",")
            {//para quando aperta clear ou inicia a calculadora sobreescreve o 0 existente
                Resultado.Clear();
                Resultado.Text += botao.Text;
                validaIgual = false;
            }
            else if (botao.Text == "," && Resultado.Text.Contains(",") == false)
            {//impede que seja digitada 2 vírgulas em número e que a vírgula use o 0 do clear ou do inicio da calculadora                
                if (Resultado.Text != "" && validaIgual == false) 
                {
                    Resultado.Text += botao.Text;
                }
                else if (validaIgual == true)
                {
                    Resultado.Text = "0,";
                }
                else
                {
                    sound.Play();
                }
            }
            else
            {
                if (validaIgual == true)
                {//sobrescreve o resultado a pós o final da operação
                    Resultado.Clear();
                    Resultado.Text += botao.Text;
                    validaIgual = false;
                }
                else
                {
                    Resultado.Text += botao.Text;
                }

            }

        }
        private void btnNegativo_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                double numeroNegativo;
                numeroNegativo = -1 * double.Parse(Resultado.Text);
                Resultado.Text = numeroNegativo.ToString();
            }
        }

        //exibir resultado
        private void Igual_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "" && validaIgual == false && validaOperacao == true)
            {//se a caixa não estiver vazia, não tiver clicado no igual e já tenha sido selecionada a
             ///operação
                segundoNumero = double.Parse(Resultado.Text);
                operacoes();
                tela.Text += segundoNumero;
                validaOperacao = false;
                Resultado.Text = resultado.ToString();
            }
            else if (Resultado.Text != "" && validaIgual == true)
            {
                primeiroNumero = double.Parse(Resultado.Text);
                operacoes();
                tela.Text = primeiroNumero + operacao + segundoNumero;
                validaOperacao = false;
                Resultado.Text = resultado.ToString();
            }
            else
            {
                tela.Text = "0";
                sound.Play();
            }
        }

        //realizar as operações
        private void Operacao_Click(object sender, EventArgs e)
        {
            //captura o botão clicado
            Button botao = (Button)sender;
            if (Resultado.Text != "" && validaOperacao == false)
            {
                primeiroNumero = double.Parse(Resultado.Text);
                //primerionumero recebe o digitado
                operacao = botao.Text;
                tela.Text = primeiroNumero + operacao;
                Resultado.Clear();
                validaOperacao = true;
            }
            else
            {
                sound.Play();
            }
        }

        //fazer as operações 
        private void operacoes()
        {
            //o próximo número diigtado é guardado no segundoNumero
            validaIgual = true;
            switch (operacao)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    break;
                default:
                    sound.Play();
                    break;
            }
        }

        //apagar tela de escrever
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            validaOperacao = false;
        }

        //limpar tudo
        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            primeiroNumero = 0;
            resultado = 0;
            segundoNumero = 0;
            Resultado.Text = "0";
            tela.Clear();
            operacao = "";
            validaIgual = false;
            validaOperacao = false;
        }

        //acesso pelo teclado
        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //NUMÉRICOS NOTEBOOK
                case Keys.D0:
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                    btn8.PerformClick();
                    break;
                case Keys.D9:
                    btn9.PerformClick();
                    break;
                case Keys.Oemcomma:
                    btnVirgula.PerformClick();
                    break;
                //NUMÉRICOS PC
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                //OPERAÇÃO NOTEBOOK
                case Keys.Oemplus:
                    btnIgual.PerformClick();
                    break;
                //OPERAÇÃO PC
                case Keys.Subtract:
                    btnSub.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMul.PerformClick();
                    break;
                case Keys.Add:
                    btnSom.PerformClick();
                    break;
                case Keys.Divide:
                    btnDiv.PerformClick();
                    break;
                //OUTROS
                case Keys.Delete:
                    btnLimparTudo.PerformClick();
                    break;
            }
        }
    }
}
