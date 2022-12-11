namespace PIAMEL2._0
{
    partial class Caja_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja_Alta));
            this.btn_Guardar_GC = new System.Windows.Forms.Button();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.txt_admin = new System.Windows.Forms.TextBox();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.lbl_numcaja = new System.Windows.Forms.Label();
            this.lbl_administrador = new System.Windows.Forms.Label();
            this.txt_numcaja = new System.Windows.Forms.TextBox();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guardar_GC
            // 
            this.btn_Guardar_GC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Guardar_GC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar_GC.Location = new System.Drawing.Point(543, 173);
            this.btn_Guardar_GC.Name = "btn_Guardar_GC";
            this.btn_Guardar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_Guardar_GC.TabIndex = 73;
            this.btn_Guardar_GC.Text = "Guardar";
            this.btn_Guardar_GC.UseVisualStyleBackColor = false;
            this.btn_Guardar_GC.Click += new System.EventHandler(this.btn_Guardar_GC_Click);
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(232, 96);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(142, 25);
            this.cbcajero.TabIndex = 71;
            // 
            // txt_admin
            // 
            this.txt_admin.Enabled = false;
            this.txt_admin.Location = new System.Drawing.Point(418, 91);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.ReadOnly = true;
            this.txt_admin.Size = new System.Drawing.Size(207, 23);
            this.txt_admin.TabIndex = 70;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cajero.Location = new System.Drawing.Point(82, 101);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(129, 17);
            this.lbl_cajero.TabIndex = 67;
            this.lbl_cajero.Text = "Cajero encargado";
            // 
            // lbl_numcaja
            // 
            this.lbl_numcaja.AutoSize = true;
            this.lbl_numcaja.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_numcaja.Location = new System.Drawing.Point(143, 68);
            this.lbl_numcaja.Name = "lbl_numcaja";
            this.lbl_numcaja.Size = new System.Drawing.Size(79, 17);
            this.lbl_numcaja.TabIndex = 66;
            this.lbl_numcaja.Text = "Caja Num.";
            // 
            // lbl_administrador
            // 
            this.lbl_administrador.AutoSize = true;
            this.lbl_administrador.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_administrador.Location = new System.Drawing.Point(428, 71);
            this.lbl_administrador.Name = "lbl_administrador";
            this.lbl_administrador.Size = new System.Drawing.Size(113, 17);
            this.lbl_administrador.TabIndex = 65;
            this.lbl_administrador.Text = "Lo dará de alta:";
            // 
            // txt_numcaja
            // 
            this.txt_numcaja.Location = new System.Drawing.Point(232, 63);
            this.txt_numcaja.Name = "txt_numcaja";
            this.txt_numcaja.Size = new System.Drawing.Size(67, 23);
            this.txt_numcaja.TabIndex = 64;
            this.txt_numcaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numcaja_KeyPress);
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(12, 173);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 75;
            this.btn_regresar_GC.Text = "Cancelar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(315, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "NUEVA CAJA";
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.ForeColor = System.Drawing.Color.Indigo;
            this.LBL_ID.Location = new System.Drawing.Point(540, 71);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(64, 17);
            this.LBL_ID.TabIndex = 77;
            this.LBL_ID.Text = "IDADMIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "opcional";
            // 
            // Caja_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(704, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.btn_Guardar_GC);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_numcaja);
            this.Controls.Add(this.lbl_administrador);
            this.Controls.Add(this.txt_numcaja);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Caja_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaCaja";
            this.TransparencyKey = System.Drawing.Color.LightBlue;
            this.Load += new System.EventHandler(this.Caja_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Guardar_GC;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.TextBox txt_admin;
        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.Label lbl_numcaja;
        private System.Windows.Forms.Label lbl_administrador;
        private System.Windows.Forms.TextBox txt_numcaja;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.Label label1;
    }
}