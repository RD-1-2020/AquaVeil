using System;
using System.Windows.Forms;

namespace AquaVeilV1.Forms
{
    public partial class fSettingsRedact : Form
    {
        private Settings.InjectorMap injectorMap;

        public fSettingsRedact()
        {
            InitializeComponent();
        }

        private void tssiFrame_Click(object sender, EventArgs e)
        {
            
            pgSettings.SelectedObject = Settings.Frame.Instance;
        }

        private void tssiSwingSetting_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Settings.Swing.Instance;
        }

        private void tssiNet_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Settings.Net.Instance;
        }

        private void tssiInjectorMapping_Click(object sender, EventArgs e)
        {
            injectorMap = new Settings.InjectorMap();

            // injectorMap.initMapping(); // Инициализация Маппинга из файла

            injectorMap._defaultFileName = "injectorMapping.xml";

            injectorMap.initMapping();

            pgSettings.SelectedObject = injectorMap;
        }

        private void tsBSave_Click(object sender, EventArgs e)
        {
            injectorMap.updateMapping();

            Close();
        }

        
    }
}
