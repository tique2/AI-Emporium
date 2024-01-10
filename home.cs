using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AI_Emporium
{
    public partial class home : Form
    {
        private bool componentsPanelVisible = false;  // Cambié el nombre de componentesPanel a componentsPanel

        public home()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Configurar la visibilidad inicial del componentsPanel
            componentsPanelVisible = false;
            componentsPanel.Visible = componentsPanelVisible;  // Cambié el nombre de componentesPanel a componentsPanel
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            // Lógica específica para el botón 1 (puedes personalizar esto según tus necesidades).
            ToggleComponentsPanelVisibility();
        }

        private void menuButton2_Click(object sender, EventArgs e)
        {
            // Lógica específica para el botón 2 (puedes personalizar esto según tus necesidades).
            ToggleComponentsPanelVisibility();
        }

        private void menuButton3_Click(object sender, EventArgs e)
        {
            // Lógica específica para el botón 3 (puedes personalizar esto según tus necesidades).
            ToggleComponentsPanelVisibility();
        }

        private void menuButton4_Click(object sender, EventArgs e)
        {
            // Lógica específica para el botón 4 (puedes personalizar esto según tus necesidades).
            ToggleComponentsPanelVisibility();
        }

        private void ToggleComponentsPanelVisibility()
        {
            // Alternar la visibilidad del componentsPanel
            componentsPanelVisible = !componentsPanelVisible;
            componentsPanel.Visible = componentsPanelVisible;  // Cambié el nombre de componentesPanel a componentsPanel
        }

    }
}