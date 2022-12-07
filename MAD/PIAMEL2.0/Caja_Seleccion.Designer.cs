namespace MAD._0
{
    partial class Caja_Seleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja_Seleccion));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Num_SC = new System.Windows.Forms.ComboBox();
            this.btn_aceptar_SC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(133, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la caja:";
            // 
            // cb_Num_SC
            // 
            this.cb_Num_SC.Location = new System.Drawing.Point(293, 62);
            this.cb_Num_SC.Name = "cb_Num_SC";
            this.cb_Num_SC.Size = new System.Drawing.Size(121, 25);
            this.cb_Num_SC.TabIndex = 1;
            // 
            // btn_aceptar_SC
            // 
            this.btn_aceptar_SC.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_aceptar_SC.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_aceptar_SC.Location = new System.Drawing.Point(215, 142);
            this.btn_aceptar_SC.Name = "btn_aceptar_SC";
            this.btn_aceptar_SC.Size = new System.Drawing.Size(111, 33);
            this.btn_aceptar_SC.TabIndex = 2;
            this.btn_aceptar_SC.Text = "Aceptar";
            this.btn_aceptar_SC.UseVisualStyleBackColor = false;
            this.btn_aceptar_SC.Click += new System.EventHandler(this.btn_aceptar_SC_Click);
            // 
            // Caja_Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(552, 217);
            this.Controls.Add(this.btn_aceptar_SC);
            this.Controls.Add(this.cb_Num_SC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Caja_Seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionDeCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Num_SC;
        private System.Windows.Forms.Button btn_aceptar_SC;
    }
}