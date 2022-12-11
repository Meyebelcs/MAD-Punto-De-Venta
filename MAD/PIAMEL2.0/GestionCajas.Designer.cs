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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCajas));
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
            this.chb_sincajero = new System.Windows.Forms.CheckBox();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.txt_admin = new System.Windows.Forms.TextBox();
            this.lbl_administrador = new System.Windows.Forms.Label();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.lbl_numcaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.LBL_IDCAJA = new System.Windows.Forms.Label();
            this.lblb_idempleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cajasinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.Indigo;
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
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.Indigo;
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
            this.dgv_cajasinfo.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_cajasinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cajasinfo.Location = new System.Drawing.Point(32, 115);
            this.dgv_cajasinfo.Name = "dgv_cajasinfo";
            this.dgv_cajasinfo.Size = new System.Drawing.Size(272, 233);
            this.dgv_cajasinfo.TabIndex = 19;
            this.dgv_cajasinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cajasinfo_CellClick);
            // 
            // btn_NCaja
            // 
            this.btn_NCaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NCaja.Location = new System.Drawing.Point(667, 96);
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
            this.btn_ECaja.Location = new System.Drawing.Point(514, 373);
            this.btn_ECaja.Name = "btn_ECaja";
            this.btn_ECaja.Size = new System.Drawing.Size(147, 39);
            this.btn_ECaja.TabIndex = 25;
            this.btn_ECaja.Text = "Eliminar";
            this.btn_ECaja.UseVisualStyleBackColor = false;
            this.btn_ECaja.Click += new System.EventHandler(this.btn_ECaja_Click);
            // 
            // btn_MCaja
            // 
            this.btn_MCaja.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MCaja.Location = new System.Drawing.Point(667, 372);
            this.btn_MCaja.Name = "btn_MCaja";
            this.btn_MCaja.Size = new System.Drawing.Size(147, 40);
            this.btn_MCaja.TabIndex = 26;
            this.btn_MCaja.Text = "Modificar";
            this.btn_MCaja.UseVisualStyleBackColor = false;
            this.btn_MCaja.Click += new System.EventHandler(this.btn_MCaja_Click);
            // 
            // chb_sincajero
            // 
            this.chb_sincajero.AutoSize = true;
            this.chb_sincajero.Location = new System.Drawing.Point(422, 301);
            this.chb_sincajero.Name = "chb_sincajero";
            this.chb_sincajero.Size = new System.Drawing.Size(131, 23);
            this.chb_sincajero.TabIndex = 103;
            this.chb_sincajero.Text = "Caja sin cajero";
            this.chb_sincajero.UseVisualStyleBackColor = true;
            this.chb_sincajero.CheckedChanged += new System.EventHandler(this.chb_sincajero_CheckedChanged);
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_ID.Location = new System.Drawing.Point(511, 158);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(67, 19);
            this.LBL_ID.TabIndex = 102;
            this.LBL_ID.Text = "IDADMIN";
            // 
            // txt_admin
            // 
            this.txt_admin.Enabled = false;
            this.txt_admin.Location = new System.Drawing.Point(389, 178);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.ReadOnly = true;
            this.txt_admin.Size = new System.Drawing.Size(207, 24);
            this.txt_admin.TabIndex = 101;
            // 
            // lbl_administrador
            // 
            this.lbl_administrador.AutoSize = true;
            this.lbl_administrador.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_administrador.Location = new System.Drawing.Point(399, 158);
            this.lbl_administrador.Name = "lbl_administrador";
            this.lbl_administrador.Size = new System.Drawing.Size(109, 19);
            this.lbl_administrador.TabIndex = 100;
            this.lbl_administrador.Text = "Lo dió de alta:";
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(490, 260);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(142, 27);
            this.cbcajero.TabIndex = 97;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cajero.Location = new System.Drawing.Point(340, 265);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(138, 19);
            this.lbl_cajero.TabIndex = 96;
            this.lbl_cajero.Text = "Cajero encargado";
            // 
            // lbl_numcaja
            // 
            this.lbl_numcaja.AutoSize = true;
            this.lbl_numcaja.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_numcaja.Location = new System.Drawing.Point(401, 232);
            this.lbl_numcaja.Name = "lbl_numcaja";
            this.lbl_numcaja.Size = new System.Drawing.Size(83, 19);
            this.lbl_numcaja.TabIndex = 95;
            this.lbl_numcaja.Text = "Caja Num.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "Selecciona una caja:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(490, 227);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 24);
            this.txt_num.TabIndex = 105;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // LBL_IDCAJA
            // 
            this.LBL_IDCAJA.AutoSize = true;
            this.LBL_IDCAJA.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_IDCAJA.Location = new System.Drawing.Point(724, 305);
            this.LBL_IDCAJA.Name = "LBL_IDCAJA";
            this.LBL_IDCAJA.Size = new System.Drawing.Size(58, 19);
            this.LBL_IDCAJA.TabIndex = 106;
            this.LBL_IDCAJA.Text = "IDCAJA";
            this.LBL_IDCAJA.Visible = false;
            // 
            // lblb_idempleado
            // 
            this.lblb_idempleado.AutoSize = true;
            this.lblb_idempleado.ForeColor = System.Drawing.Color.Indigo;
            this.lblb_idempleado.Location = new System.Drawing.Point(724, 286);
            this.lblb_idempleado.Name = "lblb_idempleado";
            this.lblb_idempleado.Size = new System.Drawing.Size(109, 19);
            this.lblb_idempleado.TabIndex = 107;
            this.lblb_idempleado.Text = "NoTieneCajero";
            this.lblb_idempleado.Visible = false;
            // 
            // GestionCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(857, 445);
            this.Controls.Add(this.lblb_idempleado);
            this.Controls.Add(this.LBL_IDCAJA);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chb_sincajero);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.lbl_administrador);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_numcaja);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.CheckBox chb_sincajero;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.TextBox txt_admin;
        private System.Windows.Forms.Label lbl_administrador;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.Label lbl_numcaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label LBL_IDCAJA;
        private System.Windows.Forms.Label lblb_idempleado;
    }
}