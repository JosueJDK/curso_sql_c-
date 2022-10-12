using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_DB conexionDB = new Conexion_DB();
                conexionDB.open();

                String Nomb_Medicam = txtbox_nom_medica.Text;
	            String proveedor = txtbox_proveedor.Text;
	            String stock = txtbox_stock.Text;
                String precUnit = txtbox_precio_unit.Text;
	            String presentacion = txtbox_presentacion.Text;
	            String fecha_vence = date_fecha_venci.Text;

                SqlCommand cmd = new SqlCommand("usp_MedicamentoCreate", conexionDB.Conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nomb_Medicam", Nomb_Medicam);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@precUnit", precUnit);
                cmd.Parameters.AddWithValue("@presentacion", presentacion);
                cmd.Parameters.AddWithValue("@fecha_vence", fecha_vence);

                try
                {
                    cmd.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtbox_nom_medica.Clear();
            this.txtbox_proveedor.Clear();
            this.txtbox_stock.Clear();
            this.txtbox_precio_unit.Clear();
            this.txtbox_presentacion.Clear();
        }

        private void txtbox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_precio_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
