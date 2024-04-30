namespace Clase20240429
{
    partial class formMenuFinal
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem1 = new ToolStripMenuItem();
            elimiarToolStripMenuItem = new ToolStripMenuItem();
            logearToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            userToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem1 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem1 = new ToolStripMenuItem();
            registroToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, logearToolStripMenuItem, registrarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 70);
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, registrarToolStripMenuItem1, elimiarToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(120, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(123, 22);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // registrarToolStripMenuItem1
            // 
            registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            registrarToolStripMenuItem1.Size = new Size(123, 22);
            registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // elimiarToolStripMenuItem
            // 
            elimiarToolStripMenuItem.Name = "elimiarToolStripMenuItem";
            elimiarToolStripMenuItem.Size = new Size(123, 22);
            elimiarToolStripMenuItem.Text = "Elimiar";
            // 
            // logearToolStripMenuItem
            // 
            logearToolStripMenuItem.Name = "logearToolStripMenuItem";
            logearToolStripMenuItem.Size = new Size(120, 22);
            logearToolStripMenuItem.Text = "Logear";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(120, 22);
            registrarToolStripMenuItem.Text = "Registrar";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(97, 26);
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(96, 22);
            userToolStripMenuItem.Text = "user";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem1, productoToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem1
            // 
            usuarioToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, registroToolStripMenuItem });
            usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            usuarioToolStripMenuItem1.Size = new Size(58, 20);
            usuarioToolStripMenuItem1.Text = "usuario";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(180, 22);
            registroToolStripMenuItem.Text = "registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem1
            // 
            productoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem1, eliminarToolStripMenuItem });
            productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            productoToolStripMenuItem1.Size = new Size(68, 20);
            productoToolStripMenuItem1.Text = "producto";
            // 
            // registroToolStripMenuItem1
            // 
            registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            registroToolStripMenuItem1.Size = new Size(180, 22);
            registroToolStripMenuItem1.Text = "registro";
            registroToolStripMenuItem1.Click += registroToolStripMenuItem1_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // formMenuFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formMenuFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMenuFinal";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem1;
        private ToolStripMenuItem elimiarToolStripMenuItem;
        private ToolStripMenuItem logearToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem userToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem1;
        private ToolStripMenuItem registroToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}