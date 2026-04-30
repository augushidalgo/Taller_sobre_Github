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
            cbEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbEstudiante.FormattingEnabled = true;
            cbEstudiante.Location = new Point(137, 150);
            cbEstudiante.Margin = new Padding(3, 2, 3, 2);
            cbEstudiante.Name = "cbEstudiante";
            cbEstudiante.Size = new Size(238, 23);
            cbEstudiante.TabIndex = 0;
            cbEstudiante.SelectedIndexChanged += cbEstudiante_SelectedIndexChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(569, 248);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(44, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Carnet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(137, 248);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(569, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Asistencia:";
            // 
            // txtCarnet
            // 
            txtCarnet.BackColor = SystemColors.HighlightText;
            txtCarnet.Location = new Point(569, 150);
            txtCarnet.Margin = new Padding(3, 2, 3, 2);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.ReadOnly = true;
            txtCarnet.Size = new Size(238, 23);
            txtCarnet.TabIndex = 4;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.HighlightText;
            txtNombreCompleto.Location = new Point(137, 285);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(238, 23);
            txtNombreCompleto.TabIndex = 5;
            txtNombreCompleto.TextChanged += txtNombreCompleto_TextChanged;
            // 
            // txtAsistencia
            // 
            txtAsistencia.BackColor = SystemColors.HighlightText;
            txtAsistencia.Location = new Point(569, 285);
            txtAsistencia.Margin = new Padding(3, 2, 3, 2);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.ReadOnly = true;
            txtAsistencia.Size = new Size(238, 23);
            txtAsistencia.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(695, 498);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(137, 121);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 8;
            label3.Text = "Buscar Estudiante:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(271, 42);
            label4.Name = "label4";
            label4.Size = new Size(368, 25);
            label4.TabIndex = 9;
            label4.Text = "Control de Asistencia al Taller de GitHub";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(964, 585);
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
            Margin = new Padding(3, 2, 3, 2);
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
