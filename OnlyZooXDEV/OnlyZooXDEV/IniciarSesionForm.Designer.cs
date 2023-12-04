namespace OnlyZooXDEV
{
    partial class IniciarSesionForm
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
            PanelTop = new Panel();
            TituloLabel = new Label();
            PanelBot = new Panel();
            RegistrateLinkLabel = new LinkLabel();
            RegistrateLabel = new Label();
            IniciarSesionButton = new Button();
            TexBoxContrasena = new TextBox();
            TextBoxUsuario = new TextBox();
            ContrasenaLabel = new Label();
            UsuarioLabel = new Label();
            PanelTop.SuspendLayout();
            PanelBot.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(TituloLabel);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(384, 100);
            PanelTop.TabIndex = 0;
            // 
            // TituloLabel
            // 
            TituloLabel.Dock = DockStyle.Fill;
            TituloLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TituloLabel.Location = new Point(0, 0);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(384, 100);
            TituloLabel.TabIndex = 1;
            TituloLabel.Text = "Iniciar Sesion";
            TituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelBot
            // 
            PanelBot.Controls.Add(RegistrateLinkLabel);
            PanelBot.Controls.Add(RegistrateLabel);
            PanelBot.Controls.Add(IniciarSesionButton);
            PanelBot.Controls.Add(TexBoxContrasena);
            PanelBot.Controls.Add(TextBoxUsuario);
            PanelBot.Controls.Add(ContrasenaLabel);
            PanelBot.Controls.Add(UsuarioLabel);
            PanelBot.Dock = DockStyle.Fill;
            PanelBot.Location = new Point(0, 100);
            PanelBot.Name = "PanelBot";
            PanelBot.Size = new Size(384, 361);
            PanelBot.TabIndex = 1;
            // 
            // RegistrateLinkLabel
            // 
            RegistrateLinkLabel.AutoSize = true;
            RegistrateLinkLabel.LinkColor = Color.DimGray;
            RegistrateLinkLabel.Location = new Point(224, 302);
            RegistrateLinkLabel.Name = "RegistrateLinkLabel";
            RegistrateLinkLabel.Size = new Size(59, 15);
            RegistrateLinkLabel.TabIndex = 21;
            RegistrateLinkLabel.TabStop = true;
            RegistrateLinkLabel.Text = "Registrate";
            RegistrateLinkLabel.LinkClicked += RegistrateLinkLabel_LinkClicked;
            // 
            // RegistrateLabel
            // 
            RegistrateLabel.AutoSize = true;
            RegistrateLabel.Location = new Point(94, 302);
            RegistrateLabel.Name = "RegistrateLabel";
            RegistrateLabel.Size = new Size(124, 15);
            RegistrateLabel.TabIndex = 20;
            RegistrateLabel.Text = "Aun no tienes cuenta?";
            // 
            // IniciarSesionButton
            // 
            IniciarSesionButton.Location = new Point(119, 247);
            IniciarSesionButton.Name = "IniciarSesionButton";
            IniciarSesionButton.Size = new Size(138, 40);
            IniciarSesionButton.TabIndex = 19;
            IniciarSesionButton.Text = "Iniciar Sesion";
            IniciarSesionButton.UseVisualStyleBackColor = true;
            // 
            // TexBoxContrasena
            // 
            TexBoxContrasena.Location = new Point(38, 175);
            TexBoxContrasena.Name = "TexBoxContrasena";
            TexBoxContrasena.PasswordChar = '*';
            TexBoxContrasena.Size = new Size(309, 23);
            TexBoxContrasena.TabIndex = 18;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(38, 73);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(309, 23);
            TextBoxUsuario.TabIndex = 16;
            // 
            // ContrasenaLabel
            // 
            ContrasenaLabel.AutoSize = true;
            ContrasenaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContrasenaLabel.Location = new Point(38, 157);
            ContrasenaLabel.Name = "ContrasenaLabel";
            ContrasenaLabel.Size = new Size(70, 15);
            ContrasenaLabel.TabIndex = 14;
            ContrasenaLabel.Text = "Contraseña:";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioLabel.Location = new Point(38, 55);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(50, 15);
            UsuarioLabel.TabIndex = 12;
            UsuarioLabel.Text = "Usuario:";
            // 
            // IniciarSesionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(PanelBot);
            Controls.Add(PanelTop);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IniciarSesionForm";
            Text = "IniciarSesionForm";
            PanelTop.ResumeLayout(false);
            PanelBot.ResumeLayout(false);
            PanelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelBot;
        private Label TituloLabel;
        private LinkLabel RegistrateLinkLabel;
        private Label RegistrateLabel;
        private Button IniciarSesionButton;
        private TextBox TexBoxContrasena;
        private TextBox TextBoxUsuario;
        private Label ContrasenaLabel;
        private Label UsuarioLabel;
    }
}