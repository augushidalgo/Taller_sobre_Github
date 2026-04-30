namespace Taller_sobre_Github
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbEstudiante = new ComboBox();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCarnet = new TextBox();
            txtNombreCompleto = new TextBox();
            txtAsistencia = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbEstudiante
            // 
            cbEstudiante.FormattingEnabled = true;
            cbEstudiante.Location = new Point(155, 61);
            cbEstudiante.Name = "cbEstudiante";
            cbEstudiante.Size = new Size(271, 28);
            cbEstudiante.TabIndex = 0;
            cbEstudiante.SelectedIndexChanged += cbEstudiante_SelectedIndexChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(94, 132);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(55, 20);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Carnet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 180);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 232);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Asistencia:";
            // 
            // txtCarnet
            // 
            txtCarnet.BackColor = SystemColors.HighlightText;
            txtCarnet.Location = new Point(155, 129);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.ReadOnly = true;
            txtCarnet.Size = new Size(271, 27);
            txtCarnet.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.HighlightText;
            txtNombreCompleto.Location = new Point(155, 177);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(271, 27);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtAsistencia
            // 
            txtAsistencia.BackColor = SystemColors.HighlightText;
            txtAsistencia.Location = new Point(155, 229);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.ReadOnly = true;
            txtAsistencia.Size = new Size(271, 27);
            txtAsistencia.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(195, 311);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 69);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 8;
            label3.Text = "Buscar Estudiante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(21, 9);
            label4.Name = "label4";
            label4.Size = new Size(442, 32);
            label4.TabIndex = 9;
            label4.Text = "Control de Asistencia al Taller de GitHub";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 399);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtAsistencia);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtCarnet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(cbEstudiante);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEstudiante;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private TextBox txtCarnet;
        private TextBox txtNombreCompleto;
        private TextBox txtAsistencia;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
