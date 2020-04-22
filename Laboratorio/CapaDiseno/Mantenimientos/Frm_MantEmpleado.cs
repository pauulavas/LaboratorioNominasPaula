using CapaDiseno.Consulta;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno.Mantenimientos
{
    public partial class Frm_MantEmpleado : Form
    {
        Logica logic = new Logica();
        public Frm_MantEmpleado()
        {
            InitializeComponent();
            bloquear();
        }

        public void bloquear()
        {
            Txt_codigo.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_suedo.Enabled = false;
            Txt_puesto.Enabled = false;
            Txt_departamento.Enabled = false;
            Cbo_estado.Enabled = false;

        }

        public void desbloquear()
        {
            Txt_codigo.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_suedo.Enabled = true;
            Txt_puesto.Enabled = true;
            Txt_departamento.Enabled = true;
            Cbo_estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_codigo.Clear();
            Txt_puesto.Clear();
            Txt_nombre.Clear();
            Txt_suedo.Clear();
            Txt_departamento.Clear();
            Cbo_estado.ResetText();

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader empleado = logic.modificarempleado(Txt_codigo.Text, Txt_nombre.Text, Txt_suedo.Text, Txt_puesto.Text, float.Parse(Txt_departamento.Text), Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader empleado = logic.guardarempleado(Txt_codigo.Text, Txt_nombre.Text, Txt_suedo.Text, Txt_puesto.Text, float.Parse(Txt_departamento.Text), Cbo_estado.Text);
            MessageBox.Show("Datos guardados correctamente.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader empleado = logic.borrarempleado(Txt_codigo.Text);
            MessageBox.Show("Datos eliminados correctamente.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigo.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_suedo.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_puesto.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_departamento.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                     Cells[5].Value.ToString();
            }
        }

        private void Btn_consultaRuta_Click(object sender, EventArgs e)
        {
            Frm_consultaPuesto concep = new Frm_consultaPuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_puesto.Text = concep.Dgv_consultaPuesto.Rows[concep.Dgv_consultaPuesto.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_puesto.Enabled = false;
        }

        private void Btn_BuscarTipoTransporte_Click(object sender, EventArgs e)
        {
            Frm_consultaDepartamento concep = new Frm_consultaDepartamento();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_departamento.Text = concep.Dgv_consultaDepartamento.Rows[concep.Dgv_consultaDepartamento.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_departamento.Enabled = false;
        }
    }
}
