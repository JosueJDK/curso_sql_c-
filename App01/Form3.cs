using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            try
            {
                Conexion_DB2 conexionDB = new Conexion_DB2();
                conexionDB.open();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select DISTINCT Country from Customers;", 
                                                        conexionDB.Conex);
                adp.Fill(dt);
                cBoxCity.DataSource = dt;
                cBoxCity.ValueMember = "Country";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_DB2 conexionDB = new Conexion_DB2();
                conexionDB.open();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("Exec buscar_city " + 
                    cBoxCity.SelectedValue , conexionDB.Conex);
                adp.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
