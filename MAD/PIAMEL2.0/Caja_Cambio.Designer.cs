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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.btn_Guardar_GC = new System.Windows.Forms.Button();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.txt_admin = new System.Windows.Forms.TextBox();
            this.lbl_idcaja = new System.Windows.Forms.Label();
            this.txt_idcaja = new System.Windows.Forms.TextBox();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.lbl_numcaja = new System.Windows.Forms.Label();
            this.lbl_administrador = new System.Windows.Forms.Label();
            this.cb_numcaja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_regresar_GC.Location = new System.Drawing.Point(10, 193);
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
            this.btn_Guardar_GC.Location = new System.Drawing.Point(541, 193);
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
            // txt_admin
            // 
            this.txt_admin.Enabled = false;
            this.txt_admin.Location = new System.Drawing.Point(507, 111);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.ReadOnly = true;
            this.txt_admin.Size = new System.Drawing.Size(116, 23);
            this.txt_admin.TabIndex = 83;
            // 
            // lbl_idcaja
            // 
            this.lbl_idcaja.AutoSize = true;
            this.lbl_idcaja.Location = new System.Drawing.Point(441, 83);
            this.lbl_idcaja.Name = "lbl_idcaja";
            this.lbl_idcaja.Size = new System.Drawing.Size(56, 17);
            this.lbl_idcaja.TabIndex = 82;
            this.lbl_idcaja.Text = "Id Caja";
            // 
            // txt_idcaja
            // 
            this.txt_idcaja.Enabled = false;
            this.txt_idcaja.Location = new System.Drawing.Point(507, 83);
            this.txt_idcaja.Name = "txt_idcaja";
            this.txt_idcaja.ReadOnly = true;
            this.txt_idcaja.Size = new System.Drawing.Size(108, 23);
            this.txt_idcaja.TabIndex = 81;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.Location = new System.Drawing.Point(80, 121);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(129, 17);
            this.lbl_cajero.TabIndex = 80;
            this.lbl_cajero.Text = "Cajero encargado";
            // 
            // lbl_numcaja
            // 
            this.lbl_numcaja.AutoSize = true;
            this.lbl_numcaja.Location = new System.Drawing.Point(141, 88);
            this.lbl_numcaja.Name = "lbl_numcaja";
            this.lbl_numcaja.Size = new System.Drawing.Size(79, 17);
            this.lbl_numcaja.TabIndex = 79;
            this.lbl_numcaja.Text = "Caja Num.";
            // 
            // lbl_administrador
            // 
            this.lbl_administrador.AutoSize = true;
            this.lbl_administrador.Location = new System.Drawing.Point(398, 116);
            this.lbl_administrador.Name = "lbl_administrador";
            this.lbl_administrador.Size = new System.Drawing.Size(98, 17);
            this.lbl_administrador.TabIndex = 78;
            this.lbl_administrador.Text = "Administrador";
            // 
            // cb_numcaja
            // 
            this.cb_numcaja.FormattingEnabled = true;
            this.cb_numcaja.Location = new System.Drawing.Point(230, 83);
            this.cb_numcaja.Name = "cb_numcaja";
            this.cb_numcaja.Size = new System.Drawing.Size(67, 25);
            this.cb_numcaja.TabIndex = 89;
            // 
            // Modificar_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 239);
            this.Controls.Add(this.cb_numcaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.btn_Guardar_GC);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.lbl_idcaja);
            this.Controls.Add(this.txt_idcaja);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_numcaja);
            this.Controls.Add(this.lbl_administrador);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Button btn_Guardar_GC;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.TextBox txt_admin;
        private System.Windows.Forms.Label lbl_idcaja;
        private System.Windows.Forms.TextBox txt_idcaja;
        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.Label lbl_numcaja;
        private System.Windows.Forms.Label lbl_administrador;
        private System.Windows.Forms.ComboBox cb_numcaja;
    }
}