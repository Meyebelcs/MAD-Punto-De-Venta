namespace MAD._0
{
    partial class PrincipalCajero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Lista_PC = new System.Windows.Forms.DataGridView();
            this.Id_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Total_PC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nombrec_PC = new System.Windows.Forms.Label();
            this.lbl_tiempo_PC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_numcaja_PC = new System.Windows.Forms.Label();
            this.horaYfecha = new System.Windows.Forms.Timer(this.components);
            this.lbl_fecha_PC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_codigop_PC = new System.Windows.Forms.TextBox();
            this.txt_nombreP_PC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_busqueda_PC = new System.Windows.Forms.DataGridView();
            this.btn_AgregarP_PC = new System.Windows.Forms.Button();
            this.btn_eliminarP_PC = new System.Windows.Forms.Button();
            this.btn_ticket_PC = new System.Windows.Forms.Button();
            this.btn_cerrarS_PC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_PC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_PC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista_PC
            // 
            this.dgv_Lista_PC.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista_PC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Lista_PC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_PC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Lista,
            this.Productos,
            this.Cantidad,
            this.precioU,
            this.Descuento,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Lista_PC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Lista_PC.Location = new System.Drawing.Point(666, 123);
            this.dgv_Lista_PC.Name = "dgv_Lista_PC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista_PC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Lista_PC.RowHeadersWidth = 51;
            this.dgv_Lista_PC.RowTemplate.Height = 24;
            this.dgv_Lista_PC.Size = new System.Drawing.Size(640, 458);
            this.dgv_Lista_PC.TabIndex = 0;
            // 
            // Id_Lista
            // 
            this.Id_Lista.HeaderText = "Id";
            this.Id_Lista.MinimumWidth = 6;
            this.Id_Lista.Name = "Id_Lista";
            this.Id_Lista.ReadOnly = true;
            this.Id_Lista.Width = 95;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.MinimumWidth = 6;
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 90;
            // 
            // precioU
            // 
            this.precioU.HeaderText = "Precio";
            this.precioU.MinimumWidth = 6;
            this.precioU.Name = "precioU";
            this.precioU.ReadOnly = true;
            this.precioU.Width = 90;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 90;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1025, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL:";
            // 
            // lbl_Total_PC
            // 
            this.lbl_Total_PC.AutoSize = true;
            this.lbl_Total_PC.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_PC.Location = new System.Drawing.Point(1176, 657);
            this.lbl_Total_PC.Name = "lbl_Total_PC";
            this.lbl_Total_PC.Size = new System.Drawing.Size(130, 49);
            this.lbl_Total_PC.TabIndex = 3;
            this.lbl_Total_PC.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(180, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cajero:";
            // 
            // lbl_nombrec_PC
            // 
            this.lbl_nombrec_PC.AutoSize = true;
            this.lbl_nombrec_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PC.Location = new System.Drawing.Point(260, 20);
            this.lbl_nombrec_PC.Name = "lbl_nombrec_PC";
            this.lbl_nombrec_PC.Size = new System.Drawing.Size(176, 21);
            this.lbl_nombrec_PC.TabIndex = 5;
            this.lbl_nombrec_PC.Text = "Nombre Completo";
            // 
            // lbl_tiempo_PC
            // 
            this.lbl_tiempo_PC.AutoSize = true;
            this.lbl_tiempo_PC.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PC.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PC.Location = new System.Drawing.Point(1138, 7);
            this.lbl_tiempo_PC.Name = "lbl_tiempo_PC";
            this.lbl_tiempo_PC.Size = new System.Drawing.Size(112, 47);
            this.lbl_tiempo_PC.TabIndex = 6;
            this.lbl_tiempo_PC.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Num. Caja:";
            // 
            // lbl_numcaja_PC
            // 
            this.lbl_numcaja_PC.AutoSize = true;
            this.lbl_numcaja_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_numcaja_PC.Location = new System.Drawing.Point(126, 20);
            this.lbl_numcaja_PC.Name = "lbl_numcaja_PC";
            this.lbl_numcaja_PC.Size = new System.Drawing.Size(20, 21);
            this.lbl_numcaja_PC.TabIndex = 8;
            this.lbl_numcaja_PC.Text = "1";
            // 
            // horaYfecha
            // 
            this.horaYfecha.Enabled = true;
            this.horaYfecha.Tick += new System.EventHandler(this.horaYfecha_Tick);
            // 
            // lbl_fecha_PC
            // 
            this.lbl_fecha_PC.AutoSize = true;
            this.lbl_fecha_PC.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PC.Location = new System.Drawing.Point(974, 49);
            this.lbl_fecha_PC.Name = "lbl_fecha_PC";
            this.lbl_fecha_PC.Size = new System.Drawing.Size(83, 27);
            this.lbl_fecha_PC.TabIndex = 9;
            this.lbl_fecha_PC.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código del Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre del Producto:";
            // 
            // txt_codigop_PC
            // 
            this.txt_codigop_PC.Location = new System.Drawing.Point(235, 114);
            this.txt_codigop_PC.Name = "txt_codigop_PC";
            this.txt_codigop_PC.Size = new System.Drawing.Size(203, 30);
            this.txt_codigop_PC.TabIndex = 12;
            this.txt_codigop_PC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_nombreP_PC
            // 
            this.txt_nombreP_PC.Location = new System.Drawing.Point(235, 150);
            this.txt_nombreP_PC.Name = "txt_nombreP_PC";
            this.txt_nombreP_PC.Size = new System.Drawing.Size(203, 30);
            this.txt_nombreP_PC.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_busqueda_PC
            // 
            this.dgv_busqueda_PC.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv_busqueda_PC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busqueda_PC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_busqueda_PC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_busqueda_PC.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_busqueda_PC.Location = new System.Drawing.Point(26, 205);
            this.dgv_busqueda_PC.Name = "dgv_busqueda_PC";
            this.dgv_busqueda_PC.RowHeadersWidth = 51;
            this.dgv_busqueda_PC.RowTemplate.Height = 24;
            this.dgv_busqueda_PC.Size = new System.Drawing.Size(544, 231);
            this.dgv_busqueda_PC.TabIndex = 16;
            // 
            // btn_AgregarP_PC
            // 
            this.btn_AgregarP_PC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_AgregarP_PC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_AgregarP_PC.Location = new System.Drawing.Point(195, 453);
            this.btn_AgregarP_PC.Name = "btn_AgregarP_PC";
            this.btn_AgregarP_PC.Size = new System.Drawing.Size(212, 56);
            this.btn_AgregarP_PC.TabIndex = 17;
            this.btn_AgregarP_PC.Text = "Agregar Producto";
            this.btn_AgregarP_PC.UseVisualStyleBackColor = false;
            // 
            // btn_eliminarP_PC
            // 
            this.btn_eliminarP_PC.BackColor = System.Drawing.Color.Crimson;
            this.btn_eliminarP_PC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_eliminarP_PC.Location = new System.Drawing.Point(785, 595);
            this.btn_eliminarP_PC.Name = "btn_eliminarP_PC";
            this.btn_eliminarP_PC.Size = new System.Drawing.Size(209, 49);
            this.btn_eliminarP_PC.TabIndex = 18;
            this.btn_eliminarP_PC.Text = "Eliminar Producto";
            this.btn_eliminarP_PC.UseVisualStyleBackColor = false;
            // 
            // btn_ticket_PC
            // 
            this.btn_ticket_PC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ticket_PC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_ticket_PC.Location = new System.Drawing.Point(1000, 595);
            this.btn_ticket_PC.Name = "btn_ticket_PC";
            this.btn_ticket_PC.Size = new System.Drawing.Size(190, 49);
            this.btn_ticket_PC.TabIndex = 19;
            this.btn_ticket_PC.Text = "Generar Ticket";
            this.btn_ticket_PC.UseVisualStyleBackColor = false;
            this.btn_ticket_PC.Click += new System.EventHandler(this.btn_ticket_PC_Click);
            // 
            // btn_cerrarS_PC
            // 
            this.btn_cerrarS_PC.BackColor = System.Drawing.Color.Maroon;
            this.btn_cerrarS_PC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cerrarS_PC.Location = new System.Drawing.Point(16, 650);
            this.btn_cerrarS_PC.Name = "btn_cerrarS_PC";
            this.btn_cerrarS_PC.Size = new System.Drawing.Size(212, 56);
            this.btn_cerrarS_PC.TabIndex = 20;
            this.btn_cerrarS_PC.Text = "Cerrar Sesión";
            this.btn_cerrarS_PC.UseVisualStyleBackColor = false;
            this.btn_cerrarS_PC.Click += new System.EventHandler(this.btn_cerrarS_PC_Click);
            // 
            // PrincipalCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 714);
            this.Controls.Add(this.btn_cerrarS_PC);
            this.Controls.Add(this.btn_ticket_PC);
            this.Controls.Add(this.btn_eliminarP_PC);
            this.Controls.Add(this.btn_AgregarP_PC);
            this.Controls.Add(this.dgv_busqueda_PC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombreP_PC);
            this.Controls.Add(this.txt_codigop_PC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_fecha_PC);
            this.Controls.Add(this.lbl_numcaja_PC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tiempo_PC);
            this.Controls.Add(this.lbl_nombrec_PC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Total_PC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Lista_PC);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PrincipalCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalCajero";
            this.Load += new System.EventHandler(this.PrincipalCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_PC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_PC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lista_PC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Total_PC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nombrec_PC;
        private System.Windows.Forms.Label lbl_tiempo_PC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_numcaja_PC;
        private System.Windows.Forms.Timer horaYfecha;
        private System.Windows.Forms.Label lbl_fecha_PC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_codigop_PC;
        private System.Windows.Forms.TextBox txt_nombreP_PC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_busqueda_PC;
        private System.Windows.Forms.Button btn_AgregarP_PC;
        private System.Windows.Forms.Button btn_eliminarP_PC;
        private System.Windows.Forms.Button btn_ticket_PC;
        private System.Windows.Forms.Button btn_cerrarS_PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}