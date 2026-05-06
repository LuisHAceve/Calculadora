using System.Xml;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool iniciarNuevaEntrada = true;
        private string? operacionPendiente;
        private decimal acumulador;
        public Form1()
        {
            InitializeComponent();
        }
        public void BotonDigito_Click(Object sender, EventArgs args)
        {
            if(sender is not Button boton)
            {
                return;
            }
            AgregarAPantalla(boton.Text);

        }
        private void AgregarAPantalla(string valor)
        {
            if(iniciarNuevaEntrada)
            {
                txtPantalla.Text = valor == "." ? "0." : valor;
                iniciarNuevaEntrada = false;
                return;
            }
            if(valor == "." && txtPantalla.Text.Contains('.',StringComparison.Ordinal))
            {
                return;
            }
            if((txtPantalla.Text == "0" || txtPantalla.Text == "-0") && valor != ".")
            {
                txtPantalla.Text = txtPantalla.Text.StartsWith("-", StringComparison.Ordinal)? $"-{valor}" : valor;
                return;
            }
            txtPantalla.Text += valor;
        }
        private void BotonOperador_Click (Object sender, EventArgs args)
        {
            if(sender is not Button boton || boton.Tag is not string operadorSeleccionado)
            {
                return;
            }
            if(!ObtenerValorPantalla(out var valorActual))
            {
                return;
            }
            if(operacionPendiente is not null && !iniciarNuevaEntrada)
            {
                if (!AplicarOperacionPendiente(valorActual, out var resultadoIntermedio))
                {
                    return;
                }
                acumulador = resultadoIntermedio;
                txtPantalla.Text = acumulador.ToString("0.############");
            }
            else
            {
                acumulador = valorActual;
            }
            operacionPendiente = operadorSeleccionado;
            iniciarNuevaEntrada = true;
            lblOperacion.Text = $"{acumulador.ToString("0.############")} {operadorSeleccionado}";

        }

        private bool AplicarOperacionPendiente(decimal valorActual, out decimal resultadoIntermedio)
        {
            resultadoIntermedio = acumulador;
            switch (operacionPendiente)
            {
                case "+":
                    resultadoIntermedio = acumulador + valorActual;
                    return true;  
                case "-":
                    resultadoIntermedio = acumulador - valorActual;
                    return true;
                case "*":
                    resultadoIntermedio = acumulador * valorActual;
                    return true;
                case "/":
                    if(valorActual == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Operacion no valida",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        //TODO: Limpiar pantalla
                        return false;
                    }
                    resultadoIntermedio = acumulador / valorActual;
                    return true;

                default: return false;
            }
        }

        private bool ObtenerValorPantalla(out decimal valor)
        {
            return decimal.TryParse(txtPantalla.Text, out valor);
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacionPendiente is null || !ObtenerValorPantalla(out var valor))
            {
                return;
            }
            if (iniciarNuevaEntrada)
            {
                valor = acumulador;
            }
            var valorAnterior = acumulador;
            if (!AplicarOperacionPendiente(valor, out var resultado))
            {
                return;
            }
            txtPantalla.Text = FormatearValor(resultado);
            lblOperacion.Text = $"{FormatearValor(valorAnterior)} {operacionPendiente} {FormatearValor(valor)}";
            acumulador = resultado;
            operacionPendiente = null;
            iniciarNuevaEntrada = true;
        }
        private static string FormatearValor(decimal valor)
        {
            return valor.ToString("0.############");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (iniciarNuevaEntrada)
            {
                return;
            }
            if (txtPantalla.Text.Length == 1 || (txtPantalla.Text.Length == 2 && txtPantalla.Text.StartsWith("-")))
            {
                txtPantalla.Text = "0";
                iniciarNuevaEntrada = true;
                return;
            }
            txtPantalla.Text = txtPantalla.Text[..^1];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            operacionPendiente = null;
            txtPantalla.Text = "0";
            lblOperacion.Text = "Lista para calcular";
        }
        private void btnCambiarSigno_Click(object sender, EventArgs e)
        {
            if(ObtenerValorPantalla(out var valor))
            {
                if(valor != 0)
                {
                    valor = valor * -1;
                    acumulador = valor;
                    txtPantalla.Text = valor.ToString();
                }
            }
        }
    }
}
