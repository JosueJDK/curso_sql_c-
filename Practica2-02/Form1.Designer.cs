namespace Practica2_02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_nom_medica = new System.Windows.Forms.TextBox();
            this.txtbox_proveedor = new System.Windows.Forms.TextBox();
            this.txtbox_stock = new System.Windows.Forms.TextBox();
            this.txtbox_precio_unit = new System.Windows.Forms.TextBox();
            this.txtbox_presentacion = new System.Windows.Forms.TextBox();
            this.date_fecha_venci = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar Medicamentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Presentacion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Vencimiento:";
            // 
            // txtbox_nom_medica
            // 
            this.txtbox_nom_medica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom_medica.Location = new System.Drawing.Point(238, 85);
            this.txtbox_nom_medica.Name = "txtbox_nom_medica";
            this.txtbox_nom_medica.Size = new System.Drawing.Size(164, 29);
            this.txtbox_nom_medica.TabIndex = 7;
            // 
            // txtbox_proveedor
            // 
            this.txtbox_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_proveedor.Location = new System.Drawing.Point(238, 125);
            this.txtbox_proveedor.Name = "txtbox_proveedor";
            this.txtbox_proveedor.Size = new System.Drawing.Size(164, 29);
            this.txtbox_proveedor.TabIndex = 8;
            // 
            // txtbox_stock
            // 
            this.txtbox_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_stock.Location = new System.Drawing.Point(238, 170);
            this.txtbox_stock.Name = "txtbox_stock";
            this.txtbox_stock.Size = new System.Drawing.Size(164, 29);
            this.txtbox_stock.TabIndex = 9;
            this.txtbox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_stock_KeyPress);
            // 
            // txtbox_precio_unit
            // 
            this.txtbox_precio_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_precio_unit.Location = new System.Drawing.Point(238, 217);
            this.txtbox_precio_unit.Name = "txtbox_precio_unit";
            this.txtbox_precio_unit.Size = new System.Drawing.Size(164, 29);
            this.txtbox_precio_unit.TabIndex = 10;
            this.txtbox_precio_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_precio_unit_KeyPress);
            // 
            // txtbox_presentacion
            // 
            this.txtbox_presentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_presentacion.Location = new System.Drawing.Point(238, 264);
            this.txtbox_presentacion.Name = "txtbox_presentacion";
            this.txtbox_presentacion.Size = new System.Drawing.Size(164, 29);
            this.txtbox_presentacion.TabIndex = 11;
            // 
            // date_fecha_venci
            // 
            this.date_fecha_venci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha_venci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fecha_venci.Location = new System.Drawing.Point(238, 319);
            this.date_fecha_venci.Name = "date_fecha_venci";
            this.date_fecha_venci.Size = new System.Drawing.Size(164, 26);
            this.date_fecha_venci.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_fecha_venci);
            this.Controls.Add(this.txtbox_presentacion);
            this.Controls.Add(this.txtbox_precio_unit);
            this.Controls.Add(this.txtbox_stock);
            this.Controls.Add(this.txtbox_proveedor);
            this.Controls.Add(this.txtbox_nom_medica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_nom_medica;
        private System.Windows.Forms.TextBox txtbox_proveedor;
        private System.Windows.Forms.TextBox txtbox_stock;
        private System.Windows.Forms.TextBox txtbox_precio_unit;
        private System.Windows.Forms.TextBox txtbox_presentacion;
        private System.Windows.Forms.DateTimePicker date_fecha_venci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

