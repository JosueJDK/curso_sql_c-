using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_DB2 conexionDB = new Conexion_DB2();
                conexionDB.open();
                DataTable dt = new DataTable();
                String dat1 = "'" + date1.Value.ToString("yyyy/MM/dd") + "'";
                String dat2 = "'" + date2.Value.ToString("dd/MM/yyyy") + "'";
                SqlDataAdapter adp = new SqlDataAdapter("Exec fecha_buscar " + 
                                    dat1 + ", " + dat2, conexionDB.Conex);
                adp.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
