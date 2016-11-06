﻿namespace ClinicaFrba.Registro_Llegada
{
    partial class Llegada
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
            this.btnTurnoProf = new System.Windows.Forms.Button();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCargarProfesionales = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnVerTurnosEspecialidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurnoProf
            // 
            this.btnTurnoProf.Location = new System.Drawing.Point(251, 93);
            this.btnTurnoProf.Name = "btnTurnoProf";
            this.btnTurnoProf.Size = new System.Drawing.Size(138, 23);
            this.btnTurnoProf.TabIndex = 0;
            this.btnTurnoProf.Text = "Buscar Turnos";
            this.btnTurnoProf.UseVisualStyleBackColor = true;
            this.btnTurnoProf.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // txtProfesional
            // 
            this.txtProfesional.Location = new System.Drawing.Point(15, 96);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(230, 20);
            this.txtProfesional.TabIndex = 1;
            this.txtProfesional.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Profesional por nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Profesional por especialidad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnCargarProfesionales
            // 
            this.btnCargarProfesionales.Location = new System.Drawing.Point(251, 151);
            this.btnCargarProfesionales.Name = "btnCargarProfesionales";
            this.btnCargarProfesionales.Size = new System.Drawing.Size(138, 23);
            this.btnCargarProfesionales.TabIndex = 5;
            this.btnCargarProfesionales.Text = "Cargar Profesionales";
            this.btnCargarProfesionales.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnVerTurnosEspecialidad
            // 
            this.btnVerTurnosEspecialidad.Location = new System.Drawing.Point(251, 209);
            this.btnVerTurnosEspecialidad.Name = "btnVerTurnosEspecialidad";
            this.btnVerTurnosEspecialidad.Size = new System.Drawing.Size(138, 23);
            this.btnVerTurnosEspecialidad.TabIndex = 7;
            this.btnVerTurnosEspecialidad.Text = "Buscar Turnos";
            this.btnVerTurnosEspecialidad.UseVisualStyleBackColor = true;
            this.btnVerTurnosEspecialidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesionales Disponibles:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(15, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 13);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "NUMERO DE AFILIADO:";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(154, 20);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(91, 20);
            this.txtNumeroAfiliado.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Verificar Bono Disponible";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerTurnosEspecialidad);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnCargarProfesionales);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.btnTurnoProf);
            this.Name = "Llegada";
            this.Text = "Registrar Llegada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnoProf;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCargarProfesionales;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnVerTurnosEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.Button button1;
    }
}