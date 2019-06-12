namespace RegistrodeAnalisis.UI.Registro
{
    partial class TiposAnalisis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Location = new System.Drawing.Point(38, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 88);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EliminarButton.Location = new System.Drawing.Point(200, 19);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 56);
            this.EliminarButton.TabIndex = 6;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Guardarbutton.Location = new System.Drawing.Point(103, 19);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nuevobutton.Location = new System.Drawing.Point(16, 19);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(71, 56);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Buscarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Buscarbutton.Location = new System.Drawing.Point(211, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(60, 46);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(70, 29);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown.TabIndex = 24;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(104, 90);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(167, 20);
            this.DescripciontextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // TiposAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "TiposAnalisis";
            this.Text = "Tipos de Analisis";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}