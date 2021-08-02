using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulos.BL;
using Triangulos.DL;

namespace Triangulos.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        RepositorioDeTriangulos repositorio = new RepositorioDeTriangulos();

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmTriangulosAE frm = new FrmTriangulosAE();
            frm.Text = "Nuevo Triángulo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                Triangulo r = frm.GetTriangulo();
                repositorio.Agregar(r);
                DataGridViewRow p = ConstruirFila(r);
                AgregarFila(p);
                MessageBox.Show("Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            repositorio.EstaModificado = true;
        }
        private void AgregarFila(DataGridViewRow p)
        {
            dgvDatos.Rows.Add(p);
        }

        private DataGridViewRow ConstruirFila(Triangulo triangulo)
        {
            DataGridViewRow p = new DataGridViewRow();
            p.CreateCells(dgvDatos);
            SetearFila(p, triangulo);
            return p;
        }

        private void SetearFila(DataGridViewRow r, Triangulo triangulo)
        {
            r.Cells[cmnTriangulo.Index].Value = triangulo.ToString();
            r.Cells[cmnPerimetro.Index].Value = triangulo.GetPerimetro();
            r.Cells[cmnSuperficie.Index].Value = triangulo.GetSuperficie();

            r.Tag = triangulo;


        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            if (repositorio.EstaModificado)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    repositorio.GuardarDatosArchivo();
                }
            }

            Close();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow p = dgvDatos.SelectedRows[0];
                Triangulo triangulo = (Triangulo)p.Tag;
                repositorio.Borrar(triangulo);
                dgvDatos.Rows.Remove(p);
                MessageBox.Show("Triángulo eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                repositorio.EstaModificado = true;

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow p = dgvDatos.SelectedRows[0];
                Triangulo triangulo = (Triangulo)p.Tag;
                FrmTriangulosAE frm = new FrmTriangulosAE();
                frm.Text = "Edición de un triángulo";
                frm.SetTriangulo(triangulo);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    triangulo = frm.GetTriangulo();
                    SetearFila(p, triangulo);
                    MessageBox.Show("Triángulo editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    repositorio.EstaModificado = true;

                }

            }
        }
        private List<Triangulo> lista;
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            if (repositorio.GetCantidad() > 0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var triangulo in lista)
            {
                DataGridViewRow p = ConstruirFila(triangulo);
                AgregarFila(p);
            }
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarporPerimetro();
            MostrarDatosEnGrilla();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarporPerimetroDes();
            MostrarDatosEnGrilla();
        }
    }

}
