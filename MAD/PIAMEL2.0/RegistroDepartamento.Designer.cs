namespace PIAMEL2._0
{
    partial class RegistroDepartamento
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
            this.lbl_idadmin = new System.Windows.Forms.Label();
            this.chb_devolucion = new System.Windows.Forms.CheckBox();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txt_descripction = new System.Windows.Forms.TextBox();
            this.txt_nombre_RE = new System.Windows.Forms.TextBox();
            this.txt_nameadmin = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar_RE = new System.Windows.Forms.Button();
            this.btn_cancelar_RE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_idadmin
            // 
            this.lbl_idadmin.AutoSize = true;
            this.lbl_idadmin.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idadmin.Location = new System.Drawing.Point(146, 167);
            this.lbl_idadmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idadmin.Name = "lbl_idadmin";
            this.lbl_idadmin.Size = new System.Drawing.Size(124, 17);
            this.lbl_idadmin.TabIndex = 117;
            this.lbl_idadmin.Text = "IDADMINISTRADOR";
            // 
            // chb_devolucion
            // 
            this.chb_devolucion.AutoSize = true;
            this.chb_devolucion.ForeColor = System.Drawing.Color.Indigo;
            this.chb_devolucion.Location = new System.Drawing.Point(64, 283);
            this.chb_devolucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chb_devolucion.Name = "chb_devolucion";
            this.chb_devolucion.Size = new System.Drawing.Size(154, 21);
            this.chb_devolucion.TabIndex = 105;
            this.chb_devolucion.Text = "Permite Devolución";
            this.chb_devolucion.UseVisualStyleBackColor = true;
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(309, 285);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.tp_fechaIngreso.TabIndex = 116;
            // 
            // txt_descripction
            // 
            this.txt_descripction.Location = new System.Drawing.Point(309, 120);
            this.txt_descripction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_descripction.Multiline = true;
            this.txt_descripction.Name = "txt_descripction";
            this.txt_descripction.Size = new System.Drawing.Size(200, 117);
            this.txt_descripction.TabIndex = 115;
            // 
            // txt_nombre_RE
            // 
            this.txt_nombre_RE.Location = new System.Drawing.Point(39, 240);
            this.txt_nombre_RE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nombre_RE.Name = "txt_nombre_RE";
            this.txt_nombre_RE.Size = new System.Drawing.Size(205, 23);
            this.txt_nombre_RE.TabIndex = 114;
            // 
            // txt_nameadmin
            // 
            this.txt_nameadmin.Enabled = false;
            this.txt_nameadmin.Location = new System.Drawing.Point(39, 187);
            this.txt_nameadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nameadmin.Name = "txt_nameadmin";
            this.txt_nameadmin.ReadOnly = true;
            this.txt_nameadmin.Size = new System.Drawing.Size(205, 23);
            this.txt_nameadmin.TabIndex = 113;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(39, 129);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(205, 23);
            this.txt_id.TabIndex = 112;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(35, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 111;
            this.label12.Text = "Id Departamento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(35, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 110;
            this.label10.Text = "Lo dará de alta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(306, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 109;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(306, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(41, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nombre:";
            // 
            // btn_registrar_RE
            // 
            this.btn_registrar_RE.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_registrar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_registrar_RE.Location = new System.Drawing.Point(395, 386);
            this.btn_registrar_RE.Name = "btn_registrar_RE";
            this.btn_registrar_RE.Size = new System.Drawing.Size(126, 30);
            this.btn_registrar_RE.TabIndex = 119;
            this.btn_registrar_RE.Text = "Registrar";
            this.btn_registrar_RE.UseVisualStyleBackColor = false;
            this.btn_registrar_RE.Click += new System.EventHandler(this.btn_registrar_RE_Click);
            // 
            // btn_cancelar_RE
            // 
            this.btn_cancelar_RE.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar_RE.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_cancelar_RE.Location = new System.Drawing.Point(244, 386);
            this.btn_cancelar_RE.Name = "btn_cancelar_RE";
            this.btn_cancelar_RE.Size = new System.Drawing.Size(126, 30);
            this.btn_cancelar_RE.TabIndex = 118;
            this.btn_cancelar_RE.Text = "Cancelar";
            this.btn_cancelar_RE.UseVisualStyleBackColor = false;
            this.btn_cancelar_RE.Click += new System.EventHandler(this.btn_cancelar_RE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(154, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 120;
            this.label1.Text = "Ingresa los datos requeridos:";
            // 
            // RegistroDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registrar_RE);
            this.Controls.Add(this.btn_cancelar_RE);
            this.Controls.Add(this.lbl_idadmin);
            this.Controls.Add(this.chb_devolucion);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.txt_descripction);
            this.Controls.Add(this.txt_nombre_RE);
            this.Controls.Add(this.txt_nameadmin);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroDepartamento";
            this.Text = "RegistroDepartamento";
            this.Load += new System.EventHandler(this.RegistroDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idadmin;
        private System.Windows.Forms.CheckBox chb_devolucion;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.TextBox txt_descripction;
        private System.Windows.Forms.TextBox txt_nombre_RE;
        private System.Windows.Forms.TextBox txt_nameadmin;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar_RE;
        private System.Windows.Forms.Button btn_cancelar_RE;
        private System.Windows.Forms.Label label1;
    }
}