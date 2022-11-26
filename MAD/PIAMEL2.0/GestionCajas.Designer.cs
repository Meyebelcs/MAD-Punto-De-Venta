namespace MAD._0
{
    partial class GestionCajas
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
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.dgv_cajasinfo = new System.Windows.Forms.DataGridView();
            this.btn_NCaja = new System.Windows.Forms.Button();
            this.btn_ECaja = new System.Windows.Forms.Button();
            this.btn_MCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cajasinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(515, 51);
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
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(679, 9);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(90, 38);
            this.lbl_tiempo_PA.TabIndex = 16;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(178, 31);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(137, 19);
            this.lbl_nombrec_PA.TabIndex = 15;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(30, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(32, 372);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 18;
            this.btn_regresar_GC.Text = "Regresar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // dgv_cajasinfo
            // 
            this.dgv_cajasinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cajasinfo.Location = new System.Drawing.Point(240, 129);
            this.dgv_cajasinfo.Name = "dgv_cajasinfo";
            this.dgv_cajasinfo.Size = new System.Drawing.Size(576, 205);
            this.dgv_cajasinfo.TabIndex = 19;
            // 
            // btn_NCaja
            // 
            this.btn_NCaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NCaja.Location = new System.Drawing.Point(33, 74);
            this.btn_NCaja.Name = "btn_NCaja";
            this.btn_NCaja.Size = new System.Drawing.Size(147, 76);
            this.btn_NCaja.TabIndex = 24;
            this.btn_NCaja.Text = "Nueva Caja";
            this.btn_NCaja.UseVisualStyleBackColor = false;
            this.btn_NCaja.Click += new System.EventHandler(this.btn_NCaja_Click);
            // 
            // btn_ECaja
            // 
            this.btn_ECaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ECaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ECaja.Location = new System.Drawing.Point(32, 277);
            this.btn_ECaja.Name = "btn_ECaja";
            this.btn_ECaja.Size = new System.Drawing.Size(147, 76);
            this.btn_ECaja.TabIndex = 25;
            this.btn_ECaja.Text = "Eliminar Caja";
            this.btn_ECaja.UseVisualStyleBackColor = false;
            this.btn_ECaja.Click += new System.EventHandler(this.btn_ECaja_Click);
            // 
            // btn_MCaja
            // 
            this.btn_MCaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MCaja.Location = new System.Drawing.Point(33, 175);
            this.btn_MCaja.Name = "btn_MCaja";
            this.btn_MCaja.Size = new System.Drawing.Size(147, 76);
            this.btn_MCaja.TabIndex = 26;
            this.btn_MCaja.Text = "Modificar Caja";
            this.btn_MCaja.UseVisualStyleBackColor = false;
            this.btn_MCaja.Click += new System.EventHandler(this.btn_MCaja_Click);
            // 
            // GestionCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 428);
            this.Controls.Add(this.btn_MCaja);
            this.Controls.Add(this.btn_ECaja);
            this.Controls.Add(this.btn_NCaja);
            this.Controls.Add(this.dgv_cajasinfo);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GestionCajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCajas";
            this.Load += new System.EventHandler(this.GestionCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cajasinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.DataGridView dgv_cajasinfo;
        private System.Windows.Forms.Button btn_NCaja;
        private System.Windows.Forms.Button btn_ECaja;
        private System.Windows.Forms.Button btn_MCaja;
    }
}