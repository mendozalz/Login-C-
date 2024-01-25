namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUsuario = new Label();
            lblPasswd = new Label();
            txtUsuario = new TextBox();
            txtPasswd = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(229, 81);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblPasswd
            // 
            lblPasswd.AutoSize = true;
            lblPasswd.Location = new Point(229, 132);
            lblPasswd.Name = "lblPasswd";
            lblPasswd.Size = new Size(46, 15);
            lblPasswd.TabIndex = 0;
            lblPasswd.Text = "Passwd";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(318, 78);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresa tu usuario";
            txtUsuario.Size = new Size(165, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "mendozalz";
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(318, 129);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.PasswordChar = '*';
            txtPasswd.PlaceholderText = "Ingresa tu password";
            txtPasswd.Size = new Size(165, 23);
            txtPasswd.TabIndex = 1;
            txtPasswd.Text = "123";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(229, 247);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(408, 247);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtPasswd);
            Controls.Add(txtUsuario);
            Controls.Add(lblPasswd);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblPasswd;
        private TextBox txtUsuario;
        private TextBox txtPasswd;
        private Button btnIngresar;
        private Button btnSalir;
    }
}
