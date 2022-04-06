namespace atv_02_23._03
{

    /* Atividade feita dia 23/03/2022 
    *Aluno Vinicius de Freitas Pereira
    *RA: 2222106123


    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            lblS.Visible = true;
            lblR.Visible = true;
            button1.Visible = true;

            int.TryParse(txtValor1.Text, out var valorA);
            int.TryParse(txtValor2.Text, out var valorB);
            int.TryParse(txtValor3.Text, out var valorC);

            int delta = (valorB * valorB) - (4 * valorA * valorC);
                      

                if (valorC > 0)
                {
                    lblValor1.Text = "DE  (" + txtValor1.Text + "x²) + (" + txtValor2.Text + "x)" + " + (" + txtValor3.Text + ") = 0";
                }
                else
                {
                    lblValor1.Text = "DE  (" + txtValor1.Text + "x²) + (" + txtValor2.Text + "x) + (" + txtValor3.Text + ") = 0";

                }

          
            if (valorA != 0)
            {


                if (delta < 0)
                {

                    MessageBox.Show("O valor de delta é " + delta + ", ou seja negativo, portando as raizes não podem ser calcualda !", "Erro!");
                    lblResultado.Text = " SEM SOLUÇÃO \n Delta = " + delta;
                    btCalcular.Visible = false;
                    return;



                }
                else
                {

                    float Resultado = (((valorB * (-1))) + Convert.ToSingle(Math.Sqrt(delta))) / (2 * valorA);
                    float Resultado2 = (((valorB * (-1))) - Convert.ToSingle(Math.Sqrt(delta))) / (2 * valorA);

                    btCalcular.Visible = false;
                    button1.Visible = true;
                    lblR.Visible = true;
                    lblSeta.Visible = true;

                    if (Resultado == Resultado2)
                    {
                        lblResultado.Text = "X =" + Math.Round(Resultado, 2) + "\nDELTA = " + delta;
                    }
                    else
                    {


                        lblResultado.Text = "X¹ = " + Math.Round(Resultado, 2).ToString() + " e X² = " + Math.Round(Resultado2, 2).ToString() + " \nDELTA = " + delta;
                    }
                }


            }
            else
            {
                MessageBox.Show("Preencha o campo A com um valor diferente de 0!", "Erro!");

                lblResultado.Text = " SEM SOLUÇÃO, \n RAIZ QUADRADA IMPOSSIVEL DE CALCULAR";
                }

                lblEquacao.Text = "X =  - (" + valorB + ") ± √ (" + valorB + "²) - " + "4 * (" + valorA + ") * (" + valorC + ")";
                lblB.Text = "                 2 * (" + valorA + ")";

                lbl1p1.Text = "X =  - (" + valorB + ") ± √ (" + delta + ")";
                lbl1p2.Text = "               "+  2 * valorA ;

                



        }



        private void button1_Click(object sender, EventArgs e)
        {
            lblSeta.Visible = false;
            lblS.Visible = false;
            lblR.Visible = false;
            button1.Visible = false;
            lblEquacao.Text = null;
            lblResultado.Text = null;
            lbl1p1.Text = null;
            lbl1p2.Text = null;
            lblValor1.Text=null;
            lblB.Text=null;
            txtValor1.Text = null;
            txtValor2.Text = null;         
            txtValor3.Text = null;
            btCalcular.Visible = true;



        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicação criada por\nVinicius de Freitas Pereira\nRA: 2222106123" +
                "\nSérie 01 / A Turno MATUTINO\nUnidade CAMPUS SANTO AMARO \nCurso 13215 - versão: 221 - Análise e Desenvolvimento"
                + "\nProfessor Thiago Graziani Traue");
        }
    }
    
    
}
