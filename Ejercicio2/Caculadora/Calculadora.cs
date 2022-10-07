namespace Caculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.ClsSuma objSuma = new Clases.ClsSuma();
        Clases.ClsResta objResta = new Clases.ClsResta();
        Clases.ClsMultiplicacion objMultiplicacion = new Clases.ClsMultiplicacion();
        Clases.ClsDivision objDivision = new Clases.ClsDivision();

        private void button15_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBoxSalida.Text);
            double sum;
            double res;
            double mul;
            string div;

            switch (operador)
            {
                case "+":
                    sum = objSuma.Sumar((primero), (segundo));
                    textBoxSalida.Text = sum.ToString();
                    break;
                case "-":
                    res = objResta.Restar((primero), (segundo));
                    textBoxSalida.Text = res.ToString();
                    break;
                case "*":
                    mul = objMultiplicacion.Multiplicar((primero), (segundo));
                    textBoxSalida.Text = mul.ToString();
                    break;
                case "/":
                    div = objDivision.divide((primero), (segundo));
                    textBoxSalida.Text = div.ToString();
                    break;
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + "9";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            textBoxSalida.Text = textBoxSalida.Text + ".";
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBoxSalida.Text);
            ////limpiamos la pantalla con clear
            textBoxSalida.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBoxSalida.Text);
            ////limpiamos la pantalla con clear
            textBoxSalida.Clear();
        }

        private void botonMul_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBoxSalida.Text);
            ////limpiamos la pantalla con clear
            textBoxSalida.Clear();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBoxSalida.Text);
            ////limpiamos la pantalla con clear
            textBoxSalida.Clear();
        }

        private void botonBorraTodo_Click(object sender, EventArgs e)
        {
            textBoxSalida.Clear();
        }
    }
}