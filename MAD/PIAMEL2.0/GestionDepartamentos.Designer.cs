namespace PIAMEL2._0
{
    partial class GestionDepartamentos
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.chb_PermiteDevolucion = new System.Windows.Forms.CheckBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar_RE = new System.Windows.Forms.Button();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txt_dexcription = new System.Windows.Forms.TextBox();
            this.txt_nombre_RE = new System.Windows.Forms.TextBox();
            this.txt_nombreadmin = new System.Windows.Forms.TextBox();
            this.txt_idepa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdAdminstrador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_agregar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_agregar.Location = new System.Drawing.Point(797, 89);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(143, 73);
            this.btn_agregar.TabIndex = 103;
            this.btn_agregar.Text = "Nuevo Departamento";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Crimson;
            this.btn_eliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_eliminar.Location = new System.Drawing.Point(672, 460);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(126, 34);
            this.btn_eliminar.TabIndex = 102;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(642, 42);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 101;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(790, 10);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 100;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(177, 28);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(132, 17);
            this.lbl_nombrec_PA.TabIndex = 99;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(29, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 98;
            this.label15.Text = "Administrador:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(19, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 17);
            this.label14.TabIndex = 97;
            this.label14.Text = "Selecciona un Departamento";
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(22, 89);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(330, 337);
            this.dgv_empleados.TabIndex = 96;
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellClick);
            // 
            // chb_PermiteDevolucion
            // 
            this.chb_PermiteDevolucion.AutoSize = true;
            this.chb_PermiteDevolucion.ForeColor = System.Drawing.Color.Indigo;
            this.chb_PermiteDevolucion.Location = new System.Drawing.Point(438, 365);
            this.chb_PermiteDevolucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chb_PermiteDevolucion.Name = "chb_PermiteDevolucion";
            this.chb_PermiteDevolucion.Size = new System.Drawing.Size(154, 21);
            this.chb_PermiteDevolucion.TabIndex = 13;
            this.chb_PermiteDevolucion.Text = "Permite Devolución";
            this.chb_PermiteDevolucion.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_modificar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_modificar.Location = new System.Drawing.Point(823, 460);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(126, 34);
            this.btn_modificar.TabIndex = 94;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cancelar_RE
            // 
            this.btn_cancelar_RE.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_cancelar_RE.Location = new System.Drawing.Point(22, 460);
            this.btn_cancelar_RE.Name = "btn_cancelar_RE";
            this.btn_cancelar_RE.Size = new System.Drawing.Size(126, 34);
            this.btn_cancelar_RE.TabIndex = 93;
            this.btn_cancelar_RE.Text = "Regresar";
            this.btn_cancelar_RE.UseVisualStyleBackColor = false;
            this.btn_cancelar_RE.Click += new System.EventHandler(this.btn_cancelar_RE_Click);
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(683, 367);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.tp_fechaIngreso.TabIndex = 92;
            // 
            // txt_dexcription
            // 
            this.txt_dexcription.Location = new System.Drawing.Point(683, 202);
            this.txt_dexcription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_dexcription.Multiline = true;
            this.txt_dexcription.Name = "txt_dexcription";
            this.txt_dexcription.Size = new System.Drawing.Size(200, 117);
            this.txt_dexcription.TabIndex = 85;
            // 
            // txt_nombre_RE
            // 
            this.txt_nombre_RE.Location = new System.Drawing.Point(413, 322);
            this.txt_nombre_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nombre_RE.Name = "txt_nombre_RE";
            this.txt_nombre_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_nombre_RE.TabIndex = 83;
            // 
            // txt_nombreadmin
            // 
            this.txt_nombreadmin.Enabled = false;
            this.txt_nombreadmin.Location = new System.Drawing.Point(413, 269);
            this.txt_nombreadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nombreadmin.Name = "txt_nombreadmin";
            this.txt_nombreadmin.ReadOnly = true;
            this.txt_nombreadmin.Size = new System.Drawing.Size(205, 23);
            this.txt_nombreadmin.TabIndex = 81;
            // 
            // txt_idepa
            // 
            this.txt_idepa.Enabled = false;
            this.txt_idepa.Location = new System.Drawing.Point(413, 211);
            this.txt_idepa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_idepa.Name = "txt_idepa";
            this.txt_idepa.ReadOnly = true;
            this.txt_idepa.Size = new System.Drawing.Size(205, 23);
            this.txt_idepa.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(409, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 79;
            this.label12.Text = "Id Departamento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(409, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Lo dió de alta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(680, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(680, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(415, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(558, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Datos del Departamento";
            // 
            // txt_IdAdminstrador
            // 
            this.txt_IdAdminstrador.AutoSize = true;
            this.txt_IdAdminstrador.ForeColor = System.Drawing.Color.Indigo;
            this.txt_IdAdminstrador.Location = new System.Drawing.Point(515, 249);
            this.txt_IdAdminstrador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_IdAdminstrador.Name = "txt_IdAdminstrador";
            this.txt_IdAdminstrador.Size = new System.Drawing.Size(124, 17);
            this.txt_IdAdminstrador.TabIndex = 104;
            this.txt_IdAdminstrador.Text = "IDADMINISTRADOR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GestionDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 506);
            this.Controls.Add(this.txt_IdAdminstrador);
            this.Controls.Add(this.chb_PermiteDevolucion);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_cancelar_RE);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.txt_dexcription);
            this.Controls.Add(this.txt_nombre_RE);
            this.Controls.Add(this.txt_nombreadmin);
            this.Controls.Add(this.txt_idepa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionDepartamentos";
            this.Text = "GestionDepartamentos";
            this.Load += new System.EventHandler(this.GestionDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.CheckBox chb_PermiteDevolucion;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar_RE;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.TextBox txt_dexcription;
        private System.Windows.Forms.TextBox txt_nombre_RE;
        private System.Windows.Forms.TextBox txt_nombreadmin;
        private System.Windows.Forms.TextBox txt_idepa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_IdAdminstrador;
        private System.Windows.Forms.Timer timer1;
    }
}