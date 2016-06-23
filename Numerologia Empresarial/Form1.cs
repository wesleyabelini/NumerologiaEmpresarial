using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerologia_Empresarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Número";

            string nome = " - " + textBoxNomeEmpresa.Text;

            if(textBoxNomeEmpresa.Text!="")
            {
                string n1 = "Número 1 – As empresas associadas ao número um são caracterizadas pela razão, justiça e determinação. São empresas cheias de energia e pró atividade.\n\nIndicações: Empresas ligadas a área de financiamento e crédito, imobiliárias, escritórios de contabilidade.";
                string n2 = "Número 2 – Empresas que possuem o número dois tem a característica de luta por uma causa ou ideal. São empresas onde a perseverança será recompensada com o sucesso.\n\nIndicações: Em função das suas características este é um número indicado para qualquer empresa.São empresas que também se encaixam na característica do número onze.";
                string n3 = "Número 3 – Essas empresas tem como principal característica a comunicação, felicidade, amor e fecundidade. São empresas onde a energia criativa aflora e quando orientadas no sentido da inovação o sucesso é garantido.\n\nIndicações: Empresas dedicadas às criação, como agências de publicidade, agências de marketing digital, comunicação social e criação em geral.";
                string n4 = "Número 4 – Do ponto de vista da numerologia empresarial as empresas com número quatro não são muito indicadas, pois o número está relacionado à carta do Imperador, representando a estabilidade proteção imperativa e subjugação.\n\nIndicações: Por ser um número com características de difícil conciliação com o espírito empreendedor, não indicado para o seu negócio.";
                string n5 = "Número 5 – As empresas com número cinco são caracterizadas pela inteligência, inspiração e acumulação. São empresas que tendem à acumulação, tanto de pessoas quanto de objetos e por isso mesmo precisa se manter bem disciplinada.\n\nIndicações: Devido às suas características este número é indicado para empresas ligadas às áreas do turismo, lazer, buffet de festas e entretenimento em geral.";
                string n6 = "Número 6 – São empresas que tem como característica principal a beleza e harmonia. O foco está na busca do equilíbrio e bem estar o que é facilmente alcançado pelo número seis.\n\nIndicações: Pelas suas características na numerologia empresarial este é o número ideal para empresas ligadas ao segmento de alimentação e também empresas na área de beleza e estética como salão de beleza e centros de estética.";
                string n7 = "Número 7 – As empresas regidas pelo número sete tendem a ter uma personalidade introspectiva e fechada. A energia deste número favorece o isolamento e ao foco no emocional.\n\nIndicações: Como as características deste número são incompatíveis com o espírito empreendedor, não é um número indicado para qualquer tipo de negócio.";
                string n8 = "Número 8 – Este é um número típico de empresas extremamente competitivas e ousadas, com forte foco na movimentação financeira. Geralmente são empresas bastante agressivas em seus mercados.\n\nIndicações: Pelas características do número, ele é altamente indicado para empresas do setor financeiro, como corretoras de valores, financeiras e bancos.";
                string n9 = "Número 9 – O número nove caracteriza empresas que passam constantemente por processos de encerramento de ciclos e para conseguirem crescer, precisam se adaptar rapidamente a mudanças constantes de ambiente negocial.\n\nIndicações: Como as características desse número são de difícil assimilação pelo ser humano, não é um número muito indicado para quem deseja abrir um negócio.";
                string n11 = "Número 11 – São empresas que estão sempre preparadas para encarar desafios e superar obstáculos. O número onze possui uma energia muito positiva que faz com estas empresas estejam sempre prontas para superar metas e atingir objetivos cada vez maiores. O significado do número onze em termos empresariais é muito parecido com o do número dois.\n\nIndicações: Devido às suas características positivas, este é um número indicado para qualquer tipo de empresa que deseje alcançar o sucesso.";

                int n = calcularNumero(textBoxNomeEmpresa);

                if(n ==1)
                {
                    textBox1.Text = n1;
                    label2.Text += " 1" + nome;
                }
                else if(n==2)
                {
                    textBox1.Text = n2;
                    label2.Text += " 2" + nome;
                }
                else if(n==3)
                {
                    textBox1.Text = n3;
                    label2.Text += " 3" + nome;
                }
                else if(n==4)
                {
                    textBox1.Text = n4;
                    label2.Text += " 4" + nome;
                }
                else if(n==5)
                {
                    textBox1.Text = n5;
                    label2.Text += " 5" + nome;
                }
                else if(n==6)
                {
                    textBox1.Text = n6;
                    label2.Text += " 6" + nome;
                }
                else if(n==7)
                {
                    textBox1.Text = n7;
                    label2.Text += " 7" + nome;
                }
                else if(n==8)
                {
                    textBox1.Text = n8;
                    label2.Text += " 8" + nome;
                }
                else if(n==9)
                {
                    textBox1.Text = n9;
                    label2.Text += " 9" + nome;
                }
                else if(n==11)
                {
                    textBox1.Text = n11;
                    label2.Text += " 11" + nome;
                }
            }

            textBoxNomeEmpresa.Clear();  
        }

        private int calcularNumero(TextBox text)
        {
            int numero = 0;
            int numeroFinal = 0;

            char[] nomeEmpresa = text.Text.ToCharArray();

            foreach(char letras in nomeEmpresa)
            {
                string letra = letras.ToString();

                if(letra =="A" || letra == "J" || letra=="S")
                {
                    numero += 1;
                }
                else if(letra =="B" || letra =="K" || letra == "T")
                {
                    numero += 2;
                }
                else if(letra=="C" || letra == "L" || letra =="U")
                {
                    numero += 3;
                }
                else if(letra =="D" || letra =="M" || letra =="V")
                {
                    numero += 4;
                }
                else if(letra=="E" || letra =="N" || letra=="W")
                {
                    numero += 5;
                }
                else if(letra=="F" || letra=="O" || letra=="X")
                {
                    numero += 6;
                }
                else if(letra=="G" || letra=="P" || letra=="Y")
                {
                    numero += 7;
                }
                else if(letra=="H" || letra=="Q" || letra=="Z")
                {
                    numero += 8;
                }
                else if(letra=="I" || letra=="R")
                {
                    numero += 9;
                }
            }

            if(numero!=11)
            {
                char[] nresult = numero.ToString().ToCharArray();

                foreach (char x in nresult)
                {
                    x.ToString();
                    numeroFinal += Convert.ToInt32(x.ToString());

                    if(numeroFinal>11)
                    {
                        char[] numeroFinal2 = numeroFinal.ToString().ToCharArray();
                        numeroFinal = 0;

                        foreach (char y in numeroFinal2)
                        {
                            y.ToString();
                            numeroFinal += Convert.ToInt32(y.ToString());
                        }
                    }
                    else if(numeroFinal==10)
                    {
                        numeroFinal = 1;
                    }
                }
            }
            else
            {
                numeroFinal = 11;
            }

            return numeroFinal;
        }

        private void textBoxNomeEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                buttonCalcular.PerformClick();
            }
        }
    }
}
