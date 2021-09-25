using System;
using System.Windows.Forms;
using AquaVeilV1.Settings;

namespace AquaVeilV1.Forms
{
    public partial class fSettingsRedact : Form
    {
        private InjectorMap injectorMap;

        public fSettingsRedact()
        {
            InitializeComponent();
        }

        // Настройки по умолчанию
        private void fSettingsRedact_Load(object sender, EventArgs e)
        {
            injectorMap = new InjectorMap();

            injectorMap._defaultFileName = "injectorMapping.xml";

            injectorMap.initMapping();
        }

        private void tssiFrame_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Frame.Instance;
        }

        private void tssiSwingSetting_Click(object sender, EventArgs e)
        {
            new fSwingSettings().Show();
        }

        private void tssiNet_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Net.Instance;
        }

        private void tssiInjectorMapping_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = injectorMap;
        }

        private void fSettingsRedact_FormClosed(object sender, FormClosedEventArgs e)
        {
            injectorMap.updateMapping();

            Close();
        }
    }
}
