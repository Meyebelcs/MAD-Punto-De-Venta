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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_opcionP_P = new System.Windows.Forms.ComboBox();
            this.btn_Agregar_P = new System.Windows.Forms.Button();
            this.dgv_Lista_P = new System.Windows.Forms.DataGridView();
            this.lbl_Total_P = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pagar_P = new System.Windows.Forms.Button();
            this.btn_cancelar_P = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_numcaja_PC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombrec_PC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_fecha_PC = new System.Windows.Forms.Label();
            this.lbl_tiempo_PC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.montopagar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_P)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la opción de pago:";
            // 
            // cb_opcionP_P
            // 
            this.cb_opcionP_P.FormattingEnabled = true;
            this.cb_opcionP_P.Location = new System.Drawing.Point(283, 157);
            this.cb_opcionP_P.Name = "cb_opcionP_P";
            this.cb_opcionP_P.Size = new System.Drawing.Size(261, 25);
            this.cb_opcionP_P.TabIndex = 1;
            // 
            // btn_Agregar_P
            // 
            this.btn_Agregar_P.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Agregar_P.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Agregar_P.Location = new System.Drawing.Point(575, 151);
            this.btn_Agregar_P.Name = "btn_Agregar_P";
            this.btn_Agregar_P.Size = new System.Drawing.Size(114, 38);
            this.btn_Agregar_P.TabIndex = 2;
            this.btn_Agregar_P.Text = "Agregar";
            this.btn_Agregar_P.UseVisualStyleBackColor = false;
            this.btn_Agregar_P.Click += new System.EventHandler(this.btn_Agregar_P_Click);
            // 
            // dgv_Lista_P
            // 
            this.dgv_Lista_P.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_Lista_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista_P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_P.Location = new System.Drawing.Point(45, 255);
            this.dgv_Lista_P.Name = "dgv_Lista_P";
            this.dgv_Lista_P.RowHeadersWidth = 51;
            this.dgv_Lista_P.RowTemplate.Height = 24;
            this.dgv_Lista_P.Size = new System.Drawing.Size(478, 177);
            this.dgv_Lista_P.TabIndex = 3;
            this.dgv_Lista_P.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_P_CellEndEdit);
            // 
            // lbl_Total_P
            // 
            this.lbl_Total_P.AutoSize = true;
            this.lbl_Total_P.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_P.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Total_P.Location = new System.Drawing.Point(600, 513);
            this.lbl_Total_P.Name = "lbl_Total_P";
            this.lbl_Total_P.Size = new System.Drawing.Size(88, 41);
            this.lbl_Total_P.TabIndex = 9;
            this.lbl_Total_P.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(443, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL:";
            // 
            // btn_pagar_P
            // 
            this.btn_pagar_P.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_pagar_P.ForeColor = System.Drawing.Color.White;
            this.btn_pagar_P.Location = new System.Drawing.Point(196, 493);
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
            this.btn_cancelar_P.Location = new System.Drawing.Point(45, 493);
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
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(42, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresa la cantidad a pagar con esta opción:";
            // 
            // lbl_numcaja_PC
            // 
            this.lbl_numcaja_PC.AutoSize = true;
            this.lbl_numcaja_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_numcaja_PC.Location = new System.Drawing.Point(128, 18);
            this.lbl_numcaja_PC.Name = "lbl_numcaja_PC";
            this.lbl_numcaja_PC.Size = new System.Drawing.Size(15, 17);
            this.lbl_numcaja_PC.TabIndex = 16;
            this.lbl_numcaja_PC.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Num. Caja:";
            // 
            // lbl_nombrec_PC
            // 
            this.lbl_nombrec_PC.AutoSize = true;
            this.lbl_nombrec_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PC.Location = new System.Drawing.Point(262, 18);
            this.lbl_nombrec_PC.Name = "lbl_nombrec_PC";
            this.lbl_nombrec_PC.Size = new System.Drawing.Size(119, 17);
            this.lbl_nombrec_PC.TabIndex = 14;
            this.lbl_nombrec_PC.Text = "Nombre Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(182, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cajero:";
            // 
            // lbl_fecha_PC
            // 
            this.lbl_fecha_PC.AutoSize = true;
            this.lbl_fecha_PC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PC.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PC.Location = new System.Drawing.Point(482, 53);
            this.lbl_fecha_PC.Name = "lbl_fecha_PC";
            this.lbl_fecha_PC.Size = new System.Drawing.Size(53, 19);
            this.lbl_fecha_PC.TabIndex = 18;
            this.lbl_fecha_PC.Text = "Fecha";
            // 
            // lbl_tiempo_PC
            // 
            this.lbl_tiempo_PC.AutoSize = true;
            this.lbl_tiempo_PC.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PC.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PC.Location = new System.Drawing.Point(577, 9);
            this.lbl_tiempo_PC.Name = "lbl_tiempo_PC";
            this.lbl_tiempo_PC.Size = new System.Drawing.Size(86, 37);
            this.lbl_tiempo_PC.TabIndex = 17;
            this.lbl_tiempo_PC.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // montopagar
            // 
            this.montopagar.AutoSize = true;
            this.montopagar.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montopagar.ForeColor = System.Drawing.Color.Indigo;
            this.montopagar.Location = new System.Drawing.Point(543, 391);
            this.montopagar.Name = "montopagar";
            this.montopagar.Size = new System.Drawing.Size(108, 41);
            this.montopagar.TabIndex = 19;
            this.montopagar.Text = "$0.00";
            this.montopagar.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(568, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 41);
            this.label8.TabIndex = 20;
            this.label8.Text = "$";
            // 
            // tp_fechaIngreso
            // 
            this.tp_fechaIngreso.CustomFormat = "yyyy-MM-dd/h:m:s";
            this.tp_fechaIngreso.Enabled = false;
            this.tp_fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tp_fechaIngreso.Location = new System.Drawing.Point(44, 113);
            this.tp_fechaIngreso.Name = "tp_fechaIngreso";
            this.tp_fechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.tp_fechaIngreso.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(41, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 95;
            this.label12.Text = "Fecha de Ingreso:";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(758, 584);
            this.Controls.Add(this.tp_fechaIngreso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.montopagar);
            this.Controls.Add(this.lbl_fecha_PC);
            this.Controls.Add(this.lbl_tiempo_PC);
            this.Controls.Add(this.lbl_numcaja_PC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_nombrec_PC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar_P);
            this.Controls.Add(this.btn_pagar_P);
            this.Controls.Add(this.lbl_Total_P);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Lista_P);
            this.Controls.Add(this.btn_Agregar_P);
            this.Controls.Add(this.cb_opcionP_P);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lbl_Total_P;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pagar_P;
        private System.Windows.Forms.Button btn_cancelar_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_numcaja_PC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_nombrec_PC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_fecha_PC;
        private System.Windows.Forms.Label lbl_tiempo_PC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label montopagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tp_fechaIngreso;
        private System.Windows.Forms.Label label12;
    }
}