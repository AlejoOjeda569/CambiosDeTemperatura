using System.Data.SqlTypes;

namespace WinFormsPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var numero = double.Parse(txtCelsius.Text);
                DataGridViewRow r = construirfila();
                Setearfila(r, numero);
                Agregarfila(r);
                MessageBox.Show("Registro de los datos", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                    );
                inicializarDatos();
            }
        }

        private void inicializarDatos()
        {
            txtCelsius.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtCelsius.Focus();
        }
        private bool ValidarDatos()
        {
            bool esvalido = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtCelsius.Text, out double nro))
            {
                esvalido = false;
                errorProvider1.SetError(txtCelsius, "Nro fuera de la linea");
            }
            return esvalido;
        }

        private void Agregarfila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void Setearfila(DataGridViewRow r, double numero)
        {
            r.Cells[ColCelcius.Index].Value = numero;
            r.Cells[ColFarenheit.Index].Value = convertirFarenheit(numero);
            r.Cells[ColRankine.Index].Value = convertirRamkine(numero);

        }

        private object convertirRamkine(double numero) => (numero + 273.15) * 9 / 5;


        private object convertirFarenheit(double numero) => (numero * 9 / 5) + 32;

        private DataGridViewRow construirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }
        private void bntSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro?", "Comfirmacion",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }
       












      

    }
}