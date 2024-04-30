namespace Clase20240429
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
            label1 = new Label();
            txtusuario = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            btnIniciar = new Button();
            btnSalir = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 90);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(209, 92);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(209, 160);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 160);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(124, 255);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(243, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(129, 317);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(131, 23);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "retornar a menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusuario;
        private TextBox txtContraseña;
        private Label label2;
        private Button btnIniciar;
        private Button btnSalir;
        private Button btnMenu;
    }
}
