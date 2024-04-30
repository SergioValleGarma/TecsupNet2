namespace Clase20240429
{
    partial class FormUsuario
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
            lblEdad = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chBCasado = new CheckBox();
            dtpNacimiento = new DateTimePicker();
            txtApellido = new TextBox();
            lblCasado = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(136, 347);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(86, 15);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "mayor de edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 168);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de nacimiento";
            // 
            // chBCasado
            // 
            chBCasado.AutoSize = true;
            chBCasado.Location = new Point(247, 201);
            chBCasado.Name = "chBCasado";
            chBCasado.Size = new Size(82, 19);
            chBCasado.TabIndex = 5;
            chBCasado.Text = "Es casado?";
            chBCasado.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(240, 160);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 23);
            txtApellido.TabIndex = 7;
            // 
            // lblCasado
            // 
            lblCasado.AutoSize = true;
            lblCasado.Location = new Point(369, 350);
            lblCasado.MinimumSize = new Size(100, 50);
            lblCasado.Name = "lblCasado";
            lblCasado.Size = new Size(100, 50);
            lblCasado.TabIndex = 8;
            lblCasado.Text = "casado";
            // 
            // button1
            // 
            button1.Location = new Point(283, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "analizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 10;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Controls.Add(lblCasado);
            Controls.Add(txtApellido);
            Controls.Add(dtpNacimiento);
            Controls.Add(chBCasado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblEdad);
            Name = "FormUsuario";
            Text = "FormUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chBCasado;
        private DateTimePicker dtpNacimiento;
        private TextBox txtApellido;
        private Label lblCasado;
        private Button button1;
        private TextBox txtNombre;
    }
}