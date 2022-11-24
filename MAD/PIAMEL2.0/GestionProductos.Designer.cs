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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_unidadmedida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.lb_productoEliminado = new System.Windows.Forms.Label();
            this.txt_cantidadInv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_reorden = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_idProducto = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(497, 47);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(83, 27);
            this.lbl_fecha_PA.TabIndex = 21;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(661, 5);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(112, 47);
            this.lbl_tiempo_PA.TabIndex = 20;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(168, 31);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(166, 21);
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
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Administrador:";
            // 
            // btn_regresar_GP
            // 
            this.btn_regresar_GP.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GP.Location = new System.Drawing.Point(24, 523);
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
            this.btn_NProducto.Location = new System.Drawing.Point(24, 121);
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
            this.btn_MProducto.Location = new System.Drawing.Point(24, 241);
            this.btn_MProducto.Name = "btn_MProducto";
            this.btn_MProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_MProducto.TabIndex = 24;
            this.btn_MProducto.Text = "Modificar Producto";
            this.btn_MProducto.UseVisualStyleBackColor = false;
            this.btn_MProducto.Click += new System.EventHandler(this.btn_MProducto_Click);
            // 
            // btn_EProducto
            // 
            this.btn_EProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EProducto.Location = new System.Drawing.Point(24, 370);
            this.btn_EProducto.Name = "btn_EProducto";
            this.btn_EProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_EProducto.TabIndex = 25;
            this.btn_EProducto.Text = "Eliminar Producto";
            this.btn_EProducto.UseVisualStyleBackColor = false;
            this.btn_EProducto.Click += new System.EventHandler(this.btn_EProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = " ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Departamento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(338, 201);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(187, 28);
            this.txt_nombre.TabIndex = 28;
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(600, 200);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(161, 29);
            this.cb_departamento.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(367, 400);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(147, 28);
            this.txt_descripcion.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Unidad de Medida";
            // 
            // txt_unidadmedida
            // 
            this.txt_unidadmedida.Location = new System.Drawing.Point(377, 266);
            this.txt_unidadmedida.Name = "txt_unidadmedida";
            this.txt_unidadmedida.Size = new System.Drawing.Size(106, 28);
            this.txt_unidadmedida.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Costo";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(383, 331);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(93, 28);
            this.txt_costo.TabIndex = 36;
            // 
            // lb_productoEliminado
            // 
            this.lb_productoEliminado.AutoSize = true;
            this.lb_productoEliminado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productoEliminado.ForeColor = System.Drawing.Color.Red;
            this.lb_productoEliminado.Location = new System.Drawing.Point(399, 477);
            this.lb_productoEliminado.Name = "lb_productoEliminado";
            this.lb_productoEliminado.Size = new System.Drawing.Size(324, 23);
            this.lb_productoEliminado.TabIndex = 39;
            this.lb_productoEliminado.Text = "Este producto ha sido eliminado";
            // 
            // txt_cantidadInv
            // 
            this.txt_cantidadInv.Location = new System.Drawing.Point(640, 266);
            this.txt_cantidadInv.Name = "txt_cantidadInv";
            this.txt_cantidadInv.Size = new System.Drawing.Size(83, 28);
            this.txt_cantidadInv.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cantidad en Inventario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Punto de reorden";
            // 
            // txt_reorden
            // 
            this.txt_reorden.Location = new System.Drawing.Point(624, 331);
            this.txt_reorden.Name = "txt_reorden";
            this.txt_reorden.Size = new System.Drawing.Size(108, 28);
            this.txt_reorden.TabIndex = 42;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(615, 400);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(125, 28);
            this.txt_precioUnitario.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 43;
            this.label11.Text = "Precio Unitario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Location = new System.Drawing.Point(711, 523);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(147, 39);
            this.btn_guardar.TabIndex = 45;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_idProducto
            // 
            this.cb_idProducto.Enabled = false;
            this.cb_idProducto.FormattingEnabled = true;
            this.cb_idProducto.Location = new System.Drawing.Point(482, 135);
            this.cb_idProducto.Name = "cb_idProducto";
            this.cb_idProducto.Size = new System.Drawing.Size(161, 29);
            this.cb_idProducto.TabIndex = 46;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(711, 523);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(147, 39);
            this.btn_Eliminar.TabIndex = 47;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 591);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.cb_idProducto);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_reorden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_productoEliminado);
            this.Controls.Add(this.txt_cantidadInv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_unidadmedida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_unidadmedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label lb_productoEliminado;
        private System.Windows.Forms.TextBox txt_cantidadInv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_reorden;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cb_idProducto;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}