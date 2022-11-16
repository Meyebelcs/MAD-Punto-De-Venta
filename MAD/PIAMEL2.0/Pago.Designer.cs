namespace MAD._0
{
    partial class Pago
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_opcionP_P = new System.Windows.Forms.ComboBox();
            this.btn_Agregar_P = new System.Windows.Forms.Button();
            this.dgv_Lista_P = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_efectivo_P = new System.Windows.Forms.Label();
            this.lbl_cambio_P = new System.Windows.Forms.Label();
            this.lbl_Total_P = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pagar_P = new System.Windows.Forms.Button();
            this.btn_cancelar_P = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_P)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la opción de pago:";
            // 
            // cb_opcionP_P
            // 
            this.cb_opcionP_P.FormattingEnabled = true;
            this.cb_opcionP_P.Location = new System.Drawing.Point(290, 47);
            this.cb_opcionP_P.Name = "cb_opcionP_P";
            this.cb_opcionP_P.Size = new System.Drawing.Size(261, 28);
            this.cb_opcionP_P.TabIndex = 1;
            // 
            // btn_Agregar_P
            // 
            this.btn_Agregar_P.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Agregar_P.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Agregar_P.Location = new System.Drawing.Point(582, 41);
            this.btn_Agregar_P.Name = "btn_Agregar_P";
            this.btn_Agregar_P.Size = new System.Drawing.Size(114, 38);
            this.btn_Agregar_P.TabIndex = 2;
            this.btn_Agregar_P.Text = "Agregar";
            this.btn_Agregar_P.UseVisualStyleBackColor = false;
            // 
            // dgv_Lista_P
            // 
            this.dgv_Lista_P.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Lista_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista_P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_P.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad});
            this.dgv_Lista_P.Location = new System.Drawing.Point(52, 145);
            this.dgv_Lista_P.Name = "dgv_Lista_P";
            this.dgv_Lista_P.RowHeadersWidth = 51;
            this.dgv_Lista_P.RowTemplate.Height = 24;
            this.dgv_Lista_P.Size = new System.Drawing.Size(478, 177);
            this.dgv_Lista_P.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pago en efectivo:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cambio:";
            this.label3.Visible = false;
            // 
            // lbl_efectivo_P
            // 
            this.lbl_efectivo_P.AutoSize = true;
            this.lbl_efectivo_P.Location = new System.Drawing.Point(669, 338);
            this.lbl_efectivo_P.Name = "lbl_efectivo_P";
            this.lbl_efectivo_P.Size = new System.Drawing.Size(61, 20);
            this.lbl_efectivo_P.TabIndex = 6;
            this.lbl_efectivo_P.Text = "$100.00";
            this.lbl_efectivo_P.Visible = false;
            // 
            // lbl_cambio_P
            // 
            this.lbl_cambio_P.AutoSize = true;
            this.lbl_cambio_P.Location = new System.Drawing.Point(669, 370);
            this.lbl_cambio_P.Name = "lbl_cambio_P";
            this.lbl_cambio_P.Size = new System.Drawing.Size(45, 20);
            this.lbl_cambio_P.TabIndex = 7;
            this.lbl_cambio_P.Text = "$5.00";
            this.lbl_cambio_P.Visible = false;
            // 
            // lbl_Total_P
            // 
            this.lbl_Total_P.AutoSize = true;
            this.lbl_Total_P.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_P.Location = new System.Drawing.Point(601, 402);
            this.lbl_Total_P.Name = "lbl_Total_P";
            this.lbl_Total_P.Size = new System.Drawing.Size(130, 49);
            this.lbl_Total_P.TabIndex = 9;
            this.lbl_Total_P.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 49);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL:";
            // 
            // btn_pagar_P
            // 
            this.btn_pagar_P.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_pagar_P.ForeColor = System.Drawing.Color.White;
            this.btn_pagar_P.Location = new System.Drawing.Point(203, 383);
            this.btn_pagar_P.Name = "btn_pagar_P";
            this.btn_pagar_P.Size = new System.Drawing.Size(145, 59);
            this.btn_pagar_P.TabIndex = 10;
            this.btn_pagar_P.Text = "Pagar";
            this.btn_pagar_P.UseVisualStyleBackColor = false;
            this.btn_pagar_P.Click += new System.EventHandler(this.btn_pagar_P_Click);
            // 
            // btn_cancelar_P
            // 
            this.btn_cancelar_P.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar_P.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar_P.Location = new System.Drawing.Point(52, 383);
            this.btn_cancelar_P.Name = "btn_cancelar_P";
            this.btn_cancelar_P.Size = new System.Drawing.Size(145, 59);
            this.btn_cancelar_P.TabIndex = 11;
            this.btn_cancelar_P.Text = "Cancelar";
            this.btn_cancelar_P.UseVisualStyleBackColor = false;
            this.btn_cancelar_P.Click += new System.EventHandler(this.btn_cancelar_P_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresa la cantidad a pagar con esta opción:";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar_P);
            this.Controls.Add(this.btn_pagar_P);
            this.Controls.Add(this.lbl_Total_P);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_cambio_P);
            this.Controls.Add(this.lbl_efectivo_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Lista_P);
            this.Controls.Add(this.btn_Agregar_P);
            this.Controls.Add(this.cb_opcionP_P);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_opcionP_P;
        private System.Windows.Forms.Button btn_Agregar_P;
        private System.Windows.Forms.DataGridView dgv_Lista_P;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_efectivo_P;
        private System.Windows.Forms.Label lbl_cambio_P;
        private System.Windows.Forms.Label lbl_Total_P;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pagar_P;
        private System.Windows.Forms.Button btn_cancelar_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}