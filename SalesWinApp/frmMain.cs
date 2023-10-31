namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private string userRole;
        private string userEmailAddress;

        private Form currentFormChild;

        public frmMain(string role, string email)
        {
            InitializeComponent();
            userRole = role;
            userEmailAddress = email;
        }



        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMemberManagement(userRole, userEmailAddress));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProductManagement(userRole, userEmailAddress));
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrdersManagement(userRole, userEmailAddress));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
