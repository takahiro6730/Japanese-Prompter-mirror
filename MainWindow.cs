

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JapanesePrompter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            var textForm=new TextForm();
            DialogResult result = textForm.ShowDialog();
        }
    }
}