namespace MAD._0
{
    partial class GestionProductos
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
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_regresar_GP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_NProducto = new System.Windows.Forms.Button();
            this.btn_MProducto = new System.Windows.Forms.Button();
            this.btn_EProducto = new System.Windows.Forms.Button();
            this.lbl_idprod = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_cantidadInv = new System.Windows.Forms.TextBox();
            this.lbl_cantInv = new System.Windows.Forms.Label();
            this.lbl_reorden = new System.Windows.Forms.Label();
            this.txt_reorden = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_precioUni = new System.Windows.Forms.Label();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lb_productoEliminado = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_idadmin = new System.Windows.Forms.Label();
            this.txt_nameadmin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_si = new System.Windows.Forms.CheckBox();
            this.cb_no = new System.Windows.Forms.CheckBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(729, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 21;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(893, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 20;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(168, 31);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(137, 19);
            this.lbl_nombrec_PA.TabIndex = 19;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Administrador:";
            // 
            // btn_regresar_GP
            // 
            this.btn_regresar_GP.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GP.Location = new System.Drawing.Point(31, 532);
            this.btn_regresar_GP.Name = "btn_regresar_GP";
            this.btn_regresar_GP.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GP.TabIndex = 22;
            this.btn_regresar_GP.Text = "Regresar";
            this.btn_regresar_GP.UseVisualStyleBackColor = false;
            this.btn_regresar_GP.Click += new System.EventHandler(this.btn_regresar_GP_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_NProducto
            // 
            this.btn_NProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NProducto.Location = new System.Drawing.Point(900, 122);
            this.btn_NProducto.Name = "btn_NProducto";
            this.btn_NProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_NProducto.TabIndex = 23;
            this.btn_NProducto.Text = "Nuevo Producto";
            this.btn_NProducto.UseVisualStyleBackColor = false;
            this.btn_NProducto.Click += new System.EventHandler(this.btn_NProducto_Click);
            // 
            // btn_MProducto
            // 
            this.btn_MProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MProducto.Location = new System.Drawing.Point(932, 532);
            this.btn_MProducto.Name = "btn_MProducto";
            this.btn_MProducto.Size = new System.Drawing.Size(147, 39);
            this.btn_MProducto.TabIndex = 24;
            this.btn_MProducto.Text = "Modificar ";
            this.btn_MProducto.UseVisualStyleBackColor = false;
            this.btn_MProducto.Click += new System.EventHandler(this.btn_MProducto_Click);
            // 
            // btn_EProducto
            // 
            this.btn_EProducto.BackColor = System.Drawing.Color.Crimson;
            this.btn_EProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EProducto.Location = new System.Drawing.Point(761, 532);
            this.btn_EProducto.Name = "btn_EProducto";
            this.btn_EProducto.Size = new System.Drawing.Size(147, 39);
            this.btn_EProducto.TabIndex = 25;
            this.btn_EProducto.Text = "Eliminar ";
            this.btn_EProducto.UseVisualStyleBackColor = false;
            this.btn_EProducto.Click += new System.EventHandler(this.btn_EProducto_Click);
            // 
            // lbl_idprod
            // 
            this.lbl_idprod.AutoSize = true;
            this.lbl_idprod.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idprod.Location = new System.Drawing.Point(389, 166);
            this.lbl_idprod.Name = "lbl_idprod";
            this.lbl_idprod.Size = new System.Drawing.Size(93, 19);
            this.lbl_idprod.TabIndex = 27;
            this.lbl_idprod.Text = " ID Producto";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_departamento.Location = new System.Drawing.Point(595, 219);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(112, 19);
            this.lbl_departamento.TabIndex = 29;
            this.lbl_departamento.Text = "Departamento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(394, 244);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(187, 24);
            this.txt_nombre.TabIndex = 28;
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(599, 241);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(187, 27);
            this.cb_departamento.TabIndex = 30;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombre.Location = new System.Drawing.Point(390, 222);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 19);
            this.lbl_nombre.TabIndex = 31;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_descripcion.Location = new System.Drawing.Point(652, 406);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(89, 19);
            this.lbl_descripcion.TabIndex = 33;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(604, 428);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(187, 58);
            this.txt_descripcion.TabIndex = 32;
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_medida.Location = new System.Drawing.Point(387, 281);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(142, 19);
            this.lbl_medida.TabIndex = 35;
            this.lbl_medida.Text = "Unidad de Medida";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_costo.Location = new System.Drawing.Point(423, 348);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(48, 19);
            this.lbl_costo.TabIndex = 37;
            this.lbl_costo.Text = "Costo";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(394, 370);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(108, 24);
            this.txt_costo.TabIndex = 36;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // txt_cantidadInv
            // 
            this.txt_cantidadInv.Location = new System.Drawing.Point(604, 306);
            this.txt_cantidadInv.Name = "txt_cantidadInv";
            this.txt_cantidadInv.Size = new System.Drawing.Size(182, 24);
            this.txt_cantidadInv.TabIndex = 38;
            this.txt_cantidadInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadInv_KeyPress);
            // 
            // lbl_cantInv
            // 
            this.lbl_cantInv.AutoSize = true;
            this.lbl_cantInv.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cantInv.Location = new System.Drawing.Point(608, 284);
            this.lbl_cantInv.Name = "lbl_cantInv";
            this.lbl_cantInv.Size = new System.Drawing.Size(172, 19);
            this.lbl_cantInv.TabIndex = 40;
            this.lbl_cantInv.Text = "Cantidad en Inventario";
            // 
            // lbl_reorden
            // 
            this.lbl_reorden.AutoSize = true;
            this.lbl_reorden.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_reorden.Location = new System.Drawing.Point(632, 348);
            this.lbl_reorden.Name = "lbl_reorden";
            this.lbl_reorden.Size = new System.Drawing.Size(130, 19);
            this.lbl_reorden.TabIndex = 41;
            this.lbl_reorden.Text = "Punto de reorden";
            // 
            // txt_reorden
            // 
            this.txt_reorden.Location = new System.Drawing.Point(604, 370);
            this.txt_reorden.Name = "txt_reorden";
            this.txt_reorden.Size = new System.Drawing.Size(182, 24);
            this.txt_reorden.TabIndex = 42;
            this.txt_reorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reorden_KeyPress);
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(396, 437);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(106, 24);
            this.txt_precioUnitario.TabIndex = 44;
            this.txt_precioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitario_KeyPress);
            // 
            // lbl_precioUni
            // 
            this.lbl_precioUni.AutoSize = true;
            this.lbl_precioUni.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_precioUni.Location = new System.Drawing.Point(395, 415);
            this.lbl_precioUni.Name = "lbl_precioUni";
            this.lbl_precioUni.Size = new System.Drawing.Size(107, 19);
            this.lbl_precioUni.TabIndex = 43;
            this.lbl_precioUni.Text = "Precio Unitario";
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(394, 306);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(108, 27);
            this.cbUnidadMedida.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(21, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 19);
            this.label14.TabIndex = 63;
            this.label14.Text = "Selecciona un Producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(24, 106);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(330, 372);
            this.dgv_productos.TabIndex = 62;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // lb_productoEliminado
            // 
            this.lb_productoEliminado.AutoSize = true;
            this.lb_productoEliminado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productoEliminado.ForeColor = System.Drawing.Color.Red;
            this.lb_productoEliminado.Location = new System.Drawing.Point(563, 541);
            this.lb_productoEliminado.Name = "lb_productoEliminado";
            this.lb_productoEliminado.Size = new System.Drawing.Size(256, 19);
            this.lb_productoEliminado.TabIndex = 39;
            this.lb_productoEliminado.Text = "Este producto ha sido eliminado";
            this.lb_productoEliminado.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(393, 188);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(187, 24);
            this.txt_id.TabIndex = 64;
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.Checked = false;
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(849, 370);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 24);
            this.tp_fechaIngreso.TabIndex = 118;
            this.tp_fechaIngreso.Value = new System.DateTime(2022, 12, 8, 17, 25, 56, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(846, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 117;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(851, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 119;
            this.label1.Text = "Tiene Descuento:";
            // 
            // lbl_idadmin
            // 
            this.lbl_idadmin.AutoSize = true;
            this.lbl_idadmin.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idadmin.Location = new System.Drawing.Point(699, 168);
            this.lbl_idadmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idadmin.Name = "lbl_idadmin";
            this.lbl_idadmin.Size = new System.Drawing.Size(131, 19);
            this.lbl_idadmin.TabIndex = 123;
            this.lbl_idadmin.Text = "IDADMINISTRADOR";
            // 
            // txt_nameadmin
            // 
            this.txt_nameadmin.Enabled = false;
            this.txt_nameadmin.Location = new System.Drawing.Point(599, 188);
            this.txt_nameadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nameadmin.Name = "txt_nameadmin";
            this.txt_nameadmin.ReadOnly = true;
            this.txt_nameadmin.Size = new System.Drawing.Size(231, 24);
            this.txt_nameadmin.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(595, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 121;
            this.label10.Text = "Lo dió de alta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(595, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Datos del Producto";
            // 
            // cb_si
            // 
            this.cb_si.AutoSize = true;
            this.cb_si.Enabled = false;
            this.cb_si.Location = new System.Drawing.Point(855, 302);
            this.cb_si.Name = "cb_si";
            this.cb_si.Size = new System.Drawing.Size(38, 23);
            this.cb_si.TabIndex = 125;
            this.cb_si.Text = "Si";
            this.cb_si.UseVisualStyleBackColor = true;
            // 
            // cb_no
            // 
            this.cb_no.AutoSize = true;
            this.cb_no.Enabled = false;
            this.cb_no.Location = new System.Drawing.Point(930, 302);
            this.cb_no.Name = "cb_no";
            this.cb_no.Size = new System.Drawing.Size(47, 23);
            this.cb_no.TabIndex = 126;
            this.cb_no.Text = "No";
            this.cb_no.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Checked = false;
            this.dtp.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.dtp.Enabled = false;
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(850, 426);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 24);
            this.dtp.TabIndex = 127;
            this.dtp.Value = new System.DateTime(2022, 12, 8, 17, 25, 56, 0);
            this.dtp.Visible = false;
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1103, 589);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cb_no);
            this.Controls.Add(this.cb_si);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_idadmin);
            this.Controls.Add(this.txt_nameadmin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.cbUnidadMedida);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.lbl_precioUni);
            this.Controls.Add(this.txt_reorden);
            this.Controls.Add(this.lbl_reorden);
            this.Controls.Add(this.lbl_cantInv);
            this.Controls.Add(this.lb_productoEliminado);
            this.Controls.Add(this.txt_cantidadInv);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.lbl_medida);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.cb_departamento);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_idprod);
            this.Controls.Add(this.btn_EProducto);
            this.Controls.Add(this.btn_MProducto);
            this.Controls.Add(this.btn_NProducto);
            this.Controls.Add(this.btn_regresar_GP);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionProductos";
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_regresar_GP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_NProducto;
        private System.Windows.Forms.Button btn_MProducto;
        private System.Windows.Forms.Button btn_EProducto;
        private System.Windows.Forms.Label lbl_idprod;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_cantidadInv;
        private System.Windows.Forms.Label lbl_cantInv;
        private System.Windows.Forms.Label lbl_reorden;
        private System.Windows.Forms.TextBox txt_reorden;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUni;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label lb_productoEliminado;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idadmin;
        private System.Windows.Forms.TextBox txt_nameadmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_si;
        private System.Windows.Forms.CheckBox cb_no;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}