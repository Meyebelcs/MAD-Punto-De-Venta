namespace PIAMEL2._0
{
    partial class Caja_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja_Baja));
            this.cb_numcaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar_GC = new System.Windows.Forms.Button();
            this.btn_Eliminar_GC = new System.Windows.Forms.Button();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.txt_admin = new System.Windows.Forms.TextBox();
            this.lbl_idcaja = new System.Windows.Forms.Label();
            this.txt_idcaja = new System.Windows.Forms.TextBox();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.lbl_numcaja = new System.Windows.Forms.Label();
            this.lbl_administrador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_numcaja
            // 
            this.cb_numcaja.FormattingEnabled = true;
            this.cb_numcaja.Location = new System.Drawing.Point(239, 84);
            this.cb_numcaja.Name = "cb_numcaja";
            this.cb_numcaja.Size = new System.Drawing.Size(67, 25);
            this.cb_numcaja.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(322, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "ELIMINAR CAJA";
            // 
            // btn_regresar_GC
            // 
            this.btn_regresar_GC.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GC.Location = new System.Drawing.Point(19, 194);
            this.btn_regresar_GC.Name = "btn_regresar_GC";
            this.btn_regresar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GC.TabIndex = 98;
            this.btn_regresar_GC.Text = "Cancelar";
            this.btn_regresar_GC.UseVisualStyleBackColor = false;
            this.btn_regresar_GC.Click += new System.EventHandler(this.btn_regresar_GC_Click);
            // 
            // btn_Eliminar_GC
            // 
            this.btn_Eliminar_GC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Eliminar_GC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar_GC.Location = new System.Drawing.Point(550, 194);
            this.btn_Eliminar_GC.Name = "btn_Eliminar_GC";
            this.btn_Eliminar_GC.Size = new System.Drawing.Size(147, 39);
            this.btn_Eliminar_GC.TabIndex = 97;
            this.btn_Eliminar_GC.Text = "Eliminar";
            this.btn_Eliminar_GC.UseVisualStyleBackColor = false;
            this.btn_Eliminar_GC.Click += new System.EventHandler(this.btn_Eliminar_GC_Click);
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(239, 117);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(142, 25);
            this.cbcajero.TabIndex = 96;
            // 
            // txt_admin
            // 
            this.txt_admin.Enabled = false;
            this.txt_admin.Location = new System.Drawing.Point(516, 112);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.ReadOnly = true;
            this.txt_admin.Size = new System.Drawing.Size(116, 23);
            this.txt_admin.TabIndex = 95;
            // 
            // lbl_idcaja
            // 
            this.lbl_idcaja.AutoSize = true;
            this.lbl_idcaja.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_idcaja.Location = new System.Drawing.Point(450, 84);
            this.lbl_idcaja.Name = "lbl_idcaja";
            this.lbl_idcaja.Size = new System.Drawing.Size(56, 17);
            this.lbl_idcaja.TabIndex = 94;
            this.lbl_idcaja.Text = "Id Caja";
            // 
            // txt_idcaja
            // 
            this.txt_idcaja.Enabled = false;
            this.txt_idcaja.Location = new System.Drawing.Point(516, 84);
            this.txt_idcaja.Name = "txt_idcaja";
            this.txt_idcaja.ReadOnly = true;
            this.txt_idcaja.Size = new System.Drawing.Size(108, 23);
            this.txt_idcaja.TabIndex = 93;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_cajero.Location = new System.Drawing.Point(89, 122);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(129, 17);
            this.lbl_cajero.TabIndex = 92;
            this.lbl_cajero.Text = "Cajero encargado";
            // 
            // lbl_numcaja
            // 
            this.lbl_numcaja.AutoSize = true;
            this.lbl_numcaja.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_numcaja.Location = new System.Drawing.Point(150, 89);
            this.lbl_numcaja.Name = "lbl_numcaja";
            this.lbl_numcaja.Size = new System.Drawing.Size(79, 17);
            this.lbl_numcaja.TabIndex = 91;
            this.lbl_numcaja.Text = "Caja Num.";
            // 
            // lbl_administrador
            // 
            this.lbl_administrador.AutoSize = true;
            this.lbl_administrador.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_administrador.Location = new System.Drawing.Point(407, 117);
            this.lbl_administrador.Name = "lbl_administrador";
            this.lbl_administrador.Size = new System.Drawing.Size(98, 17);
            this.lbl_administrador.TabIndex = 90;
            this.lbl_administrador.Text = "Administrador";
            // 
            // Caja_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(717, 246);
            this.Controls.Add(this.cb_numcaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar_GC);
            this.Controls.Add(this.btn_Eliminar_GC);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.lbl_idcaja);
            this.Controls.Add(this.txt_idcaja);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_numcaja);
            this.Controls.Add(this.lbl_administrador);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Caja_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_numcaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_regresar_GC;
        private System.Windows.Forms.Button btn_Eliminar_GC;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.TextBox txt_admin;
        private System.Windows.Forms.Label lbl_idcaja;
        private System.Windows.Forms.TextBox txt_idcaja;
        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.Label lbl_numcaja;
        private System.Windows.Forms.Label lbl_administrador;
    }
}