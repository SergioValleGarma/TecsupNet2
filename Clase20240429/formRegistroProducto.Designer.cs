namespace Clase20240429
{
    partial class formRegistroProducto
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
            label1 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            cmbCategoria = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            dgvProducto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(106, 39);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(342, 45);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Frutas", "Verduras", "Electro" });
            cmbCategoria.Location = new Point(569, 46);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 52);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 47);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "precio";
            // 
            // button1
            // 
            button1.Location = new Point(41, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(63, 196);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Size = new Size(627, 150);
            dgvProducto.TabIndex = 7;
            // 
            // formRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducto);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "formRegistroProducto";
            Text = "formRegistroProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private ComboBox cmbCategoria;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridView dgvProducto;
    }
}