namespace MAD._0
{
    partial class PrincipalAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Lista_PA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_PA = new System.Windows.Forms.Timer(this.components);
            this.btn_cajas_PA = new System.Windows.Forms.Button();
            this.btn_inventario_PA = new System.Windows.Forms.Button();
            this.btn_recibos_PA = new System.Windows.Forms.Button();
            this.btn_descuentoss_PA = new System.Windows.Forms.Button();
            this.btn_devoluciones_PA = new System.Windows.Forms.Button();
            this.btn_cerrarS_PA = new System.Windows.Forms.Button();
            this.btn_productos_PA = new System.Windows.Forms.Button();
            this.btn_departamento = new System.Windows.Forms.Button();
            this.btn_reportecajero = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_reporteventas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_PA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista_PA
            // 
            this.dgv_Lista_PA.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Lista_PA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista_PA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_PA.Location = new System.Drawing.Point(239, 223);
            this.dgv_Lista_PA.Name = "dgv_Lista_PA";
            this.dgv_Lista_PA.RowHeadersWidth = 51;
            this.dgv_Lista_PA.RowTemplate.Height = 24;
            this.dgv_Lista_PA.Size = new System.Drawing.Size(668, 346);
            this.dgv_Lista_PA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos que ya llegaron a su punto de reorden:";
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(759, 48);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 13;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(923, 6);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 12;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(200, 26);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(137, 19);
            this.lbl_nombrec_PA.TabIndex = 11;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(52, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Administrador:";
            // 
            // timer_PA
            // 
            this.timer_PA.Enabled = true;
            this.timer_PA.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cajas_PA
            // 
            this.btn_cajas_PA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_cajas_PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cajas_PA.Location = new System.Drawing.Point(55, 91);
            this.btn_cajas_PA.Name = "btn_cajas_PA";
            this.btn_cajas_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_cajas_PA.TabIndex = 14;
            this.btn_cajas_PA.Text = "Cajas";
            this.btn_cajas_PA.UseVisualStyleBackColor = false;
            this.btn_cajas_PA.Click += new System.EventHandler(this.btn_cajeros_PA_Click);
            // 
            // btn_inventario_PA
            // 
            this.btn_inventario_PA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_inventario_PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inventario_PA.Location = new System.Drawing.Point(55, 255);
            this.btn_inventario_PA.Name = "btn_inventario_PA";
            this.btn_inventario_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_inventario_PA.TabIndex = 15;
            this.btn_inventario_PA.Text = "Inventario";
            this.btn_inventario_PA.UseVisualStyleBackColor = false;
            this.btn_inventario_PA.Click += new System.EventHandler(this.btn_inventario_PA_Click);
            // 
            // btn_recibos_PA
            // 
            this.btn_recibos_PA.BackColor = System.Drawing.Color.Crimson;
            this.btn_recibos_PA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_recibos_PA.Location = new System.Drawing.Point(930, 154);
            this.btn_recibos_PA.Name = "btn_recibos_PA";
            this.btn_recibos_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_recibos_PA.TabIndex = 16;
            this.btn_recibos_PA.Text = "Consulta de recibos";
            this.btn_recibos_PA.UseVisualStyleBackColor = false;
            this.btn_recibos_PA.Click += new System.EventHandler(this.btn_reportes_PA_Click);
            // 
            // btn_descuentoss_PA
            // 
            this.btn_descuentoss_PA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_descuentoss_PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_descuentoss_PA.Location = new System.Drawing.Point(55, 337);
            this.btn_descuentoss_PA.Name = "btn_descuentoss_PA";
            this.btn_descuentoss_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_descuentoss_PA.TabIndex = 17;
            this.btn_descuentoss_PA.Text = "Descuentos";
            this.btn_descuentoss_PA.UseVisualStyleBackColor = false;
            this.btn_descuentoss_PA.Click += new System.EventHandler(this.btn_devoluciones_PA_Click);
            // 
            // btn_devoluciones_PA
            // 
            this.btn_devoluciones_PA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_devoluciones_PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_devoluciones_PA.Location = new System.Drawing.Point(55, 422);
            this.btn_devoluciones_PA.Name = "btn_devoluciones_PA";
            this.btn_devoluciones_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_devoluciones_PA.TabIndex = 18;
            this.btn_devoluciones_PA.Text = "Devoluciones";
            this.btn_devoluciones_PA.UseVisualStyleBackColor = false;
            this.btn_devoluciones_PA.Click += new System.EventHandler(this.btn_ventas_PA_Click);
            // 
            // btn_cerrarS_PA
            // 
            this.btn_cerrarS_PA.BackColor = System.Drawing.Color.Maroon;
            this.btn_cerrarS_PA.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cerrarS_PA.Location = new System.Drawing.Point(930, 622);
            this.btn_cerrarS_PA.Name = "btn_cerrarS_PA";
            this.btn_cerrarS_PA.Size = new System.Drawing.Size(147, 56);
            this.btn_cerrarS_PA.TabIndex = 21;
            this.btn_cerrarS_PA.Text = "Cerrar Sesión";
            this.btn_cerrarS_PA.UseVisualStyleBackColor = false;
            this.btn_cerrarS_PA.Click += new System.EventHandler(this.btn_cerrarS_PA_Click);
            // 
            // btn_productos_PA
            // 
            this.btn_productos_PA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_productos_PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_productos_PA.Location = new System.Drawing.Point(55, 173);
            this.btn_productos_PA.Name = "btn_productos_PA";
            this.btn_productos_PA.Size = new System.Drawing.Size(147, 76);
            this.btn_productos_PA.TabIndex = 22;
            this.btn_productos_PA.Text = "Productos";
            this.btn_productos_PA.UseVisualStyleBackColor = false;
            this.btn_productos_PA.Click += new System.EventHandler(this.btn_productos_PA_Click);
            // 
            // btn_departamento
            // 
            this.btn_departamento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_departamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_departamento.Location = new System.Drawing.Point(55, 507);
            this.btn_departamento.Name = "btn_departamento";
            this.btn_departamento.Size = new System.Drawing.Size(147, 76);
            this.btn_departamento.TabIndex = 23;
            this.btn_departamento.Text = "Departamento";
            this.btn_departamento.UseVisualStyleBackColor = false;
            this.btn_departamento.Click += new System.EventHandler(this.btn_departamento_Click);
            // 
            // btn_reportecajero
            // 
            this.btn_reportecajero.BackColor = System.Drawing.Color.Crimson;
            this.btn_reportecajero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reportecajero.Location = new System.Drawing.Point(930, 246);
            this.btn_reportecajero.Name = "btn_reportecajero";
            this.btn_reportecajero.Size = new System.Drawing.Size(147, 76);
            this.btn_reportecajero.TabIndex = 24;
            this.btn_reportecajero.Text = "Reporte de Cajeros";
            this.btn_reportecajero.UseVisualStyleBackColor = false;
            this.btn_reportecajero.Click += new System.EventHandler(this.btn_reportecajero_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_empleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_empleados.Location = new System.Drawing.Point(55, 602);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(147, 76);
            this.btn_empleados.TabIndex = 25;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_reporteventas
            // 
            this.btn_reporteventas.BackColor = System.Drawing.Color.Crimson;
            this.btn_reporteventas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reporteventas.Location = new System.Drawing.Point(930, 353);
            this.btn_reporteventas.Name = "btn_reporteventas";
            this.btn_reporteventas.Size = new System.Drawing.Size(147, 76);
            this.btn_reporteventas.TabIndex = 26;
            this.btn_reporteventas.Text = "Reporte de   Ventas";
            this.btn_reporteventas.UseVisualStyleBackColor = false;
            this.btn_reporteventas.Click += new System.EventHandler(this.btn_reporteventas_Click);
            // 
            // PrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 718);
            this.Controls.Add(this.btn_reporteventas);
            this.Controls.Add(this.btn_empleados);
            this.Controls.Add(this.btn_reportecajero);
            this.Controls.Add(this.btn_departamento);
            this.Controls.Add(this.btn_productos_PA);
            this.Controls.Add(this.btn_cerrarS_PA);
            this.Controls.Add(this.btn_devoluciones_PA);
            this.Controls.Add(this.btn_descuentoss_PA);
            this.Controls.Add(this.btn_recibos_PA);
            this.Controls.Add(this.btn_inventario_PA);
            this.Controls.Add(this.btn_cajas_PA);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Lista_PA);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalAdministrador";
            this.Load += new System.EventHandler(this.PrincipalAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_PA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lista_PA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_PA;
        private System.Windows.Forms.Button btn_inventario_PA;
        private System.Windows.Forms.Button btn_recibos_PA;
        private System.Windows.Forms.Button btn_descuentoss_PA;
        private System.Windows.Forms.Button btn_devoluciones_PA;
        private System.Windows.Forms.Button btn_cajas_PA;
        private System.Windows.Forms.Button btn_cerrarS_PA;
        private System.Windows.Forms.Button btn_productos_PA;
        private System.Windows.Forms.Button btn_departamento;
        private System.Windows.Forms.Button btn_reportecajero;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_reporteventas;
    }
}