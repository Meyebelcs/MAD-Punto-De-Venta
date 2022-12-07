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
            this.lb_productoEliminado = new System.Windows.Forms.Label();
            this.txt_cantidadInv = new System.Windows.Forms.TextBox();
            this.lbl_cantInv = new System.Windows.Forms.Label();
            this.lbl_reorden = new System.Windows.Forms.Label();
            this.txt_reorden = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_precioUni = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_idProducto = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(497, 47);
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
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(661, 5);
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
            // lbl_idprod
            // 
            this.lbl_idprod.AutoSize = true;
            this.lbl_idprod.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idprod.Location = new System.Drawing.Point(516, 113);
            this.lbl_idprod.Name = "lbl_idprod";
            this.lbl_idprod.Size = new System.Drawing.Size(93, 19);
            this.lbl_idprod.TabIndex = 27;
            this.lbl_idprod.Text = " ID Producto";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_departamento.Location = new System.Drawing.Point(634, 177);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(112, 19);
            this.lbl_departamento.TabIndex = 29;
            this.lbl_departamento.Text = "Departamento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(344, 201);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(187, 24);
            this.txt_nombre.TabIndex = 28;
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(595, 200);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(187, 27);
            this.cb_departamento.TabIndex = 30;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombre.Location = new System.Drawing.Point(400, 177);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 19);
            this.lbl_nombre.TabIndex = 31;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_descripcion.Location = new System.Drawing.Point(645, 366);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(89, 19);
            this.lbl_descripcion.TabIndex = 33;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(595, 388);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(187, 58);
            this.txt_descripcion.TabIndex = 32;
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_medida.Location = new System.Drawing.Point(366, 241);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(142, 19);
            this.lbl_medida.TabIndex = 35;
            this.lbl_medida.Text = "Unidad de Medida";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_costo.Location = new System.Drawing.Point(412, 307);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(48, 19);
            this.lbl_costo.TabIndex = 37;
            this.lbl_costo.Text = "Costo";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(381, 331);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(108, 24);
            this.txt_costo.TabIndex = 36;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // lb_productoEliminado
            // 
            this.lb_productoEliminado.AutoSize = true;
            this.lb_productoEliminado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productoEliminado.ForeColor = System.Drawing.Color.Red;
            this.lb_productoEliminado.Location = new System.Drawing.Point(436, 476);
            this.lb_productoEliminado.Name = "lb_productoEliminado";
            this.lb_productoEliminado.Size = new System.Drawing.Size(256, 19);
            this.lb_productoEliminado.TabIndex = 39;
            this.lb_productoEliminado.Text = "Este producto ha sido eliminado";
            // 
            // txt_cantidadInv
            // 
            this.txt_cantidadInv.Location = new System.Drawing.Point(640, 266);
            this.txt_cantidadInv.Name = "txt_cantidadInv";
            this.txt_cantidadInv.Size = new System.Drawing.Size(106, 24);
            this.txt_cantidadInv.TabIndex = 38;
            this.txt_cantidadInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadInv_KeyPress);
            // 
            // lbl_cantInv
            // 
            this.lbl_cantInv.AutoSize = true;
            this.lbl_cantInv.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cantInv.Location = new System.Drawing.Point(611, 244);
            this.lbl_cantInv.Name = "lbl_cantInv";
            this.lbl_cantInv.Size = new System.Drawing.Size(172, 19);
            this.lbl_cantInv.TabIndex = 40;
            this.lbl_cantInv.Text = "Cantidad en Inventario";
            // 
            // lbl_reorden
            // 
            this.lbl_reorden.AutoSize = true;
            this.lbl_reorden.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_reorden.Location = new System.Drawing.Point(626, 309);
            this.lbl_reorden.Name = "lbl_reorden";
            this.lbl_reorden.Size = new System.Drawing.Size(130, 19);
            this.lbl_reorden.TabIndex = 41;
            this.lbl_reorden.Text = "Punto de reorden";
            // 
            // txt_reorden
            // 
            this.txt_reorden.Location = new System.Drawing.Point(640, 331);
            this.txt_reorden.Name = "txt_reorden";
            this.txt_reorden.Size = new System.Drawing.Size(106, 24);
            this.txt_reorden.TabIndex = 42;
            this.txt_reorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reorden_KeyPress);
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(381, 396);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(106, 24);
            this.txt_precioUnitario.TabIndex = 44;
            this.txt_precioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitario_KeyPress);
            // 
            // lbl_precioUni
            // 
            this.lbl_precioUni.AutoSize = true;
            this.lbl_precioUni.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_precioUni.Location = new System.Drawing.Point(380, 374);
            this.lbl_precioUni.Name = "lbl_precioUni";
            this.lbl_precioUni.Size = new System.Drawing.Size(107, 19);
            this.lbl_precioUni.TabIndex = 43;
            this.lbl_precioUni.Text = "Precio Unitario";
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
            this.cb_idProducto.Size = new System.Drawing.Size(161, 27);
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
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(381, 266);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(108, 27);
            this.cbUnidadMedida.TabIndex = 48;
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(886, 591);
            this.Controls.Add(this.cbUnidadMedida);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.cb_idProducto);
            this.Controls.Add(this.btn_guardar);
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
        private System.Windows.Forms.Label lb_productoEliminado;
        private System.Windows.Forms.TextBox txt_cantidadInv;
        private System.Windows.Forms.Label lbl_cantInv;
        private System.Windows.Forms.Label lbl_reorden;
        private System.Windows.Forms.TextBox txt_reorden;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUni;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cb_idProducto;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
    }
}