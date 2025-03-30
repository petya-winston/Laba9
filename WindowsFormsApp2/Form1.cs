using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {
            string moduleName = Prompt.ShowDialog("Enter module name:", "Add Module");
            if (!string.IsNullOrWhiteSpace(moduleName))
            {
                listBoxModules.Items.Add(moduleName);
            }
        }

        private void buttonAddComponent_Click(object sender, EventArgs e)
        {
            if (listBoxModules.SelectedItem == null)
            {
                MessageBox.Show("Please select a module first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string componentName = Prompt.ShowDialog("Enter component name:", "Add Component");
            if (!string.IsNullOrWhiteSpace(componentName))
            {
                listBoxComponents.Items.Add($"{listBoxModules.SelectedItem}: {componentName}");
            }
        }
    }
}
