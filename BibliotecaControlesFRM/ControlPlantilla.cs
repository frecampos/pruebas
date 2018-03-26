using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaControlesFRM
{
    public partial class ControlPlantilla : UserControl
    {
        public ControlPlantilla()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn cl0 = new DataGridViewTextBoxColumn();
            cl0.HeaderText = "Rut";
            cl0.Width = 100;
            cl0.ReadOnly = true;

            DataGridViewTextBoxColumn cl1 = new DataGridViewTextBoxColumn();
            cl1.HeaderText = "Nombre";
            cl1.Width = 100;
            cl1.ReadOnly = true;

            DataGridViewTextBoxColumn cl2 = new DataGridViewTextBoxColumn();
            cl2.HeaderText = "Nombre";
            cl2.Width = 100;
            cl2.ReadOnly = true;

            dtgGrilla.Columns.Add(cl0);
            dtgGrilla.Columns.Add(cl1);
            dtgGrilla.Columns.Add(cl2);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String rut = txtRut.Text.Trim().Length > 0 ? txtRut.Text : "";
            String nombre = txtNombre.Text.Trim().Length > 0 ? txtRut.Text : "";
            String apellido = txtApellido.Text.Trim().Length > 0 ? txtRut.Text : "";
            MessageBox.Show("Datos Control Cargados");

            
            dtgGrilla.Rows.Add(rut, nombre, apellido);
        }
    }
}
