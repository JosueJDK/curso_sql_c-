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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Conexion_DB conexionDB = new Conexion_DB();
                conexionDB.open();

                DataTable dt = new DataTable();

                SqlDataAdapter adp = new SqlDataAdapter("Execute curso_buscar " + txtInput.Text.Trim(), conexionDB.Conex);
                adp.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.txtInput.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
        }
    }
}
