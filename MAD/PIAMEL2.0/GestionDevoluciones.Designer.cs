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
            this.btn_regresar_GR = new System.Windows.Forms.Button();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idticket = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_ticket = new System.Windows.Forms.DataGridView();
            this.btn_AgregarP = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.chb_merma = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.btn_crearNota = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).BeginInit();
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
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
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
            // dgv_ticket
            // 
            this.dgv_ticket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ticket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ticket.Location = new System.Drawing.Point(40, 168);
            this.dgv_ticket.Name = "dgv_ticket";
            this.dgv_ticket.Size = new System.Drawing.Size(535, 339);
            this.dgv_ticket.TabIndex = 28;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(808, 307);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 94);
            this.textBox2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
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
            this.txt_producto.Size = new System.Drawing.Size(176, 24);
            this.txt_producto.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
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
            this.txt_monto.Size = new System.Drawing.Size(176, 24);
            this.txt_monto.TabIndex = 35;
            // 
            // chb_merma
            // 
            this.chb_merma.AutoSize = true;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(808, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 24);
            this.textBox1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(794, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Código de Nota de crédito";
            // 
            // GestionDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 612);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_AgregarP);
            this.Controls.Add(this.dgv_ticket);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_idticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar_GR);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "GestionDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_ticket;
        private System.Windows.Forms.Button btn_AgregarP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.CheckBox chb_merma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Button btn_crearNota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}