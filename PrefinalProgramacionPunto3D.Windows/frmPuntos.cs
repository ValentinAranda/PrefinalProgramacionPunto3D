using PrefinalProgramacionPunto3D.Entidades;
using PrefinalProgramacionPunto3D.Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace PrefinalProgramacionPunto3D.Windows

{
    public partial class frmPuntos : Form
    {
        private RepositorioPuntos? repositorio;
        private int cantidadRegistros;
        private List<Punto3D>? puntos;
        public frmPuntos()
        {
            InitializeComponent();
            repositorio = new RepositorioPuntos();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPunto3DAe frm = new frmPunto3DAe(repositorio!) { Text = "Agregar punto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Punto3D? punto = frm.GetPunto();
            try
            {
                if (!repositorio!.Existe(punto!))
                {
                    repositorio.AgregarPunto(punto!);
                    DataGridViewRow r = ConstruirFila(dgvDatos);
                    SetearFila(r, punto!);
                    AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Registro existente!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public void SetearFila(DataGridViewRow r, Punto3D obj)
        {
            r.Cells[0].Value = obj.X;
            r.Cells[1].Value = obj.Y;
            r.Cells[2].Value = obj.Z;
            r.Cells[3].Value = obj.Color!.ToString();
            r.Cells[4].Value = obj.CalcularDistancia().ToString("N2");

            r.Tag = obj;
        }
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Punto3D punto = (Punto3D)r.Tag!;
            DialogResult dr = MessageBox.Show("¿Desea borrar el punto?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            try
            {
                repositorio!.EliminarPunto(punto);
                EliminarFila(r, dgvDatos);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EliminarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Punto3D? punto = (Punto3D)r.Tag!;
            frmPunto3DAe frm = new frmPunto3DAe(repositorio!) { Text = "Editar punto" };
            frm.SetPunto(punto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                punto = frm.GetPunto();
                SetearFila(r, punto!);
                MessageBox.Show("Registro editado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void MostrarDatosGrilla()
        {
            LimpiarGrilla(dgvDatos);
            foreach (var item in puntos!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }

        private void área09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puntos= repositorio!.OrdenarAsc();
            MostrarDatosGrilla();
        }

        private void área90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puntos = repositorio!.OrdenarDesc();
            MostrarDatosGrilla();

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            puntos = repositorio!.ObtenerPuntos();
            MostrarDatosGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repositorio!.GuardarDatos();
            MessageBox.Show("Fin del Programa", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void frmPunto_Load(object sender, EventArgs e)
        {
            cantidadRegistros = repositorio!.GetHashCode();
            if (cantidadRegistros > 0)
            {
                puntos = repositorio.ObtenerPuntos();
                MostrarDatosGrilla();
                MostrarCantidadRegistros();
            }

        }

        private void MostrarCantidadRegistros()
        {
            txtCantidad.Text = cantidadRegistros.ToString();
        }
    }
}