namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Por favor, ingresa tu nombre.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNom.Focus();
                return;
            }
            string motivo = "";
            if (rbConsulta.Checked)
            {
                motivo = "consulta";
            }
            else if (rbQueja.Checked)
            {
                motivo = "queja";
            }
            else if (rbSugerencia.Checked)
            {
                motivo = "sugerencia";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un motivo de contacto.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string mensaje = $"{txtNom.Text} tiene un motivo {motivo}.";
            if (chkRespuesta.Checked)
            {
                mensaje += "\nSolicito recibir respuesta.";
            }
            txtcon.Text = mensaje;

        }
        private void lblPrivacidad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Politica de privacidad:/n/nTus datos personales estan protegidos y"+
                "solo seran utilizados" +
                "para responder a tu solicitud de contacto",
                "politica de privacidad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

