﻿namespace PIAMEL2._0
{
    partial class ReporteVentas //MISMO NOMBRE QUE LA VENTANA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentas));
            this.Consultar = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.DG_REPORTEVENTAS = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnoDepa = new System.Windows.Forms.CheckBox();
            this.TodoDepa = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TodosCajeros = new System.Windows.Forms.CheckBox();
            this.IdCajero = new System.Windows.Forms.TextBox();
            this.UnCajero = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateInicio = new System.Windows.Forms.DateTimePicker();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_REPORTEVENTAS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.DarkBlue;
            this.Consultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.Consultar.Location = new System.Drawing.Point(13, 141);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(100, 30);
            this.Consultar.TabIndex = 27;
            this.Consultar.Text = "Reporte";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.Crimson;
            this.GoBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.ForeColor = System.Drawing.Color.GhostWhite;
            this.GoBack.Location = new System.Drawing.Point(13, 450);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(114, 37);
            this.GoBack.TabIndex = 26;
            this.GoBack.Text = "Regresar";
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // DG_REPORTEVENTAS
            // 
            this.DG_REPORTEVENTAS.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.DG_REPORTEVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_REPORTEVENTAS.Location = new System.Drawing.Point(13, 187);
            this.DG_REPORTEVENTAS.Name = "DG_REPORTEVENTAS";
            this.DG_REPORTEVENTAS.Size = new System.Drawing.Size(689, 252);
            this.DG_REPORTEVENTAS.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdDepartamento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.UnoDepa);
            this.groupBox2.Controls.Add(this.TodoDepa);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(502, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departamentos:";
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.Location = new System.Drawing.Point(70, 66);
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.Size = new System.Drawing.Size(124, 23);
            this.IdDepartamento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Escriba ID:";
            // 
            // UnoDepa
            // 
            this.UnoDepa.AutoSize = true;
            this.UnoDepa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnoDepa.Location = new System.Drawing.Point(7, 46);
            this.UnoDepa.Name = "UnoDepa";
            this.UnoDepa.Size = new System.Drawing.Size(110, 20);
            this.UnoDepa.TabIndex = 1;
            this.UnoDepa.Text = "Solamente Uno";
            this.UnoDepa.UseVisualStyleBackColor = true;
            this.UnoDepa.CheckedChanged += new System.EventHandler(this.UnoDepa_CheckedChanged);
            // 
            // TodoDepa
            // 
            this.TodoDepa.AutoSize = true;
            this.TodoDepa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoDepa.Location = new System.Drawing.Point(7, 23);
            this.TodoDepa.Name = "TodoDepa";
            this.TodoDepa.Size = new System.Drawing.Size(58, 20);
            this.TodoDepa.TabIndex = 0;
            this.TodoDepa.Text = "Todos";
            this.TodoDepa.UseVisualStyleBackColor = true;
            this.TodoDepa.CheckedChanged += new System.EventHandler(this.TodoDepa_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TodosCajeros);
            this.groupBox1.Controls.Add(this.IdCajero);
            this.groupBox1.Controls.Add(this.UnCajero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(295, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajeros:";
            // 
            // TodosCajeros
            // 
            this.TodosCajeros.AutoSize = true;
            this.TodosCajeros.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodosCajeros.ForeColor = System.Drawing.Color.Indigo;
            this.TodosCajeros.Location = new System.Drawing.Point(10, 22);
            this.TodosCajeros.Name = "TodosCajeros";
            this.TodosCajeros.Size = new System.Drawing.Size(58, 20);
            this.TodosCajeros.TabIndex = 8;
            this.TodosCajeros.Text = "Todos";
            this.TodosCajeros.UseVisualStyleBackColor = true;
            this.TodosCajeros.CheckedChanged += new System.EventHandler(this.TodosCajeros_CheckedChanged);
            // 
            // IdCajero
            // 
            this.IdCajero.Location = new System.Drawing.Point(70, 64);
            this.IdCajero.Name = "IdCajero";
            this.IdCajero.Size = new System.Drawing.Size(124, 23);
            this.IdCajero.TabIndex = 11;
            // 
            // UnCajero
            // 
            this.UnCajero.AutoSize = true;
            this.UnCajero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnCajero.ForeColor = System.Drawing.Color.Indigo;
            this.UnCajero.Location = new System.Drawing.Point(10, 44);
            this.UnCajero.Name = "UnCajero";
            this.UnCajero.Size = new System.Drawing.Size(110, 20);
            this.UnCajero.TabIndex = 9;
            this.UnCajero.Text = "Solamente Uno";
            this.UnCajero.UseVisualStyleBackColor = true;
            this.UnCajero.CheckedChanged += new System.EventHandler(this.UnCajero_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Escriba ID:";
            // 
            // DateInicio
            // 
            this.DateInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicio.Location = new System.Drawing.Point(62, 76);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(217, 21);
            this.DateInicio.TabIndex = 22;
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Location = new System.Drawing.Point(62, 103);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(217, 21);
            this.DateFinal.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rango Fechas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtros: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(625, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.DG_REPORTEVENTAS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateInicio);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentas";
            this.Text = "ReporteVentas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_REPORTEVENTAS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.DataGridView DG_REPORTEVENTAS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox UnoDepa;
        private System.Windows.Forms.CheckBox TodoDepa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TodosCajeros;
        private System.Windows.Forms.TextBox IdCajero;
        private System.Windows.Forms.CheckBox UnCajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateInicio;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}