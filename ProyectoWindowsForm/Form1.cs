using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioWebJava.WebServiceMYSQLClient WS;
                WS = new ServicioWebJava.WebServiceMYSQLClient();
                int op = WS.Validar(txtUsuario.Text, txtPass.Text);
                if (op==0)
                {
                    MessageBox.Show("No Existe Usuario");
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Proporciona información sobre una referencia cultural concreta (denominada una configuración regional para el desarrollo de código no administrado). La información incluye los nombres de la referencia cultural, el sistema de escritura, el calendario usado, el criterio de ordenación y el formato de las fechas y los números.
             */
            CultureInfo ci = new CultureInfo("fr");

            Assembly a = Assembly.Load("ProyectoWindowsForm");//carga el ensamblado de ProyectoWindowsForm
            ResourceManager rm = new ResourceManager("ProyectoWindowsForm.Lang.Strings",a);//busca los recursos que contienen los archivos con el nombre raiz especificados
            lblUsuario.Text = rm.GetString("Usuario", ci);//recupera el valor del recurso cadena
            lblPass.Text = rm.GetString("Password", ci);
            btnAceptar.Text = rm.GetString("Aceptar", ci);
            btnSalir.Text = rm.GetString("Salir", ci);
        }
    }
}
