namespace SalesWinApp
{

    public partial class frmOrdersManagement : Form
    {
        private string role;
        private string userEmailAddress;

        public frmOrdersManagement(string role, string userEmail)
        {
            InitializeComponent();
            this.role = role;
            this.userEmailAddress = userEmail;
        }

        private void frmOrdersManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
