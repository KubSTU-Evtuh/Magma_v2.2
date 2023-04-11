using System.Windows.Forms;

namespace Magma
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
