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
    public partial class Frm_MantConcepto : Form
    {
        Logica logic = new Logica();

        public Frm_MantConcepto()
        {
            InitializeComponent();
            bloquear();
        }

        public void bloquear()
        {
            Txt_codigo.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_puesto.Enabled = false;
            Cbo_estado.Enabled = false;

        }

        public void desbloquear()
        {
            Txt_codigo.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_puesto.Enabled = true;
            Cbo_estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_codigo.Clear();
            Txt_puesto.Clear();
            Txt_nombre.Clear();
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
            OdbcDataReader concepto = logic.modificarconcepto(Txt_codigo.Text, Txt_nombre.Text,  Txt_puesto.Text,  Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            OdbcDataReader concepto = logic.guardarconcepto(Txt_codigo.Text, Txt_nombre.Text, Txt_puesto.Text, Cbo_estado.Text);
            MessageBox.Show("Datos guardados correctamente.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {

            OdbcDataReader concepto = logic.eliminarconcepto(Txt_codigo.Text);
            MessageBox.Show("Datos eliminados correctamente.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConcepto concep = new Frm_consultaConcepto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigo.Text = concep.Dgv_consultaConcepto.Rows[concep.Dgv_consultaConcepto.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaConcepto.Rows[concep.Dgv_consultaConcepto.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_puesto.Text = concep.Dgv_consultaConcepto.Rows[concep.Dgv_consultaConcepto.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaConcepto.Rows[concep.Dgv_consultaConcepto.CurrentRow.Index].
                     Cells[3].Value.ToString();
            }
        }
    }
}
