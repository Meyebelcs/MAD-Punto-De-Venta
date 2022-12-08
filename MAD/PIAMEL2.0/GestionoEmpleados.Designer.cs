namespace PIAMEL2._0
{
    partial class gestionEmpleados
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
            this.gb_check_RE = new System.Windows.Forms.GroupBox();
            this.chb_admin_RE = new System.Windows.Forms.CheckBox();
            this.chb_cajero_RE = new System.Windows.Forms.CheckBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar_RE = new System.Windows.Forms.Button();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txt_nomina_RE = new System.Windows.Forms.TextBox();
            this.txt_curp_RE = new System.Windows.Forms.TextBox();
            this.tp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_Email_RE = new System.Windows.Forms.TextBox();
            this.txt_Telefono_RE = new System.Windows.Forms.TextBox();
            this.txt_codigoAcceso_RE = new System.Windows.Forms.TextBox();
            this.txt_ApellidoP_RE = new System.Windows.Forms.TextBox();
            this.txt_ApellidoM_RE = new System.Windows.Forms.TextBox();
            this.txt_nombre_RE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_contraseña_RE = new System.Windows.Forms.TextBox();
            this.txt_usuario_RE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_check_RE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_check_RE
            // 
            this.gb_check_RE.Controls.Add(this.chb_admin_RE);
            this.gb_check_RE.Controls.Add(this.chb_cajero_RE);
            this.gb_check_RE.ForeColor = System.Drawing.Color.Indigo;
            this.gb_check_RE.Location = new System.Drawing.Point(635, 136);
            this.gb_check_RE.Name = "gb_check_RE";
            this.gb_check_RE.Size = new System.Drawing.Size(221, 90);
            this.gb_check_RE.TabIndex = 59;
            this.gb_check_RE.TabStop = false;
            this.gb_check_RE.Text = "Selecciona una opción:";
            // 
            // chb_admin_RE
            // 
            this.chb_admin_RE.AutoSize = true;
            this.chb_admin_RE.ForeColor = System.Drawing.Color.Indigo;
            this.chb_admin_RE.Location = new System.Drawing.Point(11, 25);
            this.chb_admin_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chb_admin_RE.Name = "chb_admin_RE";
            this.chb_admin_RE.Size = new System.Drawing.Size(117, 21);
            this.chb_admin_RE.TabIndex = 12;
            this.chb_admin_RE.Text = "Administrador";
            this.chb_admin_RE.UseVisualStyleBackColor = true;
            this.chb_admin_RE.CheckedChanged += new System.EventHandler(this.chb_admin_RE_CheckedChanged);
            // 
            // chb_cajero_RE
            // 
            this.chb_cajero_RE.AutoSize = true;
            this.chb_cajero_RE.ForeColor = System.Drawing.Color.Indigo;
            this.chb_cajero_RE.Location = new System.Drawing.Point(11, 53);
            this.chb_cajero_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chb_cajero_RE.Name = "chb_cajero_RE";
            this.chb_cajero_RE.Size = new System.Drawing.Size(71, 21);
            this.chb_cajero_RE.TabIndex = 13;
            this.chb_cajero_RE.Text = "Cajero";
            this.chb_cajero_RE.UseVisualStyleBackColor = true;
            this.chb_cajero_RE.CheckedChanged += new System.EventHandler(this.chb_cajero_RE_CheckedChanged);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_modificar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_modificar.Location = new System.Drawing.Point(957, 547);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(126, 30);
            this.btn_modificar.TabIndex = 58;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_registrar_RE_Click);
            // 
            // btn_cancelar_RE
            // 
            this.btn_cancelar_RE.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_cancelar_RE.Location = new System.Drawing.Point(31, 547);
            this.btn_cancelar_RE.Name = "btn_cancelar_RE";
            this.btn_cancelar_RE.Size = new System.Drawing.Size(126, 30);
            this.btn_cancelar_RE.TabIndex = 57;
            this.btn_cancelar_RE.Text = "Regresar";
            this.btn_cancelar_RE.UseVisualStyleBackColor = false;
            this.btn_cancelar_RE.Click += new System.EventHandler(this.btn_cancelar_RE_Click);
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(864, 499);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.tp_fechaIngreso.TabIndex = 56;
            // 
            // txt_nomina_RE
            // 
            this.txt_nomina_RE.Location = new System.Drawing.Point(633, 499);
            this.txt_nomina_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nomina_RE.Name = "txt_nomina_RE";
            this.txt_nomina_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_nomina_RE.TabIndex = 55;
            this.txt_nomina_RE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomina_RE_KeyPress);
            // 
            // txt_curp_RE
            // 
            this.txt_curp_RE.Location = new System.Drawing.Point(409, 499);
            this.txt_curp_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_curp_RE.Name = "txt_curp_RE";
            this.txt_curp_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_curp_RE.TabIndex = 54;
            // 
            // tp_fechaNacimiento
            // 
            this.tp_fechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.tp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaNacimiento.Location = new System.Drawing.Point(864, 405);
            this.tp_fechaNacimiento.Name = "tp_fechaNacimiento";
            this.tp_fechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.tp_fechaNacimiento.TabIndex = 53;
            // 
            // txt_Email_RE
            // 
            this.txt_Email_RE.Location = new System.Drawing.Point(633, 405);
            this.txt_Email_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Email_RE.Name = "txt_Email_RE";
            this.txt_Email_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_Email_RE.TabIndex = 52;
            // 
            // txt_Telefono_RE
            // 
            this.txt_Telefono_RE.Location = new System.Drawing.Point(409, 405);
            this.txt_Telefono_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Telefono_RE.Name = "txt_Telefono_RE";
            this.txt_Telefono_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_Telefono_RE.TabIndex = 51;
            this.txt_Telefono_RE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_RE_KeyPress);
            // 
            // txt_codigoAcceso_RE
            // 
            this.txt_codigoAcceso_RE.Enabled = false;
            this.txt_codigoAcceso_RE.Location = new System.Drawing.Point(879, 184);
            this.txt_codigoAcceso_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_codigoAcceso_RE.Name = "txt_codigoAcceso_RE";
            this.txt_codigoAcceso_RE.Size = new System.Drawing.Size(185, 23);
            this.txt_codigoAcceso_RE.TabIndex = 50;
            this.txt_codigoAcceso_RE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoAcceso_RE_KeyPress);
            // 
            // txt_ApellidoP_RE
            // 
            this.txt_ApellidoP_RE.Location = new System.Drawing.Point(635, 320);
            this.txt_ApellidoP_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ApellidoP_RE.Name = "txt_ApellidoP_RE";
            this.txt_ApellidoP_RE.Size = new System.Drawing.Size(200, 23);
            this.txt_ApellidoP_RE.TabIndex = 49;
            // 
            // txt_ApellidoM_RE
            // 
            this.txt_ApellidoM_RE.Location = new System.Drawing.Point(864, 320);
            this.txt_ApellidoM_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ApellidoM_RE.Name = "txt_ApellidoM_RE";
            this.txt_ApellidoM_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_ApellidoM_RE.TabIndex = 48;
            // 
            // txt_nombre_RE
            // 
            this.txt_nombre_RE.Location = new System.Drawing.Point(409, 320);
            this.txt_nombre_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nombre_RE.Name = "txt_nombre_RE";
            this.txt_nombre_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_nombre_RE.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(884, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Código de Acceso:";
            // 
            // txt_contraseña_RE
            // 
            this.txt_contraseña_RE.Location = new System.Drawing.Point(404, 197);
            this.txt_contraseña_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_contraseña_RE.Name = "txt_contraseña_RE";
            this.txt_contraseña_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_contraseña_RE.TabIndex = 45;
            // 
            // txt_usuario_RE
            // 
            this.txt_usuario_RE.Enabled = false;
            this.txt_usuario_RE.Location = new System.Drawing.Point(404, 135);
            this.txt_usuario_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_usuario_RE.Name = "txt_usuario_RE";
            this.txt_usuario_RE.ReadOnly = true;
            this.txt_usuario_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_usuario_RE.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(400, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(645, 475);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Número de Nómina:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(400, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(868, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(480, 475);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "CURP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(880, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(708, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(467, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(657, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(887, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(467, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(656, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Datos del Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(31, 79);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(330, 450);
            this.dgv_empleados.TabIndex = 60;
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellClick_1);
            this.dgv_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentClick);
            this.dgv_empleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(28, 59);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Selecciona un Empleado";
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(802, 35);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 65;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(950, 3);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 64;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(186, 18);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(132, 17);
            this.lbl_nombrec_PA.TabIndex = 63;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(38, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 62;
            this.label15.Text = "Administrador:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Crimson;
            this.btn_eliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_eliminar.Location = new System.Drawing.Point(806, 547);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(126, 30);
            this.btn_eliminar.TabIndex = 66;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_agregar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_agregar.Location = new System.Drawing.Point(940, 76);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(143, 45);
            this.btn_agregar.TabIndex = 67;
            this.btn_agregar.Text = "Nuevo Empleado";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1119, 594);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.gb_check_RE);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_cancelar_RE);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.txt_nomina_RE);
            this.Controls.Add(this.txt_curp_RE);
            this.Controls.Add(this.tp_fechaNacimiento);
            this.Controls.Add(this.txt_Email_RE);
            this.Controls.Add(this.txt_Telefono_RE);
            this.Controls.Add(this.txt_codigoAcceso_RE);
            this.Controls.Add(this.txt_ApellidoP_RE);
            this.Controls.Add(this.txt_ApellidoM_RE);
            this.Controls.Add(this.txt_nombre_RE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_contraseña_RE);
            this.Controls.Add(this.txt_usuario_RE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "gestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Empleados";
            this.Load += new System.EventHandler(this.gestionEmpleados_Load);
            this.gb_check_RE.ResumeLayout(false);
            this.gb_check_RE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_check_RE;
        private System.Windows.Forms.CheckBox chb_admin_RE;
        private System.Windows.Forms.CheckBox chb_cajero_RE;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar_RE;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.TextBox txt_nomina_RE;
        private System.Windows.Forms.TextBox txt_curp_RE;
        private System.Windows.Forms.DateTimePicker tp_fechaNacimiento;
        private System.Windows.Forms.TextBox txt_Email_RE;
        private System.Windows.Forms.TextBox txt_Telefono_RE;
        private System.Windows.Forms.TextBox txt_codigoAcceso_RE;
        private System.Windows.Forms.TextBox txt_ApellidoP_RE;
        private System.Windows.Forms.TextBox txt_ApellidoM_RE;
        private System.Windows.Forms.TextBox txt_nombre_RE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_contraseña_RE;
        private System.Windows.Forms.TextBox txt_usuario_RE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Timer timer1;
    }
}