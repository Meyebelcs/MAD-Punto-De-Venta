namespace MAD._0
{
    partial class GestionDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDescuentos));
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_devoluciones = new System.Windows.Forms.DataGridView();
            this.btn_EProducto = new System.Windows.Forms.Button();
            this.btn_MProducto = new System.Windows.Forms.Button();
            this.btn_NProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(604, 51);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(68, 22);
            this.lbl_fecha_PA.TabIndex = 17;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(768, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 16;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(170, 31);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(132, 17);
            this.lbl_nombrec_PA.TabIndex = 15;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrador:";
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(26, 488);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 19;
            this.btn_regresar_GC.Text = "Regresar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_devoluciones
            // 
            this.dgv_devoluciones.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devoluciones.Location = new System.Drawing.Point(256, 140);
            this.dgv_devoluciones.Name = "dgv_devoluciones";
            this.dgv_devoluciones.RowHeadersWidth = 51;
            this.dgv_devoluciones.RowTemplate.Height = 24;
            this.dgv_devoluciones.Size = new System.Drawing.Size(602, 280);
            this.dgv_devoluciones.TabIndex = 20;
            // 
            // btn_EProducto
            // 
            this.btn_EProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EProducto.Location = new System.Drawing.Point(26, 369);
            this.btn_EProducto.Name = "btn_EProducto";
            this.btn_EProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_EProducto.TabIndex = 28;
            this.btn_EProducto.Text = "Eliminar Descuento";
            this.btn_EProducto.UseVisualStyleBackColor = false;
            // 
            // btn_MProducto
            // 
            this.btn_MProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MProducto.Location = new System.Drawing.Point(26, 240);
            this.btn_MProducto.Name = "btn_MProducto";
            this.btn_MProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_MProducto.TabIndex = 27;
            this.btn_MProducto.Text = "Modificar Descuento";
            this.btn_MProducto.UseVisualStyleBackColor = false;
            // 
            // btn_NProducto
            // 
            this.btn_NProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NProducto.Location = new System.Drawing.Point(26, 120);
            this.btn_NProducto.Name = "btn_NProducto";
            this.btn_NProducto.Size = new System.Drawing.Size(147, 76);
            this.btn_NProducto.TabIndex = 26;
            this.btn_NProducto.Text = "Nuevo Descuento";
            this.btn_NProducto.UseVisualStyleBackColor = false;
            // 
            // GestionDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(926, 556);
            this.Controls.Add(this.btn_EProducto);
            this.Controls.Add(this.btn_MProducto);
            this.Controls.Add(this.btn_NProducto);
            this.Controls.Add(this.dgv_devoluciones);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDescuentos";
            this.Load += new System.EventHandler(this.GestionDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_devoluciones;
        private System.Windows.Forms.Button btn_EProducto;
        private System.Windows.Forms.Button btn_MProducto;
        private System.Windows.Forms.Button btn_NProducto;
    }
}