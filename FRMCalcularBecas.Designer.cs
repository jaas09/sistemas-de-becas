namespace becaEstudiantes
{
    partial class FRMCalcularBecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnBuscarEst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtnDeportiva = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTipoEst = new System.Windows.Forms.TextBox();
            this.gTipoBeca = new System.Windows.Forms.GroupBox();
            this.rdnHijoMIlitar = new System.Windows.Forms.RadioButton();
            this.rdnSocial = new System.Windows.Forms.RadioButton();
            this.rdnExcelencia = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdnCultural = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.rdnNinguno = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoBeca = new System.Windows.Forms.TextBox();
            this.txtMensualidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gTipoBeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo ";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(202, 23);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(170, 22);
            this.txtCod.TabIndex = 1;
            // 
            // btnBuscarEst
            // 
            this.btnBuscarEst.Location = new System.Drawing.Point(435, 21);
            this.btnBuscarEst.Name = "btnBuscarEst";
            this.btnBuscarEst.Size = new System.Drawing.Size(181, 23);
            this.btnBuscarEst.TabIndex = 2;
            this.btnBuscarEst.Text = "Buscar Estudiante ";
            this.btnBuscarEst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoEst);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.txtPromedio);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datoss De Estudainte";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbtnDeportiva
            // 
            this.tbtnDeportiva.AutoSize = true;
            this.tbtnDeportiva.Location = new System.Drawing.Point(6, 32);
            this.tbtnDeportiva.Name = "tbtnDeportiva";
            this.tbtnDeportiva.Size = new System.Drawing.Size(88, 20);
            this.tbtnDeportiva.TabIndex = 0;
            this.tbtnDeportiva.TabStop = true;
            this.tbtnDeportiva.Text = "deportiva ";
            this.tbtnDeportiva.UseVisualStyleBackColor = true;
            this.tbtnDeportiva.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE Y APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "PROMEDIO SEMESTRAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "TIPO DE ESTUDIANTE ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "CARRERA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 22);
            this.textBox1.TabIndex = 4;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(199, 143);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(104, 22);
            this.txtPromedio.TabIndex = 5;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(436, 137);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(104, 22);
            this.txtCarrera.TabIndex = 7;
            // 
            // txtTipoEst
            // 
            this.txtTipoEst.Enabled = false;
            this.txtTipoEst.Location = new System.Drawing.Point(199, 85);
            this.txtTipoEst.Name = "txtTipoEst";
            this.txtTipoEst.Size = new System.Drawing.Size(198, 22);
            this.txtTipoEst.TabIndex = 8;
            // 
            // gTipoBeca
            // 
            this.gTipoBeca.Controls.Add(this.rdnNinguno);
            this.gTipoBeca.Controls.Add(this.rdnCultural);
            this.gTipoBeca.Controls.Add(this.radioButton1);
            this.gTipoBeca.Controls.Add(this.rdnExcelencia);
            this.gTipoBeca.Controls.Add(this.rdnSocial);
            this.gTipoBeca.Controls.Add(this.rdnHijoMIlitar);
            this.gTipoBeca.Controls.Add(this.tbtnDeportiva);
            this.gTipoBeca.Location = new System.Drawing.Point(67, 299);
            this.gTipoBeca.Name = "gTipoBeca";
            this.gTipoBeca.Size = new System.Drawing.Size(595, 143);
            this.gTipoBeca.TabIndex = 4;
            this.gTipoBeca.TabStop = false;
            this.gTipoBeca.Text = "Tipo de beca";
            // 
            // rdnHijoMIlitar
            // 
            this.rdnHijoMIlitar.AutoSize = true;
            this.rdnHijoMIlitar.Location = new System.Drawing.Point(6, 72);
            this.rdnHijoMIlitar.Name = "rdnHijoMIlitar";
            this.rdnHijoMIlitar.Size = new System.Drawing.Size(91, 20);
            this.rdnHijoMIlitar.TabIndex = 1;
            this.rdnHijoMIlitar.TabStop = true;
            this.rdnHijoMIlitar.Text = "Hermanos";
            this.rdnHijoMIlitar.UseVisualStyleBackColor = true;
            // 
            // rdnSocial
            // 
            this.rdnSocial.AutoSize = true;
            this.rdnSocial.Location = new System.Drawing.Point(405, 32);
            this.rdnSocial.Name = "rdnSocial";
            this.rdnSocial.Size = new System.Drawing.Size(66, 20);
            this.rdnSocial.TabIndex = 2;
            this.rdnSocial.TabStop = true;
            this.rdnSocial.Text = "Social";
            this.rdnSocial.UseVisualStyleBackColor = true;
            // 
            // rdnExcelencia
            // 
            this.rdnExcelencia.AutoSize = true;
            this.rdnExcelencia.Location = new System.Drawing.Point(206, 32);
            this.rdnExcelencia.Name = "rdnExcelencia";
            this.rdnExcelencia.Size = new System.Drawing.Size(94, 20);
            this.rdnExcelencia.TabIndex = 3;
            this.rdnExcelencia.TabStop = true;
            this.rdnExcelencia.Text = "Excelencia";
            this.rdnExcelencia.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(214, 72);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "HIjo Militar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdnCultural
            // 
            this.rdnCultural.AutoSize = true;
            this.rdnCultural.Location = new System.Drawing.Point(405, 72);
            this.rdnCultural.Name = "rdnCultural";
            this.rdnCultural.Size = new System.Drawing.Size(72, 20);
            this.rdnCultural.TabIndex = 5;
            this.rdnCultural.TabStop = true;
            this.rdnCultural.Text = "Cultural";
            this.rdnCultural.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(58, 516);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(189, 52);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Mensualidad";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // rdnNinguno
            // 
            this.rdnNinguno.AutoSize = true;
            this.rdnNinguno.Location = new System.Drawing.Point(3, 117);
            this.rdnNinguno.Name = "rdnNinguno";
            this.rdnNinguno.Size = new System.Drawing.Size(78, 20);
            this.rdnNinguno.TabIndex = 6;
            this.rdnNinguno.TabStop = true;
            this.rdnNinguno.Text = "Ninguno";
            this.rdnNinguno.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monto Beca ";
            // 
            // txtMontoBeca
            // 
            this.txtMontoBeca.Location = new System.Drawing.Point(170, 463);
            this.txtMontoBeca.Name = "txtMontoBeca";
            this.txtMontoBeca.Size = new System.Drawing.Size(140, 22);
            this.txtMontoBeca.TabIndex = 10;
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Location = new System.Drawing.Point(472, 460);
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Size = new System.Drawing.Size(140, 22);
            this.txtMensualidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mensualidad";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(385, 516);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(189, 52);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FRMCalcularBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMontoBeca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gTipoBeca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarEst);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "FRMCalcularBecas";
            this.Text = "FRMCalcularBecas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gTipoBeca.ResumeLayout(false);
            this.gTipoBeca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnBuscarEst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tbtnDeportiva;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtTipoEst;
        private System.Windows.Forms.GroupBox gTipoBeca;
        private System.Windows.Forms.RadioButton rdnExcelencia;
        private System.Windows.Forms.RadioButton rdnSocial;
        private System.Windows.Forms.RadioButton rdnHijoMIlitar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdnCultural;
        private System.Windows.Forms.RadioButton rdnNinguno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoBeca;
        private System.Windows.Forms.TextBox txtMensualidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolver;
    }
}