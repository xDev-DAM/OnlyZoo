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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
            InitializeEvents();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);
            this.RegitroButton.Click -= new System.EventHandler(RegistrarButton_Click);

            this.Load += new System.EventHandler(LoadForm);
            this.RegitroButton.Click += new System.EventHandler(RegistrarButton_Click);
        }
        private void LoadForm(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
        }
        private void LoadFonts(FontManager f)
        {
            this.TituloLabel.Font = f.TitleFont();
            this.NombreCompletoLabel.Font = f.SmallFont();
            this.UsuarioLabel.Font = f.SmallFont();
            this.EmailLabel.Font = f.SmallFont();
            this.ContrasenaLabel.Font = f.SmallFont();
        }

        private void LoadColors()
        {
            this.PanelTop.BackColor = ColorManager.GetPaletteColor1();
            this.PanelBot.BackColor = ColorManager.GetPaletteColor1();
        }

        private void IniciaSesionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            IniciarSesionForm iniciarSesionForm = new IniciarSesionForm();
            iniciarSesionForm.ShowDialog();
        }
        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxNombreCompleto.Text) ||
                string.IsNullOrEmpty(this.TextBoxUsuario.Text) ||
                string.IsNullOrEmpty(this.TextBoxEmail.Text) ||
                string.IsNullOrEmpty(this.TexBoxContrasena.Text))
            {
                MostrarAlerta("Por favor, complete todos los campos.");
                return;
            }

            MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
