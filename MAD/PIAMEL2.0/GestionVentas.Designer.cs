﻿namespace MAD._0
{
    partial class GestionVentas
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
            this.btn_regresar_GP = new System.Windows.Forms.Button();
            this.lbl_fecha_PA = new System.Windows.Forms.Label();
            this.lbl_tiempo_PA = new System.Windows.Forms.Label();
            this.lbl_nombrec_PA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_regresar_GP
            // 
            this.btn_regresar_GP.BackColor = System.Drawing.Color.Crimson;
            this.btn_regresar_GP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_regresar_GP.Location = new System.Drawing.Point(33, 361);
            this.btn_regresar_GP.Name = "btn_regresar_GP";
            this.btn_regresar_GP.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar_GP.TabIndex = 24;
            this.btn_regresar_GP.Text = "Regresar";
            this.btn_regresar_GP.UseVisualStyleBackColor = false;
            this.btn_regresar_GP.Click += new System.EventHandler(this.btn_regresar_GP_Click);
            // 
            // lbl_fecha_PA
            // 
            this.lbl_fecha_PA.AutoSize = true;
            this.lbl_fecha_PA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_fecha_PA.Location = new System.Drawing.Point(619, 60);
            this.lbl_fecha_PA.Name = "lbl_fecha_PA";
            this.lbl_fecha_PA.Size = new System.Drawing.Size(83, 27);
            this.lbl_fecha_PA.TabIndex = 23;
            this.lbl_fecha_PA.Text = "Fecha";
            // 
            // lbl_tiempo_PA
            // 
            this.lbl_tiempo_PA.AutoSize = true;
            this.lbl_tiempo_PA.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo_PA.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tiempo_PA.Location = new System.Drawing.Point(783, 18);
            this.lbl_tiempo_PA.Name = "lbl_tiempo_PA";
            this.lbl_tiempo_PA.Size = new System.Drawing.Size(112, 47);
            this.lbl_tiempo_PA.TabIndex = 22;
            this.lbl_tiempo_PA.Text = "Hora";
            // 
            // lbl_nombrec_PA
            // 
            this.lbl_nombrec_PA.AutoSize = true;
            this.lbl_nombrec_PA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombrec_PA.Location = new System.Drawing.Point(185, 40);
            this.lbl_nombrec_PA.Name = "lbl_nombrec_PA";
            this.lbl_nombrec_PA.Size = new System.Drawing.Size(166, 21);
            this.lbl_nombrec_PA.TabIndex = 21;
            this.lbl_nombrec_PA.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(37, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 430);
            this.Controls.Add(this.btn_regresar_GP);
            this.Controls.Add(this.lbl_fecha_PA);
            this.Controls.Add(this.lbl_tiempo_PA);
            this.Controls.Add(this.lbl_nombrec_PA);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "GestionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_GP;
        private System.Windows.Forms.Label lbl_fecha_PA;
        private System.Windows.Forms.Label lbl_tiempo_PA;
        private System.Windows.Forms.Label lbl_nombrec_PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}