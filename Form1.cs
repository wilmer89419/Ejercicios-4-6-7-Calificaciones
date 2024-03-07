namespace Calificaciones
{
    public partial class Form1 : Form
    {
        private int nota1, nota2, nota3, nota4, promedio;
        private int NotaCompletiva, TotalCompletivo, PruebaCompletiva;
        public Form1()
        {
            InitializeComponent();
        }

        //calcular calificacion
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtPruebaCompletiva.Clear();
            txtTotalCompletivo.Clear();
            txtTotalCompletivo.Clear();
            txtResultadoCompletivo.Clear();
            txtNotaCompletiva.Enabled = false;
            txtPruebaCompletiva.Enabled = false;
            txtTotalCompletivo.Enabled = false;
            txtResultadoCompletivo.Enabled = false;
            btnCompletivo.Enabled = false;


            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
            nota3 = int.Parse(txtNota3.Text);
            nota4 = int.Parse(txtNota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            NotaCompletiva = promedio / 2;





            lblResultadoNota1.Text = nota1.ToString();
            lblResultadoNota2.Text = nota2.ToString();
            lblResultadoNota3.Text = nota3.ToString();
            lblResultadoNota4.Text = nota4.ToString();
            lblResultadoPromedio.Text = promedio.ToString();


            //determinar si el estudiante aprobo o reprobo
            if (promedio >= 70)

            {

                txtResultadoEstado.Text = "Aprobado";
                txtResultadoEstado.ForeColor = Color.Green;
                txtNotaCompletiva.Clear();
            }

            else
            {

                txtResultadoEstado.Text = "Reprobado";
                txtResultadoEstado.ForeColor = Color.Red;
                txtPruebaCompletiva.Enabled = true;
                txtResultadoCompletivo.Enabled = true;
                btnCompletivo.Enabled = true;
                txtNotaCompletiva.Text = NotaCompletiva.ToString();




            }



        }

        //Calcular prueba completiva
        private void btnCompletivo_Click(object sender, EventArgs e)
        {

            PruebaCompletiva = int.Parse(txtPruebaCompletiva.Text);
            TotalCompletivo = (NotaCompletiva + PruebaCompletiva / 2);

            txtTotalCompletivo.Text = TotalCompletivo.ToString();

            //determinar si aprobo o reprobo la prueba completiva
            if (TotalCompletivo >= 70)
            {

                txtResultadoCompletivo.Text = "Aprobado";
                txtResultadoCompletivo.ForeColor = Color.Green;


            }

            else

            {
                txtResultadoCompletivo.Text = "Reprobado";
                txtResultadoCompletivo.ForeColor = Color.Red;

            }

        }

        //Limpiar o vaciar label y textbox
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultadoNota1.Text = String.Empty;
            lblResultadoNota2.Text = String.Empty;
            lblResultadoNota3.Text = String.Empty;
            lblResultadoNota4.Text = String.Empty;
            lblResultadoPromedio.Text = String.Empty;
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtResultadoEstado.Clear();
            txtPruebaCompletiva.Clear();
            txtNotaCompletiva.Clear();
            txtTotalCompletivo.Clear();
            txtResultadoCompletivo.Clear();
        }
        //Cerrar programa
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}