namespace pjPagoEmpleados
{
    public partial class frmPagoEmpleado : Form
    {
        public frmPagoEmpleado()
        {
            InitializeComponent();
        }

        private void frmPagoEmpleado_Load(object sender, EventArgs e)
        {
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
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
            lblMontoBruto.Text = sueldoBruto.ToString("C");
            lblMontoDescuento.Text = sueldoBruto.ToString("C");
            lblMontoNeto.Text = sueldoNeto.ToString("C");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtHoras.Clear();
            txtCosto.Clear();
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?",
                                 "Control de pago",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}