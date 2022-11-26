namespace MAD._0
{
    partial class ReporteRecibos
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
            this.btn_regresar_GP = new System.Windows.Forms.Button();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_ticket = new System.Windows.Forms.DataGridView();
            this.btn_buscarIdTicket = new System.Windows.Forms.Button();
            this.txt_idticket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IdNota = new System.Windows.Forms.Button();
            this.txt_notacredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_fechaventa = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_caja = new System.Windows.Forms.ComboBox();
            this.btn_buscarFechaCaja = new System.Windows.Forms.Button();
            this.btn_imprimirPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar_GP
            // 
            this.btn_regresar_GP.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GP.Location = new System.Drawing.Point(12, 653);
            this.btn_regresar_GP.Name = "btn_regresar_GP";
            this.btn_regresar_GP.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GP.TabIndex = 29;
            this.btn_regresar_GP.Text = "Regresar";
            this.btn_regresar_GP.UseVisualStyleBackColor = false;
            this.btn_regresar_GP.Click += new System.EventHandler(this.btn_regresar_GP_Click);
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(615, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 28;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(779, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 27;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(181, 29);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(137, 19);
            this.lbl_nombrec_PA.TabIndex = 26;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_ticket
            // 
            this.dgv_ticket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ticket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ticket.Location = new System.Drawing.Point(74, 270);
            this.dgv_ticket.Name = "dgv_ticket";
            this.dgv_ticket.Size = new System.Drawing.Size(795, 339);
            this.dgv_ticket.TabIndex = 33;
            // 
            // btn_buscarIdTicket
            // 
            this.btn_buscarIdTicket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_buscarIdTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscarIdTicket.Location = new System.Drawing.Point(240, 132);
            this.btn_buscarIdTicket.Name = "btn_buscarIdTicket";
            this.btn_buscarIdTicket.Size = new System.Drawing.Size(89, 33);
            this.btn_buscarIdTicket.TabIndex = 32;
            this.btn_buscarIdTicket.Text = "Buscar";
            this.btn_buscarIdTicket.UseVisualStyleBackColor = false;
            this.btn_buscarIdTicket.Click += new System.EventHandler(this.btn_buscarIdTicket_Click);
            // 
            // txt_idticket
            // 
            this.txt_idticket.Location = new System.Drawing.Point(74, 136);
            this.txt_idticket.Name = "txt_idticket";
            this.txt_idticket.Size = new System.Drawing.Size(145, 24);
            this.txt_idticket.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código de Ticket:";
            // 
            // btn_IdNota
            // 
            this.btn_IdNota.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_IdNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_IdNota.Location = new System.Drawing.Point(240, 209);
            this.btn_IdNota.Name = "btn_IdNota";
            this.btn_IdNota.Size = new System.Drawing.Size(89, 33);
            this.btn_IdNota.TabIndex = 36;
            this.btn_IdNota.Text = "Buscar";
            this.btn_IdNota.UseVisualStyleBackColor = false;
            this.btn_IdNota.Click += new System.EventHandler(this.btn_IdNota_Click);
            // 
            // txt_notacredito
            // 
            this.txt_notacredito.Location = new System.Drawing.Point(74, 213);
            this.txt_notacredito.Name = "txt_notacredito";
            this.txt_notacredito.Size = new System.Drawing.Size(145, 24);
            this.txt_notacredito.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Código de Nota de crédito:";
            // 
            // time_fechaventa
            // 
            this.time_fechaventa.Location = new System.Drawing.Point(636, 161);
            this.time_fechaventa.Name = "time_fechaventa";
            this.time_fechaventa.Size = new System.Drawing.Size(200, 24);
            this.time_fechaventa.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha de la venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Caja:";
            // 
            // cb_caja
            // 
            this.cb_caja.FormattingEnabled = true;
            this.cb_caja.Location = new System.Drawing.Point(637, 213);
            this.cb_caja.Name = "cb_caja";
            this.cb_caja.Size = new System.Drawing.Size(121, 27);
            this.cb_caja.TabIndex = 40;
            // 
            // btn_buscarFechaCaja
            // 
            this.btn_buscarFechaCaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_buscarFechaCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscarFechaCaja.Location = new System.Drawing.Point(780, 209);
            this.btn_buscarFechaCaja.Name = "btn_buscarFechaCaja";
            this.btn_buscarFechaCaja.Size = new System.Drawing.Size(89, 33);
            this.btn_buscarFechaCaja.TabIndex = 43;
            this.btn_buscarFechaCaja.Text = "Buscar";
            this.btn_buscarFechaCaja.UseVisualStyleBackColor = false;
            this.btn_buscarFechaCaja.Click += new System.EventHandler(this.btn_buscarFechaCaja_Click);
            // 
            // btn_imprimirPDF
            // 
            this.btn_imprimirPDF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_imprimirPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_imprimirPDF.Location = new System.Drawing.Point(786, 653);
            this.btn_imprimirPDF.Name = "btn_imprimirPDF";
            this.btn_imprimirPDF.Size = new System.Drawing.Size(147, 39);
            this.btn_imprimirPDF.TabIndex = 44;
            this.btn_imprimirPDF.Text = "Imprimir PDF";
            this.btn_imprimirPDF.UseVisualStyleBackColor = false;
            this.btn_imprimirPDF.Click += new System.EventHandler(this.btn_imprimirPDF_Click);
            // 
            // ReporteRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 704);
            this.Controls.Add(this.btn_imprimirPDF);
            this.Controls.Add(this.btn_buscarFechaCaja);
            this.Controls.Add(this.cb_caja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time_fechaventa);
            this.Controls.Add(this.btn_IdNota);
            this.Controls.Add(this.txt_notacredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ticket);
            this.Controls.Add(this.btn_buscarIdTicket);
            this.Controls.Add(this.txt_idticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar_GP);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReporteRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de recibos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_GP;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_ticket;
        private System.Windows.Forms.Button btn_buscarIdTicket;
        private System.Windows.Forms.TextBox txt_idticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IdNota;
        private System.Windows.Forms.TextBox txt_notacredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker time_fechaventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_caja;
        private System.Windows.Forms.Button btn_buscarFechaCaja;
        private System.Windows.Forms.Button btn_imprimirPDF;
    }
}