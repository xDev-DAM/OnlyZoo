using OnlyZooXDEV.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZooXDEV
{
    public partial class IniciarSesionForm : Form
    {
        public IniciarSesionForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click -= new System.EventHandler(IniciarSesionButton_Click);
            this.RegistrateLinkLabel.LinkClicked -= new System.Windows.Forms.LinkLabelLinkClickedEventHandler(RegistrateLinkLabel_LinkClicked);

            this.Load += new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click += new System.EventHandler(IniciarSesionButton_Click);
            this.RegistrateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(RegistrateLinkLabel_LinkClicked);
        }
        private void LoadForm(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
        }
        private void LoadFonts(FontManager f)
        {
            this.TituloLabel.Font = f.TitleFont();
            this.UsuarioLabel.Font = f.SmallFont();
            this.ContrasenaLabel.Font = f.SmallFont();
            this.IniciarSesionButton.Font = f.SmallFont();
        }

        private void LoadColors()
        {
            this.PanelTop.BackColor = ColorManager.GetPaletteColor1();
            this.PanelBot.BackColor = ColorManager.GetPaletteColor1();
        }

        private void RegistrateLinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            new RegistroForm().ShowDialog(this);
        }
        private void IniciarSesionButton_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.TextBoxUsuario.Text) || string.IsNullOrEmpty(this.TexBoxContrasena.Text))
            {
                MostrarAlerta("Por favor, complete todos los campos.");
                return;
            }
            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
