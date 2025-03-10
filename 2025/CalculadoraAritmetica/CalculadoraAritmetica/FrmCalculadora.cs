using CodingSeb.ExpressionEvaluator;

namespace CalculadoraAritmetica
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "1";
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "3";
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "6";
        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "7";
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "8";
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "9";
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text += "0";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (!SimboloRepetido('.'))
                TxtPantalla.Text += ".";
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            if (!SimboloRepetido('+'))
                TxtPantalla.Text += "+";
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (!SimboloRepetido('-'))
                TxtPantalla.Text += "-";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!SimboloRepetido('*'))
                TxtPantalla.Text += "*";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (!SimboloRepetido('/'))
                TxtPantalla.Text += "/";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = "";
        }

        private char UltimoCaracter()
        {
            return TxtPantalla.Text[TxtPantalla.Text.Length - 1];
        }

        private bool EsSimbolo(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '.';
        }

        private bool SimboloRepetido(char simbolo)
        {
            bool repetido = false;

            if (TxtPantalla.Text.Length > 0)
            {
                char ultimoCaracter = UltimoCaracter();
                if (EsSimbolo(ultimoCaracter))
                    repetido = true;
            }

            return repetido;
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = TxtPantalla.Text;

                ExpressionEvaluator evaluator = new ExpressionEvaluator();

                var resultado = evaluator.Evaluate(expresion);

                TxtPantalla.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtPantalla.Text = "Error";
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text.Length > 0)
            {
                string pantalla = TxtPantalla.Text;
                TxtPantalla.Text = pantalla.Substring(0, pantalla.Length - 1);
            }
        }
    }
}
