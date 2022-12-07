
namespace PIAMEL2._0
{
    partial class ReporteCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteCajero));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.DateInicio = new System.Windows.Forms.DateTimePicker();
            this.TodosCajeros = new System.Windows.Forms.CheckBox();
            this.UnCajero = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdCajero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IdDepartamento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GoBack = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rango Fechas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasta:";
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Location = new System.Drawing.Point(78, 110);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(217, 21);
            this.DateFinal.TabIndex = 5;
            // 
            // DateInicio
            // 
            this.DateInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicio.Location = new System.Drawing.Point(78, 83);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(217, 21);
            this.DateInicio.TabIndex = 6;
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
            // IdCajero
            // 
            this.IdCajero.Location = new System.Drawing.Point(70, 64);
            this.IdCajero.Name = "IdCajero";
            this.IdCajero.Size = new System.Drawing.Size(124, 23);
            this.IdCajero.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TodosCajeros);
            this.groupBox1.Controls.Add(this.IdCajero);
            this.groupBox1.Controls.Add(this.UnCajero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(309, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajeros:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdDepartamento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(518, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departamentos:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(7, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(7, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Solamente Uno";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // IdDepartamento
            // 
            this.IdDepartamento.Location = new System.Drawing.Point(70, 66);
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.Size = new System.Drawing.Size(124, 23);
            this.IdDepartamento.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 252);
            this.dataGridView1.TabIndex = 14;
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.Crimson;
            this.GoBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.ForeColor = System.Drawing.Color.GhostWhite;
            this.GoBack.Location = new System.Drawing.Point(29, 457);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(114, 37);
            this.GoBack.TabIndex = 15;
            this.GoBack.Text = "Regresar";
            this.GoBack.UseVisualStyleBackColor = false;
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.DarkBlue;
            this.Consultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.Consultar.Location = new System.Drawing.Point(29, 147);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(100, 30);
            this.Consultar.TabIndex = 16;
            this.Consultar.Text = "Reporte";
            this.Consultar.UseVisualStyleBackColor = false;
            // 
            // ReporteCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(734, 500);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateInicio);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteCajero";
            this.Text = "ReporteCajero";
            this.Load += new System.EventHandler(this.ReporteCajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.DateTimePicker DateInicio;
        private System.Windows.Forms.CheckBox TodosCajeros;
        private System.Windows.Forms.CheckBox UnCajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdCajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button Consultar;
    }
}