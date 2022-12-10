namespace MAD._0
{
    partial class GestionDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDescuentos));
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_devoluciones = new System.Windows.Forms.DataGridView();
            this.btn_EProducto = new System.Windows.Forms.Button();
            this.btn_MProducto = new System.Windows.Forms.Button();
            this.btn_NProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtx_porcentaje = new System.Windows.Forms.TextBox();
            this.txt_depa = new System.Windows.Forms.TextBox();
            this.IDPRODUCTO = new System.Windows.Forms.Label();
            this.LBL_Depa = new System.Windows.Forms.Label();
            this.DateInicio = new System.Windows.Forms.DateTimePicker();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_idadmin = new System.Windows.Forms.Label();
            this.txt_nameadmin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.LBL_IDDESCUENTO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(604, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 17;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(768, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 16;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(170, 31);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(132, 17);
            this.lbl_nombrec_PA.TabIndex = 15;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrador:";
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(26, 488);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 19;
            this.btn_regresar_GC.Text = "Regresar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_devoluciones
            // 
            this.dgv_devoluciones.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devoluciones.Location = new System.Drawing.Point(26, 130);
            this.dgv_devoluciones.Name = "dgv_devoluciones";
            this.dgv_devoluciones.RowHeadersWidth = 51;
            this.dgv_devoluciones.RowTemplate.Height = 24;
            this.dgv_devoluciones.Size = new System.Drawing.Size(363, 280);
            this.dgv_devoluciones.TabIndex = 20;
            this.dgv_devoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_devoluciones_CellClick);
            // 
            // btn_EProducto
            // 
            this.btn_EProducto.BackColor = System.Drawing.Color.Crimson;
            this.btn_EProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EProducto.Location = new System.Drawing.Point(632, 488);
            this.btn_EProducto.Name = "btn_EProducto";
            this.btn_EProducto.Size = new System.Drawing.Size(147, 39);
            this.btn_EProducto.TabIndex = 28;
            this.btn_EProducto.Text = "Eliminar";
            this.btn_EProducto.UseVisualStyleBackColor = false;
            // 
            // btn_MProducto
            // 
            this.btn_MProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MProducto.Location = new System.Drawing.Point(800, 488);
            this.btn_MProducto.Name = "btn_MProducto";
            this.btn_MProducto.Size = new System.Drawing.Size(147, 39);
            this.btn_MProducto.TabIndex = 27;
            this.btn_MProducto.Text = "Modificar";
            this.btn_MProducto.UseVisualStyleBackColor = false;
            this.btn_MProducto.Click += new System.EventHandler(this.btn_MProducto_Click);
            // 
            // btn_NProducto
            // 
            this.btn_NProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NProducto.Location = new System.Drawing.Point(800, 89);
            this.btn_NProducto.Name = "btn_NProducto";
            this.btn_NProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_NProducto.TabIndex = 26;
            this.btn_NProducto.Text = "Nuevo Descuento";
            this.btn_NProducto.UseVisualStyleBackColor = false;
            this.btn_NProducto.Click += new System.EventHandler(this.btn_NProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecciona un descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(493, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 190;
            this.label7.Text = "%";
            // 
            // txtx_porcentaje
            // 
            this.txtx_porcentaje.Location = new System.Drawing.Point(431, 376);
            this.txtx_porcentaje.Name = "txtx_porcentaje";
            this.txtx_porcentaje.Size = new System.Drawing.Size(56, 23);
            this.txtx_porcentaje.TabIndex = 189;
            // 
            // txt_depa
            // 
            this.txt_depa.Enabled = false;
            this.txt_depa.Location = new System.Drawing.Point(431, 309);
            this.txt_depa.Name = "txt_depa";
            this.txt_depa.ReadOnly = true;
            this.txt_depa.Size = new System.Drawing.Size(164, 23);
            this.txt_depa.TabIndex = 188;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.AutoSize = true;
            this.IDPRODUCTO.ForeColor = System.Drawing.Color.Indigo;
            this.IDPRODUCTO.Location = new System.Drawing.Point(504, 209);
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.Size = new System.Drawing.Size(93, 17);
            this.IDPRODUCTO.TabIndex = 187;
            this.IDPRODUCTO.Text = "IDPRODUCTO";
            // 
            // LBL_Depa
            // 
            this.LBL_Depa.AutoSize = true;
            this.LBL_Depa.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_Depa.Location = new System.Drawing.Point(538, 286);
            this.LBL_Depa.Name = "LBL_Depa";
            this.LBL_Depa.Size = new System.Drawing.Size(121, 17);
            this.LBL_Depa.TabIndex = 186;
            this.LBL_Depa.Text = "IDDEPARTAMENTO";
            // 
            // DateInicio
            // 
            this.DateInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicio.Location = new System.Drawing.Point(730, 349);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(217, 21);
            this.DateInicio.TabIndex = 185;
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Location = new System.Drawing.Point(730, 376);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(217, 21);
            this.DateFinal.TabIndex = 184;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(680, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 183;
            this.label5.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(678, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 182;
            this.label6.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(426, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 181;
            this.label2.Text = "Porcentaje:";
            // 
            // lbl_idadmin
            // 
            this.lbl_idadmin.AutoSize = true;
            this.lbl_idadmin.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idadmin.Location = new System.Drawing.Point(538, 140);
            this.lbl_idadmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idadmin.Name = "lbl_idadmin";
            this.lbl_idadmin.Size = new System.Drawing.Size(124, 17);
            this.lbl_idadmin.TabIndex = 180;
            this.lbl_idadmin.Text = "IDADMINISTRADOR";
            // 
            // txt_nameadmin
            // 
            this.txt_nameadmin.Enabled = false;
            this.txt_nameadmin.Location = new System.Drawing.Point(431, 160);
            this.txt_nameadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nameadmin.Name = "txt_nameadmin";
            this.txt_nameadmin.ReadOnly = true;
            this.txt_nameadmin.Size = new System.Drawing.Size(231, 23);
            this.txt_nameadmin.TabIndex = 179;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(427, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 178;
            this.label10.Text = "Lo dió de alta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(428, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 177;
            this.label3.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(426, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 176;
            this.label8.Text = "Producto:";
            // 
            // txt_producto
            // 
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(431, 229);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(164, 23);
            this.txt_producto.TabIndex = 191;
            // 
            // LBL_IDDESCUENTO
            // 
            this.LBL_IDDESCUENTO.AutoSize = true;
            this.LBL_IDDESCUENTO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IDDESCUENTO.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_IDDESCUENTO.Location = new System.Drawing.Point(850, 197);
            this.LBL_IDDESCUENTO.Name = "LBL_IDDESCUENTO";
            this.LBL_IDDESCUENTO.Size = new System.Drawing.Size(95, 17);
            this.LBL_IDDESCUENTO.TabIndex = 192;
            this.LBL_IDDESCUENTO.Text = "idDESCUENTO";
            this.LBL_IDDESCUENTO.Visible = false;
            // 
            // GestionDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(988, 556);
            this.Controls.Add(this.LBL_IDDESCUENTO);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtx_porcentaje);
            this.Controls.Add(this.txt_depa);
            this.Controls.Add(this.IDPRODUCTO);
            this.Controls.Add(this.LBL_Depa);
            this.Controls.Add(this.DateInicio);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_idadmin);
            this.Controls.Add(this.txt_nameadmin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EProducto);
            this.Controls.Add(this.btn_MProducto);
            this.Controls.Add(this.btn_NProducto);
            this.Controls.Add(this.dgv_devoluciones);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDescuentos";
            this.Load += new System.EventHandler(this.GestionDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_devoluciones;
        private System.Windows.Forms.Button btn_EProducto;
        private System.Windows.Forms.Button btn_MProducto;
        private System.Windows.Forms.Button btn_NProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtx_porcentaje;
        private System.Windows.Forms.TextBox txt_depa;
        private System.Windows.Forms.Label IDPRODUCTO;
        private System.Windows.Forms.Label LBL_Depa;
        private System.Windows.Forms.DateTimePicker DateInicio;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_idadmin;
        private System.Windows.Forms.TextBox txt_nameadmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label LBL_IDDESCUENTO;
    }
}