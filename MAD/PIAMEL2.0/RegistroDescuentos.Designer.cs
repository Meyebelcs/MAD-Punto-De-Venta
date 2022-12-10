namespace PIAMEL2._0
{
    partial class RegistroDescuentos
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar_RE = new System.Windows.Forms.Button();
            this.btn_cancelar_RE = new System.Windows.Forms.Button();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_idadmin = new System.Windows.Forms.Label();
            this.txt_nameadmin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateInicio = new System.Windows.Forms.DateTimePicker();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_Depa = new System.Windows.Forms.Label();
            this.lLBL_PRODUCT = new System.Windows.Forms.Label();
            this.txt_depa = new System.Windows.Forms.TextBox();
            this.txtx_porcentaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(154, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 154;
            this.label2.Text = "Ingresa los datos requeridos:";
            // 
            // btn_registrar_RE
            // 
            this.btn_registrar_RE.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_registrar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_registrar_RE.Location = new System.Drawing.Point(361, 488);
            this.btn_registrar_RE.Name = "btn_registrar_RE";
            this.btn_registrar_RE.Size = new System.Drawing.Size(126, 30);
            this.btn_registrar_RE.TabIndex = 156;
            this.btn_registrar_RE.Text = "Registrar";
            this.btn_registrar_RE.UseVisualStyleBackColor = false;
            this.btn_registrar_RE.Click += new System.EventHandler(this.btn_registrar_RE_Click);
            // 
            // btn_cancelar_RE
            // 
            this.btn_cancelar_RE.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_cancelar_RE.Location = new System.Drawing.Point(210, 488);
            this.btn_cancelar_RE.Name = "btn_cancelar_RE";
            this.btn_cancelar_RE.Size = new System.Drawing.Size(126, 30);
            this.btn_cancelar_RE.TabIndex = 155;
            this.btn_cancelar_RE.Text = "Cancelar";
            this.btn_cancelar_RE.UseVisualStyleBackColor = false;
            this.btn_cancelar_RE.Click += new System.EventHandler(this.btn_cancelar_RE_Click);
            // 
            // cb_producto
            // 
            this.cb_producto.Enabled = false;
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(56, 201);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(166, 25);
            this.cb_producto.TabIndex = 157;
            this.cb_producto.SelectedIndexChanged += new System.EventHandler(this.cb_producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(53, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 158;
            this.label1.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(55, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 160;
            this.label3.Text = "Departamento:";
            // 
            // lbl_idadmin
            // 
            this.lbl_idadmin.AutoSize = true;
            this.lbl_idadmin.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idadmin.Location = new System.Drawing.Point(256, 91);
            this.lbl_idadmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idadmin.Name = "lbl_idadmin";
            this.lbl_idadmin.Size = new System.Drawing.Size(124, 17);
            this.lbl_idadmin.TabIndex = 163;
            this.lbl_idadmin.Text = "IDADMINISTRADOR";
            // 
            // txt_nameadmin
            // 
            this.txt_nameadmin.Enabled = false;
            this.txt_nameadmin.Location = new System.Drawing.Point(149, 111);
            this.txt_nameadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nameadmin.Name = "txt_nameadmin";
            this.txt_nameadmin.ReadOnly = true;
            this.txt_nameadmin.Size = new System.Drawing.Size(205, 23);
            this.txt_nameadmin.TabIndex = 162;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(145, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 161;
            this.label10.Text = "Lo dará de alta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(53, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 165;
            this.label4.Text = "Porcentaje:";
            // 
            // DateInicio
            // 
            this.DateInicio.Enabled = false;
            this.DateInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicio.Location = new System.Drawing.Point(257, 405);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(217, 21);
            this.DateInicio.TabIndex = 169;
            // 
            // DateFinal
            // 
            this.DateFinal.Enabled = false;
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Location = new System.Drawing.Point(257, 432);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(217, 21);
            this.DateFinal.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(207, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 167;
            this.label5.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(205, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 166;
            this.label6.Text = "Desde:";
            // 
            // LBL_Depa
            // 
            this.LBL_Depa.AutoSize = true;
            this.LBL_Depa.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_Depa.Location = new System.Drawing.Point(165, 258);
            this.LBL_Depa.Name = "LBL_Depa";
            this.LBL_Depa.Size = new System.Drawing.Size(121, 17);
            this.LBL_Depa.TabIndex = 170;
            this.LBL_Depa.Text = "IDDEPARTAMENTO";
            // 
            // lLBL_PRODUCT
            // 
            this.lLBL_PRODUCT.AutoSize = true;
            this.lLBL_PRODUCT.ForeColor = System.Drawing.Color.Indigo;
            this.lLBL_PRODUCT.Location = new System.Drawing.Point(131, 181);
            this.lLBL_PRODUCT.Name = "lLBL_PRODUCT";
            this.lLBL_PRODUCT.Size = new System.Drawing.Size(121, 17);
            this.lLBL_PRODUCT.TabIndex = 171;
            this.lLBL_PRODUCT.Text = "NombreProducto";
            // 
            // txt_depa
            // 
            this.txt_depa.Enabled = false;
            this.txt_depa.Location = new System.Drawing.Point(58, 281);
            this.txt_depa.Name = "txt_depa";
            this.txt_depa.ReadOnly = true;
            this.txt_depa.Size = new System.Drawing.Size(164, 23);
            this.txt_depa.TabIndex = 172;
            // 
            // txtx_porcentaje
            // 
            this.txtx_porcentaje.Enabled = false;
            this.txtx_porcentaje.Location = new System.Drawing.Point(58, 348);
            this.txtx_porcentaje.Name = "txtx_porcentaje";
            this.txtx_porcentaje.Size = new System.Drawing.Size(56, 23);
            this.txtx_porcentaje.TabIndex = 173;
            this.txtx_porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtx_porcentaje_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(120, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 174;
            this.label7.Text = "%";
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.BackColor = System.Drawing.Color.Crimson;
            this.btn_habilitar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_habilitar.Location = new System.Drawing.Point(348, 168);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(126, 30);
            this.btn_habilitar.TabIndex = 175;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // RegistroDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 539);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtx_porcentaje);
            this.Controls.Add(this.txt_depa);
            this.Controls.Add(this.lLBL_PRODUCT);
            this.Controls.Add(this.LBL_Depa);
            this.Controls.Add(this.DateInicio);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_idadmin);
            this.Controls.Add(this.txt_nameadmin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_producto);
            this.Controls.Add(this.btn_registrar_RE);
            this.Controls.Add(this.btn_cancelar_RE);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegistroDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDescuentos";
            this.Load += new System.EventHandler(this.RegistroDescuentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar_RE;
        private System.Windows.Forms.Button btn_cancelar_RE;
        private System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_idadmin;
        private System.Windows.Forms.TextBox txt_nameadmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateInicio;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Depa;
        private System.Windows.Forms.Label lLBL_PRODUCT;
        private System.Windows.Forms.TextBox txt_depa;
        private System.Windows.Forms.TextBox txtx_porcentaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_habilitar;
    }
}