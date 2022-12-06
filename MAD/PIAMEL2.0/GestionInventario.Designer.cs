namespace MAD._0
{
    partial class GestionInventario
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_regresar_GP = new System.Windows.Forms.Button();
            this.dgv_Lista_GP = new System.Windows.Forms.DataGridView();
            this.FILTROS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_departamentos_GP = new System.Windows.Forms.ComboBox();
            this.txt_cantidad_GP = new System.Windows.Forms.TextBox();
            this.chb_agotados_GP = new System.Windows.Forms.CheckBox();
            this.chb_merma_GP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_GP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(671, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(83, 27);
            this.lbl_fecha_PA.TabIndex = 17;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(835, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(112, 47);
            this.lbl_tiempo_PA.TabIndex = 16;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(164, 30);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(166, 21);
            this.lbl_nombrec_PA.TabIndex = 15;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_regresar_GP
            // 
            this.btn_regresar_GP.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GP.Location = new System.Drawing.Point(20, 582);
            this.btn_regresar_GP.Name = "btn_regresar_GP";
            this.btn_regresar_GP.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GP.TabIndex = 19;
            this.btn_regresar_GP.Text = "Regresar";
            this.btn_regresar_GP.UseVisualStyleBackColor = false;
            this.btn_regresar_GP.Click += new System.EventHandler(this.btn_regresar_GP_Click);
            // 
            // dgv_Lista_GP
            // 
            this.dgv_Lista_GP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_GP.Location = new System.Drawing.Point(81, 252);
            this.dgv_Lista_GP.Name = "dgv_Lista_GP";
            this.dgv_Lista_GP.RowHeadersWidth = 51;
            this.dgv_Lista_GP.RowTemplate.Height = 24;
            this.dgv_Lista_GP.Size = new System.Drawing.Size(866, 280);
            this.dgv_Lista_GP.TabIndex = 20;
            // 
            // FILTROS
            // 
            this.FILTROS.AutoSize = true;
            this.FILTROS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILTROS.Location = new System.Drawing.Point(90, 116);
            this.FILTROS.Name = "FILTROS";
            this.FILTROS.Size = new System.Drawing.Size(69, 19);
            this.FILTROS.TabIndex = 21;
            this.FILTROS.Text = "FILTROS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad mínima de existencia:";
            // 
            // cb_departamentos_GP
            // 
            this.cb_departamentos_GP.FormattingEnabled = true;
            this.cb_departamentos_GP.Location = new System.Drawing.Point(274, 174);
            this.cb_departamentos_GP.Name = "cb_departamentos_GP";
            this.cb_departamentos_GP.Size = new System.Drawing.Size(218, 29);
            this.cb_departamentos_GP.TabIndex = 26;
            // 
            // txt_cantidad_GP
            // 
            this.txt_cantidad_GP.Location = new System.Drawing.Point(807, 174);
            this.txt_cantidad_GP.Name = "txt_cantidad_GP";
            this.txt_cantidad_GP.Size = new System.Drawing.Size(100, 27);
            this.txt_cantidad_GP.TabIndex = 27;
            // 
            // chb_agotados_GP
            // 
            this.chb_agotados_GP.AutoSize = true;
            this.chb_agotados_GP.Location = new System.Drawing.Point(274, 221);
            this.chb_agotados_GP.Name = "chb_agotados_GP";
            this.chb_agotados_GP.Size = new System.Drawing.Size(205, 25);
            this.chb_agotados_GP.TabIndex = 28;
            this.chb_agotados_GP.Text = "Productos Agotados";
            this.chb_agotados_GP.UseVisualStyleBackColor = true;
            // 
            // chb_merma_GP
            // 
            this.chb_merma_GP.AutoSize = true;
            this.chb_merma_GP.Location = new System.Drawing.Point(535, 221);
            this.chb_merma_GP.Name = "chb_merma_GP";
            this.chb_merma_GP.Size = new System.Drawing.Size(132, 25);
            this.chb_merma_GP.TabIndex = 29;
            this.chb_merma_GP.Text = "Con Merma";
            this.chb_merma_GP.UseVisualStyleBackColor = true;
            // 
            // GestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 650);
            this.Controls.Add(this.chb_merma_GP);
            this.Controls.Add(this.chb_agotados_GP);
            this.Controls.Add(this.txt_cantidad_GP);
            this.Controls.Add(this.cb_departamentos_GP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FILTROS);
            this.Controls.Add(this.dgv_Lista_GP);
            this.Controls.Add(this.btn_regresar_GP);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionInventario";
            this.Load += new System.EventHandler(this.GestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_GP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_regresar_GP;
        private System.Windows.Forms.DataGridView dgv_Lista_GP;
        private System.Windows.Forms.Label FILTROS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_departamentos_GP;
        private System.Windows.Forms.TextBox txt_cantidad_GP;
        private System.Windows.Forms.CheckBox chb_agotados_GP;
        private System.Windows.Forms.CheckBox chb_merma_GP;
    }
}