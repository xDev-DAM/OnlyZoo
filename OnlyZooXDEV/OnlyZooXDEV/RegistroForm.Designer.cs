namespace OnlyZooXDEV
{
    partial class RegistroForm
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
            IniciaSesionLinkLabel = new LinkLabel();
            IniciaSesionLabel = new Label();
            RegitroButton = new Button();
            TexBoxContrasena = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxUsuario = new TextBox();
            TextBoxNombreCompleto = new TextBox();
            ContrasenaLabel = new Label();
            EmailLabel = new Label();
            UsuarioLabel = new Label();
            NombreCompletoLabel = new Label();
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
            TituloLabel.TabIndex = 0;
            TituloLabel.Text = "Registro";
            TituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelBot
            // 
            PanelBot.Controls.Add(IniciaSesionLinkLabel);
            PanelBot.Controls.Add(IniciaSesionLabel);
            PanelBot.Controls.Add(RegitroButton);
            PanelBot.Controls.Add(TexBoxContrasena);
            PanelBot.Controls.Add(TextBoxEmail);
            PanelBot.Controls.Add(TextBoxUsuario);
            PanelBot.Controls.Add(TextBoxNombreCompleto);
            PanelBot.Controls.Add(ContrasenaLabel);
            PanelBot.Controls.Add(EmailLabel);
            PanelBot.Controls.Add(UsuarioLabel);
            PanelBot.Controls.Add(NombreCompletoLabel);
            PanelBot.Dock = DockStyle.Fill;
            PanelBot.Location = new Point(0, 100);
            PanelBot.Name = "PanelBot";
            PanelBot.Size = new Size(384, 361);
            PanelBot.TabIndex = 1;
            // 
            // IniciaSesionLinkLabel
            // 
            IniciaSesionLinkLabel.AutoSize = true;
            IniciaSesionLinkLabel.Cursor = Cursors.Hand;
            IniciaSesionLinkLabel.LinkColor = Color.DimGray;
            IniciaSesionLinkLabel.Location = new Point(199, 317);
            IniciaSesionLinkLabel.Name = "IniciaSesionLinkLabel";
            IniciaSesionLinkLabel.Size = new Size(76, 15);
            IniciaSesionLinkLabel.TabIndex = 10;
            IniciaSesionLinkLabel.TabStop = true;
            IniciaSesionLinkLabel.Text = "Iniciar Sesion";
            // 
            // IniciaSesionLabel
            // 
            IniciaSesionLabel.AutoSize = true;
            IniciaSesionLabel.Location = new Point(96, 317);
            IniciaSesionLabel.Name = "IniciaSesionLabel";
            IniciaSesionLabel.Size = new Size(97, 15);
            IniciaSesionLabel.TabIndex = 9;
            IniciaSesionLabel.Text = "Ya tienes cuenta?";
            // 
            // RegitroButton
            // 
            RegitroButton.BackColor = Color.White;
            RegitroButton.Cursor = Cursors.Hand;
            RegitroButton.FlatStyle = FlatStyle.Flat;
            RegitroButton.Location = new Point(143, 274);
            RegitroButton.Name = "RegitroButton";
            RegitroButton.Size = new Size(90, 40);
            RegitroButton.TabIndex = 8;
            RegitroButton.Text = "Registrate";
            RegitroButton.UseVisualStyleBackColor = false;
            // 
            // TexBoxContrasena
            // 
            TexBoxContrasena.Location = new Point(26, 241);
            TexBoxContrasena.Name = "TexBoxContrasena";
            TexBoxContrasena.PasswordChar = '*';
            TexBoxContrasena.Size = new Size(309, 23);
            TexBoxContrasena.TabIndex = 7;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(26, 176);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(309, 23);
            TextBoxEmail.TabIndex = 6;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(26, 112);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(309, 23);
            TextBoxUsuario.TabIndex = 5;
            // 
            // TextBoxNombreCompleto
            // 
            TextBoxNombreCompleto.Location = new Point(26, 57);
            TextBoxNombreCompleto.Name = "TextBoxNombreCompleto";
            TextBoxNombreCompleto.Size = new Size(309, 23);
            TextBoxNombreCompleto.TabIndex = 4;
            // 
            // ContrasenaLabel
            // 
            ContrasenaLabel.AutoSize = true;
            ContrasenaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContrasenaLabel.Location = new Point(26, 223);
            ContrasenaLabel.Name = "ContrasenaLabel";
            ContrasenaLabel.Size = new Size(70, 15);
            ContrasenaLabel.TabIndex = 3;
            ContrasenaLabel.Text = "Contraseña:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(26, 158);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email:";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioLabel.Location = new Point(26, 94);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(50, 15);
            UsuarioLabel.TabIndex = 1;
            UsuarioLabel.Text = "Usuario:";
            // 
            // NombreCompletoLabel
            // 
            NombreCompletoLabel.AutoSize = true;
            NombreCompletoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCompletoLabel.Location = new Point(26, 39);
            NombreCompletoLabel.Name = "NombreCompletoLabel";
            NombreCompletoLabel.Size = new Size(110, 15);
            NombreCompletoLabel.TabIndex = 0;
            NombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(PanelBot);
            Controls.Add(PanelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistroForm";
            Text = "RegistroForm";
            PanelTop.ResumeLayout(false);
            PanelBot.ResumeLayout(false);
            PanelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelBot;
        private Label TituloLabel;
        private TextBox TextBoxNombreCompleto;
        private Label ContrasenaLabel;
        private Label EmailLabel;
        private Label UsuarioLabel;
        private Label NombreCompletoLabel;
        private TextBox TexBoxContrasena;
        private TextBox TextBoxEmail;
        private TextBox TextBoxUsuario;
        private Label IniciaSesionLabel;
        private Button RegitroButton;
        private LinkLabel IniciaSesionLinkLabel;
    }
}