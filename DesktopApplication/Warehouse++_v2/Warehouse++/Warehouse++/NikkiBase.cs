using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse__
{
    public partial class NikkiBase : Form
    {
        public NikkiBase()
        {
            InitializeComponent();
            this.MdiParent = Welcome.MainForm;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void NikkiBase_Load(object sender, EventArgs e)
        {

        }
    }
}
