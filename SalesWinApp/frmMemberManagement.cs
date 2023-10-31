using Repositories;

namespace SalesWinApp
{
    public partial class frmMemberManagement : Form
    {
        private string userRole;
        private string userEmailAddress;


        public frmMemberManagement(string role, string userEmail)
        {
            InitializeComponent();
            userRole = role;
            userEmailAddress = userEmail;
        }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;


        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            txtMemberID.Enabled = true;
            txtMemberName.Enabled = true;
            txtEmail.Enabled = true;
            txtCompanyName.Enabled = true;
            txtPassword.Enabled = true;
            txtCity.Enabled = true;
            txtCountry.Enabled = true;
            btnNew.Enabled = true;
            dgvMemberList.Enabled = true;
            btnLoad.Enabled = true;
            grSearch.Enabled = true;
            grFilter.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtMemberID.Enabled = false;
            txtMemberName.Enabled = false;
            txtEmail.Enabled = false;
            txtCompanyName.Enabled = false;
            txtPassword.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            btnNew.Enabled = false;
            dgvMemberList.Enabled = false;
            btnLoad.Enabled = true;
            grSearch.Enabled = false;
            grFilter.Enabled = false;
            CreateMainMenu();
        }

        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            ToolStripMenuItem menuManagement = new ToolStripMenuItem("&Management");
            ToolStripMenuItem menuProductMng = new ToolStripMenuItem("&Product Management");
            ToolStripMenuItem menuOrderMng = new ToolStripMenuItem("&Order Management");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();






    }
}
