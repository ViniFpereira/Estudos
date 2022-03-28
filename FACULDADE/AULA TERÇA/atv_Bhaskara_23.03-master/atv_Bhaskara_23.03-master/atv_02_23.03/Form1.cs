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
            lblR.Visible = true;
            lblS.Visible = true;
            lblSeta.Visible = true;
            button1.Visible = true;


            int.TryParse(txtValor1.Text, out var valorA0);
            int.TryParse(txtValor2.Text, out var valorB0);
            int.TryParse(txtValor3.Text, out var valorC0);
            int.TryParse(txtValor1.Text, out var valorA);
            int.TryParse(txtValor2.Text, out var valorB);
            int.TryParse(txtValor3.Text, out var valorC);

            int delta = (valorB * valorB) - (4 * valorA * valorC);

          
            int.TryParse(txtValor3.Text, out var ValorCpositivo);

                if (ValorCpositivo > 0)
                {
                    lblValor1.Text = "DE  (" + txtValor1.Text + "x²) + (" + txtValor2.Text + "x)" + " + " + txtValor3.Text + " = 0";
                }
                else
                {
                    lblValor1.Text = "DE  (" + txtValor1.Text + "x²) + (" + txtValor2.Text + "x) " + txtValor3.Text + " = 0";

                }



                int.TryParse(txtValor1.Text, out var valor1);

            if (valor1 != 0)
            {


                if (delta < 0)
                {

                    MessageBox.Show("O valor de delta é " + delta + ", ou seja negativo, portando as raizes não podem ser calcualdas !", "Erro!");
                    lblResultado.Text = " SEM SOLUÇÃO";

                }
                else
                {

                    float Resultado = (((valorB * (-1))) + Convert.ToSingle(Math.Sqrt(delta))) / (2 * valorA);
                    float Resultado2 = (((valorB * (-1))) - Convert.ToSingle(Math.Sqrt(delta))) / (2 * valorA);



                    lblResultado.Text = "X¹ = " + Resultado.ToString() + " e X² = " + Resultado2.ToString();
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

        private void lbl1p1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSeta.Visible = false;
            lblS.Visible = false;
            lblR.Visible = false;
            button1.Visible = false;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            lblEquacao.Text = null;
            lblResultado.Text = null;
            lbl1p1.Text = null;
            lbl1p2.Text = null;
            lblValor1.Text=null;
            lblB.Text=null;


        }

       }
    
    
}
