namespace RegistrodeAnalisis.UI.Registro
{
    partial class rAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAnalisis));
            this.TipoAnalisisButton = new System.Windows.Forms.Button();
            this.TipoAnalisiscomboBox = new System.Windows.Forms.ComboBox();
            this.label02 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Analisisbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetallesdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PacientecomboBox = new System.Windows.Forms.ComboBox();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoAnalisisButton
            // 
            this.TipoAnalisisButton.Location = new System.Drawing.Point(150, 36);
            this.TipoAnalisisButton.Name = "TipoAnalisisButton";
            this.TipoAnalisisButton.Size = new System.Drawing.Size(26, 23);
            this.TipoAnalisisButton.TabIndex = 43;
            this.TipoAnalisisButton.Text = "+";
            this.TipoAnalisisButton.UseVisualStyleBackColor = true;
            this.TipoAnalisisButton.Click += new System.EventHandler(this.TipoAnalisisButton_Click);
            // 
            // TipoAnalisiscomboBox
            // 
            this.TipoAnalisiscomboBox.FormattingEnabled = true;
            this.TipoAnalisiscomboBox.Location = new System.Drawing.Point(4, 38);
            this.TipoAnalisiscomboBox.Name = "TipoAnalisiscomboBox";
            this.TipoAnalisiscomboBox.Size = new System.Drawing.Size(141, 21);
            this.TipoAnalisiscomboBox.TabIndex = 42;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(1, 14);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(69, 13);
            this.label02.TabIndex = 41;
            this.label02.Text = "Tipo Analisis:";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(85, 11);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(83, 20);
            this.IdnumericUpDown.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Location = new System.Drawing.Point(39, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 88);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(85, 44);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(89, 20);
            this.FechadateTimePicker.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha";
            // 
            // Analisisbutton
            // 
            this.Analisisbutton.Location = new System.Drawing.Point(281, 35);
            this.Analisisbutton.Name = "Analisisbutton";
            this.Analisisbutton.Size = new System.Drawing.Size(28, 23);
            this.Analisisbutton.TabIndex = 47;
            this.Analisisbutton.Text = "+";
            this.Analisisbutton.UseVisualStyleBackColor = true;
            this.Analisisbutton.Click += new System.EventHandler(this.Pacientebutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // DetallesdataGridView
            // 
            this.DetallesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesdataGridView.Location = new System.Drawing.Point(6, 65);
            this.DetallesdataGridView.Name = "DetallesdataGridView";
            this.DetallesdataGridView.Size = new System.Drawing.Size(303, 106);
            this.DetallesdataGridView.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DetallesdataGridView);
            this.groupBox2.Controls.Add(this.Analisisbutton);
            this.groupBox2.Controls.Add(this.ResultadotextBox);
            this.groupBox2.Controls.Add(this.label02);
            this.groupBox2.Controls.Add(this.TipoAnalisiscomboBox);
            this.groupBox2.Controls.Add(this.TipoAnalisisButton);
            this.groupBox2.Location = new System.Drawing.Point(15, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 185);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // PacientecomboBox
            // 
            this.PacientecomboBox.FormattingEnabled = true;
            this.PacientecomboBox.Location = new System.Drawing.Point(85, 78);
            this.PacientecomboBox.Name = "PacientecomboBox";
            this.PacientecomboBox.Size = new System.Drawing.Size(216, 21);
            this.PacientecomboBox.TabIndex = 60;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(182, 38);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(93, 20);
            this.ResultadotextBox.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Removerbutton.Image")));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(15, 292);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(114, 23);
            this.Removerbutton.TabIndex = 59;
            this.Removerbutton.Text = "- Remover Fila";
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EliminarButton.Image = global::RegistrodeAnalisis.Properties.Resources.Button_Delete_01_25095;
            this.EliminarButton.Location = new System.Drawing.Point(200, 19);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 56);
            this.EliminarButton.TabIndex = 6;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Guardarbutton.Image = global::RegistrodeAnalisis.Properties.Resources.Save_37110;
            this.Guardarbutton.Location = new System.Drawing.Point(103, 19);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nuevobutton.Image = global::RegistrodeAnalisis.Properties.Resources.document_add_256_icon_icons_com_75994;
            this.Nuevobutton.Location = new System.Drawing.Point(16, 19);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(71, 56);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistrodeAnalisis.Properties.Resources.Search_find_3519;
            this.BuscarButton.Location = new System.Drawing.Point(179, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(55, 39);
            this.BuscarButton.TabIndex = 40;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PacientecomboBox);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAnalisis";
            this.Text = "Registro de Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TipoAnalisisButton;
        private System.Windows.Forms.ComboBox TipoAnalisiscomboBox;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Analisisbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridView DetallesdataGridView;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox PacientecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button button1;
    }
}