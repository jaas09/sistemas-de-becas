namespace becaEstudiantes
{
    partial class FrmMotrarEstudiantes
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
            this.txtBuscarEst = new System.Windows.Forms.TextBox();
            this.dtbvMostrar = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarConMensu = new System.Windows.Forms.Button();
            this.btnSinMensu = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtbvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese el codigo del estudiante a buscar";
            // 
            // txtBuscarEst
            // 
            this.txtBuscarEst.Location = new System.Drawing.Point(58, 75);
            this.txtBuscarEst.Name = "txtBuscarEst";
            this.txtBuscarEst.Size = new System.Drawing.Size(290, 22);
            this.txtBuscarEst.TabIndex = 1;
            // 
            // dtbvMostrar
            // 
            this.dtbvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbvMostrar.Location = new System.Drawing.Point(12, 161);
            this.dtbvMostrar.Name = "dtbvMostrar";
            this.dtbvMostrar.RowHeadersWidth = 51;
            this.dtbvMostrar.RowTemplate.Height = 24;
            this.dtbvMostrar.Size = new System.Drawing.Size(641, 277);
            this.dtbvMostrar.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(34, 121);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(163, 34);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(405, 69);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 34);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarConMensu
            // 
            this.btnMostrarConMensu.Location = new System.Drawing.Point(454, 121);
            this.btnMostrarConMensu.Name = "btnMostrarConMensu";
            this.btnMostrarConMensu.Size = new System.Drawing.Size(182, 34);
            this.btnMostrarConMensu.TabIndex = 5;
            this.btnMostrarConMensu.Text = "Mostrar  con mensualidad";
            this.btnMostrarConMensu.UseVisualStyleBackColor = true;
            // 
            // btnSinMensu
            // 
            this.btnSinMensu.Location = new System.Drawing.Point(244, 121);
            this.btnSinMensu.Name = "btnSinMensu";
            this.btnSinMensu.Size = new System.Drawing.Size(165, 34);
            this.btnSinMensu.TabIndex = 6;
            this.btnSinMensu.Text = "Mostrar sin mensualidad";
            this.btnSinMensu.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(464, 462);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(163, 34);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmMotrarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSinMensu);
            this.Controls.Add(this.btnMostrarConMensu);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtbvMostrar);
            this.Controls.Add(this.txtBuscarEst);
            this.Controls.Add(this.label1);
            this.Name = "FrmMotrarEstudiantes";
            this.Text = "FrmMotrarEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtbvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEst;
        private System.Windows.Forms.DataGridView dtbvMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button btnMostrarConMensu;
        private System.Windows.Forms.Button btnSinMensu;
        private System.Windows.Forms.Button btnVolver;
    }
}