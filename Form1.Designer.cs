namespace becaEstudiantes
{
    partial class frmEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.CbnTipoEst = new System.Windows.Forms.ComboBox();
            this.cbnCarrera = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.BtnCalcularBeca = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese codigo de estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione la carrera";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione el tipo de estudiante ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ingrese el nombre y apellido";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(471, 12);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(205, 22);
            this.txtcod.TabIndex = 6;
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(330, 283);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(205, 22);
            this.txtProm.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(314, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(346, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // CbnTipoEst
            // 
            this.CbnTipoEst.FormattingEnabled = true;
            this.CbnTipoEst.Items.AddRange(new object[] {
            "Militar",
            "civil"});
            this.CbnTipoEst.Location = new System.Drawing.Point(319, 154);
            this.CbnTipoEst.Name = "CbnTipoEst";
            this.CbnTipoEst.Size = new System.Drawing.Size(200, 24);
            this.CbnTipoEst.TabIndex = 11;
            // 
            // cbnCarrera
            // 
            this.cbnCarrera.FormattingEnabled = true;
            this.cbnCarrera.Items.AddRange(new object[] {
            "Ing Comercial",
            "Ing Sistemas",
            "Ing Civil"});
            this.cbnCarrera.Location = new System.Drawing.Point(319, 217);
            this.cbnCarrera.Name = "cbnCarrera";
            this.cbnCarrera.Size = new System.Drawing.Size(200, 24);
            this.cbnCarrera.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(31, 365);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(164, 58);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar Estudiante ";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnCalcularBeca
            // 
            this.BtnCalcularBeca.Location = new System.Drawing.Point(471, 365);
            this.BtnCalcularBeca.Name = "BtnCalcularBeca";
            this.BtnCalcularBeca.Size = new System.Drawing.Size(164, 58);
            this.BtnCalcularBeca.TabIndex = 15;
            this.BtnCalcularBeca.Text = "Calcular Beca ";
            this.BtnCalcularBeca.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(256, 365);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(164, 58);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar Estudianes";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.BtnCalcularBeca);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbnCarrera);
            this.Controls.Add(this.CbnTipoEst);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstudiante";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox CbnTipoEst;
        private System.Windows.Forms.ComboBox cbnCarrera;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button BtnCalcularBeca;
        private System.Windows.Forms.Button btnMostrar;
    }
}

