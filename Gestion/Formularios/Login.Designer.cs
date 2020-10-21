namespace Gestion.Formularios
{
    partial class Login
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
            this.dataUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtIniciar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.BtCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUsuarioBindingSource
            // 
            this.dataUsuarioBindingSource.DataSource = typeof(Negocio.Objetos.DataUsuario);
            // 
            // BtIniciar
            // 
            this.BtIniciar.Location = new System.Drawing.Point(468, 98);
            this.BtIniciar.Name = "BtIniciar";
            this.BtIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtIniciar.TabIndex = 1;
            this.BtIniciar.Text = "Iniciar";
            this.BtIniciar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(312, 101);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(312, 146);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(468, 144);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtCerrar.TabIndex = 6;
            this.BtCerrar.Text = "Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.BtIniciar);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataUsuarioBindingSource;
        private System.Windows.Forms.Button BtIniciar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button BtCerrar;
    }
}