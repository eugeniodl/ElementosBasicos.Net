namespace pjPagoEmpleados
{
    public partial class frmPagoEmpleado : Form
    {
        public frmPagoEmpleado()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Recuperando la información registrada
            string empleado = txtEmpleado.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            //Realizando los cálculos
            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            //Imprimiendo resultados
            lblMontoBruto.Text = sueldoBruto.ToString();
            lblMontoDescuento.Text = sueldoBruto.ToString();
            lblMontoNeto.Text = sueldoNeto.ToString();
        }
    }
}