
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
   
    public partial class Frm_MantDepartamento : Form
    {
        Logica logic = new Logica();
        public Frm_MantDepartamento()
        {
            InitializeComponent();
            bloquear();
        }

        public void bloquear()
        {
            Txt_codigodepartamento.Enabled = false;
            Txt_nombredepartamento.Enabled = false;
            Cbo_estado.Enabled = false;
        }

        public void desbloquear()
        {
            Txt_codigodepartamento.Enabled = true;
            Txt_nombredepartamento.Enabled = true;
            Cbo_estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_codigodepartamento.Clear();
            Txt_nombredepartamento.Clear();
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
            OdbcDataReader departamento = logic.modificardepto(Txt_codigodepartamento.Text, Txt_nombredepartamento.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
            OdbcDataReader departamento = logic.guardardepto(Txt_codigodepartamento.Text, Txt_nombredepartamento.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader departamento = logic.eliminardepto(Txt_codigodepartamento.Text );
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaDepartamento concep = new Frm_consultaDepartamento();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigodepartamento.Text = concep.Dgv_consultaDepartamento.Rows[concep.Dgv_consultaDepartamento.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombredepartamento.Text = concep.Dgv_consultaDepartamento.Rows[concep.Dgv_consultaDepartamento.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaDepartamento.Rows[concep.Dgv_consultaDepartamento.CurrentRow.Index].
                     Cells[2].Value.ToString();
            }
        }
    }
}

   
