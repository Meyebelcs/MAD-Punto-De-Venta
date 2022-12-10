namespace MAD._0
{
    partial class Modificar_Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Caja));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.btn_Guardar_GC = new System.Windows.Forms.Button();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.lbl_numcaja = new System.Windows.Forms.Label();
            this.cb_numcaja = new System.Windows.Forms.ComboBox();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.txt_admin = new System.Windows.Forms.TextBox();
            this.lbl_administrador = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(313, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "MODIFICAR CAJA";
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(12, 239);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 87;
            this.btn_regresar_GC.Text = "Cancelar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // btn_Guardar_GC
            // 
            this.btn_Guardar_GC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Guardar_GC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar_GC.Location = new System.Drawing.Point(543, 239);
            this.btn_Guardar_GC.Name = "btn_Guardar_GC";
            this.btn_Guardar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_Guardar_GC.TabIndex = 85;
            this.btn_Guardar_GC.Text = "Modificar";
            this.btn_Guardar_GC.UseVisualStyleBackColor = false;
            this.btn_Guardar_GC.Click += new System.EventHandler(this.btn_Guardar_GC_Click);
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(230, 116);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(142, 25);
            this.cbcajero.TabIndex = 84;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cajero.Location = new System.Drawing.Point(80, 121);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(129, 17);
            this.lbl_cajero.TabIndex = 80;
            this.lbl_cajero.Text = "Cajero encargado";
            // 
            // lbl_numcaja
            // 
            this.lbl_numcaja.AutoSize = true;
            this.lbl_numcaja.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_numcaja.Location = new System.Drawing.Point(141, 88);
            this.lbl_numcaja.Name = "lbl_numcaja";
            this.lbl_numcaja.Size = new System.Drawing.Size(79, 17);
            this.lbl_numcaja.TabIndex = 79;
            this.lbl_numcaja.Text = "Caja Num.";
            // 
            // cb_numcaja
            // 
            this.cb_numcaja.FormattingEnabled = true;
            this.cb_numcaja.Location = new System.Drawing.Point(230, 83);
            this.cb_numcaja.Name = "cb_numcaja";
            this.cb_numcaja.Size = new System.Drawing.Size(67, 25);
            this.cb_numcaja.TabIndex = 89;
            this.cb_numcaja.SelectedIndexChanged += new System.EventHandler(this.cb_numcaja_SelectedIndexChanged);
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_ID.Location = new System.Drawing.Point(541, 84);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(64, 17);
            this.LBL_ID.TabIndex = 92;
            this.LBL_ID.Text = "IDADMIN";
            // 
            // txt_admin
            // 
            this.txt_admin.Enabled = false;
            this.txt_admin.Location = new System.Drawing.Point(419, 104);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.ReadOnly = true;
            this.txt_admin.Size = new System.Drawing.Size(207, 23);
            this.txt_admin.TabIndex = 91;
            // 
            // lbl_administrador
            // 
            this.lbl_administrador.AutoSize = true;
            this.lbl_administrador.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_administrador.Location = new System.Drawing.Point(429, 84);
            this.lbl_administrador.Name = "lbl_administrador";
            this.lbl_administrador.Size = new System.Drawing.Size(103, 17);
            this.lbl_administrador.TabIndex = 90;
            this.lbl_administrador.Text = "Lo dió de alta:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(162, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 21);
            this.checkBox2.TabIndex = 94;
            this.checkBox2.Text = "Caja sin cajero";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Modificar_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(708, 290);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.lbl_administrador);
            this.Controls.Add(this.cb_numcaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.btn_Guardar_GC);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_numcaja);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Caja";
            this.Load += new System.EventHandler(this.Modificar_Caja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Button btn_Guardar_GC;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.Label lbl_numcaja;
        private System.Windows.Forms.ComboBox cb_numcaja;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.TextBox txt_admin;
        private System.Windows.Forms.Label lbl_administrador;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}