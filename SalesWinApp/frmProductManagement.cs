namespace SalesWinApp
{
    public partial class frmProductManagement : Form
    {
        private string userRole;
        private string userEmailAddress;

        public frmProductManagement(string userRole, string userEmailAddress)
        {
            InitializeComponent();
            this.userRole = userRole;
            this.userEmailAddress = userEmailAddress;
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
