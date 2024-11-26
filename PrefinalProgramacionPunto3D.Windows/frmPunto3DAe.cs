using PrefinalProgramacionPunto3D.Entidades;
using PrefinalProgramacionPunto3D.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrefinalProgramacionPunto3D.Windows
{
    public partial class frmPunto3DAe : Form
    {
        private Punto3D? punto;
        private readonly RepositorioPuntos? _repo;
        public frmPunto3DAe(RepositorioPuntos repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        public Punto3D? GetPunto()
        {
            return punto;
        }

        public void SetPunto(Punto3D punto)
        {
            this.punto = punto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (punto is null)
                {
                    punto = new Punto3D();
                }
                punto.X = int.Parse(txtX.Text);
                punto.Y = int.Parse(txtY.Text);
                punto.Z = int.Parse(txtZ.Text);
                punto.Color = txtColor.Text;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtX.Text, out int sM) ||
                sM <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtY, "Cordenada X mal ingresado");
            }
            if (!int.TryParse(txtY.Text, out int y) ||
                y <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtY, "Cordenada Y mal ingresado");
            }
            if (!int.TryParse(txtZ.Text, out int z) ||
                z <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtZ, "Cordenada Z mal ingresado");
            }
            if (_repo!.Existe(punto!))
            {
                valido = false;
                errorProvider1.SetError(txtX, "Cordenada existente!!!");
            }
            return valido;
        }
    }
}

