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

namespace Practica1_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_DB conexionDB = new Conexion_DB();
                conexionDB.open();
                DataTable dt = new DataTable();
                String dat1 = "'" + date1.Value.ToString("yyyy/MM/dd") + "'";
                String dat2 = "'" + date2.Value.ToString("yyyy/MM/dd") + "'";
                SqlDataAdapter adp = new SqlDataAdapter("Execute matricula_buscar " + dat1 + ", " + dat2, conexionDB.Conex);
                adp.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
        }
    }
}
