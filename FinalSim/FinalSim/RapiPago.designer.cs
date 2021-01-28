namespace FinalSim
{
    partial class RapiPago
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_caja = new System.Windows.Forms.Label();
            this.lbl_gas = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_Cola = new System.Windows.Forms.TextBox();
            this.lbl_cola = new System.Windows.Forms.Label();
            this.txt_promTelef = new System.Windows.Forms.TextBox();
            this.lbl_promTele = new System.Windows.Forms.Label();
            this.txt_promGas = new System.Windows.Forms.TextBox();
            this.lbl_promGas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_simulacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_simulacion.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_simulacion.Location = new System.Drawing.Point(12, 135);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_simulacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_simulacion.Size = new System.Drawing.Size(1312, 552);
            this.dgv_simulacion.TabIndex = 40;
            // 
            // btn_generar
            // 
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Location = new System.Drawing.Point(36, 65);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(149, 29);
            this.btn_generar.TabIndex = 39;
            this.btn_generar.Text = "Generar simulación";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_clientes
            // 
            this.txt_clientes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_clientes.Location = new System.Drawing.Point(106, 23);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(79, 25);
            this.txt_clientes.TabIndex = 38;
            this.txt_clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_clientes.TextChanged += new System.EventHandler(this.txt_clientes_TextChanged);
            this.txt_clientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clientes_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(33, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lbl_caja
            // 
            this.lbl_caja.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_caja.Location = new System.Drawing.Point(651, 90);
            this.lbl_caja.Name = "lbl_caja";
            this.lbl_caja.Size = new System.Drawing.Size(187, 39);
            this.lbl_caja.TabIndex = 43;
            this.lbl_caja.Text = "Caja";
            this.lbl_caja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_caja.Visible = false;
            // 
            // lbl_gas
            // 
            this.lbl_gas.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_gas.Location = new System.Drawing.Point(651, 64);
            this.lbl_gas.Name = "lbl_gas";
            this.lbl_gas.Size = new System.Drawing.Size(187, 35);
            this.lbl_gas.TabIndex = 42;
            this.lbl_gas.Text = "Gas";
            this.lbl_gas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_gas.Visible = false;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_telefono.Location = new System.Drawing.Point(651, 34);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(187, 30);
            this.lbl_telefono.TabIndex = 41;
            this.lbl_telefono.Text = "Telefono";
            this.lbl_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_telefono.Visible = false;
            // 
            // txt_Cola
            // 
            this.txt_Cola.Enabled = false;
            this.txt_Cola.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Cola.Location = new System.Drawing.Point(987, 33);
            this.txt_Cola.Name = "txt_Cola";
            this.txt_Cola.Size = new System.Drawing.Size(64, 25);
            this.txt_Cola.TabIndex = 45;
            this.txt_Cola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cola.Visible = false;
            // 
            // lbl_cola
            // 
            this.lbl_cola.AutoSize = true;
            this.lbl_cola.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_cola.Location = new System.Drawing.Point(898, 36);
            this.lbl_cola.Name = "lbl_cola";
            this.lbl_cola.Size = new System.Drawing.Size(83, 17);
            this.lbl_cola.TabIndex = 44;
            this.lbl_cola.Text = "Cola maxima";
            this.lbl_cola.Visible = false;
            // 
            // txt_promTelef
            // 
            this.txt_promTelef.Enabled = false;
            this.txt_promTelef.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_promTelef.Location = new System.Drawing.Point(987, 68);
            this.txt_promTelef.Name = "txt_promTelef";
            this.txt_promTelef.Size = new System.Drawing.Size(64, 25);
            this.txt_promTelef.TabIndex = 47;
            this.txt_promTelef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_promTelef.Visible = false;
            // 
            // lbl_promTele
            // 
            this.lbl_promTele.AutoSize = true;
            this.lbl_promTele.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_promTele.Location = new System.Drawing.Point(895, 72);
            this.lbl_promTele.Name = "lbl_promTele";
            this.lbl_promTele.Size = new System.Drawing.Size(85, 17);
            this.lbl_promTele.TabIndex = 46;
            this.lbl_promTele.Text = "Promedio Tel";
            this.lbl_promTele.Visible = false;
            this.lbl_promTele.Click += new System.EventHandler(this.Lbl_promTele_Click);
            // 
            // txt_promGas
            // 
            this.txt_promGas.Enabled = false;
            this.txt_promGas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_promGas.Location = new System.Drawing.Point(987, 103);
            this.txt_promGas.Name = "txt_promGas";
            this.txt_promGas.Size = new System.Drawing.Size(64, 25);
            this.txt_promGas.TabIndex = 49;
            this.txt_promGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_promGas.Visible = false;
            // 
            // lbl_promGas
            // 
            this.lbl_promGas.AutoSize = true;
            this.lbl_promGas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_promGas.Location = new System.Drawing.Point(890, 106);
            this.lbl_promGas.Name = "lbl_promGas";
            this.lbl_promGas.Size = new System.Drawing.Size(91, 17);
            this.lbl_promGas.TabIndex = 48;
            this.lbl_promGas.Text = "Promedio Gas";
            this.lbl_promGas.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_desde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 106);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango a mostrar";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_hasta.Location = new System.Drawing.Point(224, 35);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(79, 25);
            this.txt_hasta.TabIndex = 3;
            this.txt_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(177, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_desde.Location = new System.Drawing.Point(80, 35);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(79, 25);
            this.txt_desde.TabIndex = 1;
            this.txt_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_desde.TextChanged += new System.EventHandler(this.txt_desde_TextChanged);
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_generar);
            this.groupBox2.Controls.Add(this.txt_clientes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 106);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // RapiPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_promGas);
            this.Controls.Add(this.lbl_promGas);
            this.Controls.Add(this.txt_promTelef);
            this.Controls.Add(this.lbl_promTele);
            this.Controls.Add(this.txt_Cola);
            this.Controls.Add(this.lbl_cola);
            this.Controls.Add(this.lbl_caja);
            this.Controls.Add(this.lbl_gas);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.dgv_simulacion);
            this.Name = "RapiPago";
            this.Text = "RapiPago";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_caja;
        private System.Windows.Forms.Label lbl_gas;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_Cola;
        private System.Windows.Forms.Label lbl_cola;
        private System.Windows.Forms.TextBox txt_promTelef;
        private System.Windows.Forms.Label lbl_promTele;
        private System.Windows.Forms.TextBox txt_promGas;
        private System.Windows.Forms.Label lbl_promGas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

