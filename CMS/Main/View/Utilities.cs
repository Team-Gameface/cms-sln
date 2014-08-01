using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class Utilities : UserControl
    {
        Controller.MainController mainController;

        public Utilities(Controller.MainController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            mainController.utilitiesOpen = false;
        }

        private void btnBatchProcess_Click(object sender, EventArgs e)
        {
            new BatchProcessAutomation().Show();
        }
    }
}
