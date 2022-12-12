namespace MAD._0
{
    partial class GestionDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDevoluciones));
            this.btn_regresar_GR = new System.Windows.Forms.Button();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idticket = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_DEVOLUCIONES = new System.Windows.Forms.DataGridView();
            this.btn_AgregarP = new System.Windows.Forms.Button();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.chb_merma = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.btn_crearNota = new System.Windows.Forms.Button();
            this.idnotacredito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_producto = new System.Windows.Forms.Label();
            this.id_depa = new System.Windows.Forms.Label();
            this.IDTICKET = new System.Windows.Forms.Label();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.CANTIDAD = new System.Windows.Forms.Label();
            this.SUBTOTAL = new System.Windows.Forms.Label();
            this.IDVENTA = new System.Windows.Forms.Label();
            this.idcaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DEVOLUCIONES)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar_GR
            // 
            this.btn_regresar_GR.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GR.Location = new System.Drawing.Point(12, 552);
            this.btn_regresar_GR.Name = "btn_regresar_GR";
            this.btn_regresar_GR.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GR.TabIndex = 24;
            this.btn_regresar_GR.Text = "Regresar";
            this.btn_regresar_GR.UseVisualStyleBackColor = false;
            this.btn_regresar_GR.Click += new System.EventHandler(this.btn_regresar_GP_Click);
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(668, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 23;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(832, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 22;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(185, 40);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(137, 19);
            this.lbl_nombrec_PA.TabIndex = 21;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(37, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código de Ticket:";
            // 
            // txt_idticket
            // 
            this.txt_idticket.Location = new System.Drawing.Point(176, 119);
            this.txt_idticket.Name = "txt_idticket";
            this.txt_idticket.Size = new System.Drawing.Size(121, 24);
            this.txt_idticket.TabIndex = 26;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(320, 112);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 39);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_DEVOLUCIONES
            // 
            this.dgv_DEVOLUCIONES.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_DEVOLUCIONES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DEVOLUCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DEVOLUCIONES.Location = new System.Drawing.Point(40, 168);
            this.dgv_DEVOLUCIONES.Name = "dgv_DEVOLUCIONES";
            this.dgv_DEVOLUCIONES.RowHeadersWidth = 51;
            this.dgv_DEVOLUCIONES.Size = new System.Drawing.Size(535, 339);
            this.dgv_DEVOLUCIONES.TabIndex = 28;
            this.dgv_DEVOLUCIONES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DEVOLUCIONES_CellClick);
            // 
            // btn_AgregarP
            // 
            this.btn_AgregarP.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_AgregarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AgregarP.Location = new System.Drawing.Point(711, 112);
            this.btn_AgregarP.Name = "btn_AgregarP";
            this.btn_AgregarP.Size = new System.Drawing.Size(211, 51);
            this.btn_AgregarP.TabIndex = 29;
            this.btn_AgregarP.Text = "Agregar producto a nota de credito";
            this.btn_AgregarP.UseVisualStyleBackColor = false;
            this.btn_AgregarP.Click += new System.EventHandler(this.btn_AgregarP_Click);
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(808, 307);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(176, 94);
            this.txt_motivo.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(738, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(726, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Producto:";
            // 
            // txt_producto
            // 
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(808, 179);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(176, 24);
            this.txt_producto.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(684, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Monto Pagado:";
            // 
            // txt_monto
            // 
            this.txt_monto.Enabled = false;
            this.txt_monto.Location = new System.Drawing.Point(808, 253);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(176, 24);
            this.txt_monto.TabIndex = 35;
            // 
            // chb_merma
            // 
            this.chb_merma.AutoSize = true;
            this.chb_merma.ForeColor = System.Drawing.Color.Indigo;
            this.chb_merma.Location = new System.Drawing.Point(858, 404);
            this.chb_merma.Name = "chb_merma";
            this.chb_merma.Size = new System.Drawing.Size(77, 23);
            this.chb_merma.TabIndex = 36;
            this.chb_merma.Text = "Merma";
            this.chb_merma.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(690, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Departamento:";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Enabled = false;
            this.txt_departamento.Location = new System.Drawing.Point(808, 215);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.ReadOnly = true;
            this.txt_departamento.Size = new System.Drawing.Size(176, 24);
            this.txt_departamento.TabIndex = 38;
            // 
            // btn_crearNota
            // 
            this.btn_crearNota.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_crearNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_crearNota.Location = new System.Drawing.Point(820, 516);
            this.btn_crearNota.Name = "btn_crearNota";
            this.btn_crearNota.Size = new System.Drawing.Size(164, 75);
            this.btn_crearNota.TabIndex = 39;
            this.btn_crearNota.Text = "Crear Nota de Crédito";
            this.btn_crearNota.UseVisualStyleBackColor = false;
            this.btn_crearNota.Click += new System.EventHandler(this.btn_crearNota_Click);
            // 
            // idnotacredito
            // 
            this.idnotacredito.Enabled = false;
            this.idnotacredito.Location = new System.Drawing.Point(808, 478);
            this.idnotacredito.Name = "idnotacredito";
            this.idnotacredito.ReadOnly = true;
            this.idnotacredito.Size = new System.Drawing.Size(176, 24);
            this.idnotacredito.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(794, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Código de Nota de crédito";
            // 
            // ID_producto
            // 
            this.ID_producto.AutoSize = true;
            this.ID_producto.ForeColor = System.Drawing.Color.Indigo;
            this.ID_producto.Location = new System.Drawing.Point(626, 184);
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.Size = new System.Drawing.Size(94, 19);
            this.ID_producto.TabIndex = 42;
            this.ID_producto.Text = "ID_producto";
            this.ID_producto.Visible = false;
            // 
            // id_depa
            // 
            this.id_depa.AutoSize = true;
            this.id_depa.ForeColor = System.Drawing.Color.Indigo;
            this.id_depa.Location = new System.Drawing.Point(595, 218);
            this.id_depa.Name = "id_depa";
            this.id_depa.Size = new System.Drawing.Size(65, 19);
            this.id_depa.TabIndex = 43;
            this.id_depa.Text = "d_depa";
            this.id_depa.Visible = false;
            // 
            // IDTICKET
            // 
            this.IDTICKET.AutoSize = true;
            this.IDTICKET.ForeColor = System.Drawing.Color.Indigo;
            this.IDTICKET.Location = new System.Drawing.Point(595, 253);
            this.IDTICKET.Name = "IDTICKET";
            this.IDTICKET.Size = new System.Drawing.Size(60, 19);
            this.IDTICKET.TabIndex = 44;
            this.IDTICKET.Text = "idticket";
            this.IDTICKET.Visible = false;
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(598, 557);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 24);
            this.tp_fechaIngreso.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(595, 537);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 93;
            this.label9.Text = "Fecha de Ingreso:";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSize = true;
            this.CANTIDAD.ForeColor = System.Drawing.Color.Indigo;
            this.CANTIDAD.Location = new System.Drawing.Point(598, 382);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(138, 19);
            this.CANTIDAD.TabIndex = 95;
            this.CANTIDAD.Text = "cantidadDevuelta";
            this.CANTIDAD.Visible = false;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSize = true;
            this.SUBTOTAL.ForeColor = System.Drawing.Color.Indigo;
            this.SUBTOTAL.Location = new System.Drawing.Point(598, 408);
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Size = new System.Drawing.Size(65, 19);
            this.SUBTOTAL.TabIndex = 96;
            this.SUBTOTAL.Text = "subtotal";
            this.SUBTOTAL.Visible = false;
            // 
            // IDVENTA
            // 
            this.IDVENTA.AutoSize = true;
            this.IDVENTA.ForeColor = System.Drawing.Color.Indigo;
            this.IDVENTA.Location = new System.Drawing.Point(614, 144);
            this.IDVENTA.Name = "IDVENTA";
            this.IDVENTA.Size = new System.Drawing.Size(63, 19);
            this.IDVENTA.TabIndex = 97;
            this.IDVENTA.Text = "IDVENTA";
            this.IDVENTA.Visible = false;
            // 
            // idcaja
            // 
            this.idcaja.AutoSize = true;
            this.idcaja.ForeColor = System.Drawing.Color.Indigo;
            this.idcaja.Location = new System.Drawing.Point(598, 442);
            this.idcaja.Name = "idcaja";
            this.idcaja.Size = new System.Drawing.Size(54, 19);
            this.idcaja.TabIndex = 98;
            this.idcaja.Text = "idcaja";
            this.idcaja.Visible = false;
            // 
            // GestionDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1020, 612);
            this.Controls.Add(this.idcaja);
            this.Controls.Add(this.IDVENTA);
            this.Controls.Add(this.SUBTOTAL);
            this.Controls.Add(this.CANTIDAD);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IDTICKET);
            this.Controls.Add(this.id_depa);
            this.Controls.Add(this.ID_producto);
            this.Controls.Add(this.idnotacredito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_crearNota);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chb_merma);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.btn_AgregarP);
            this.Controls.Add(this.dgv_DEVOLUCIONES);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_idticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar_GR);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "GestionDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDevoluciones";
            this.Load += new System.EventHandler(this.GestionDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DEVOLUCIONES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_GR;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idticket;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_DEVOLUCIONES;
        private System.Windows.Forms.Button btn_AgregarP;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.CheckBox chb_merma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Button btn_crearNota;
        private System.Windows.Forms.TextBox idnotacredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ID_producto;
        private System.Windows.Forms.Label id_depa;
        private System.Windows.Forms.Label IDTICKET;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CANTIDAD;
        private System.Windows.Forms.Label SUBTOTAL;
        private System.Windows.Forms.Label IDVENTA;
        private System.Windows.Forms.Label idcaja;
    }
}