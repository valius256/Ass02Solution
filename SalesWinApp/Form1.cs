using AutoMapper;
using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using Repositories;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {

        IMemberRepository memberRepository = new MemberRepository();

        private IMapper mapper;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true)
               .Build();
            //load admin account from appsettings.json
            var adminUser = config["defaultAccount:email"];
            var adminPassword = config["defaultAccount:password"];
            var loginUser = txtEmail.Text; // Get the username from the user input
            var loginPassword = txtPassword.Text; // Get the password from the user input

            Member loginMember = memberRepository.Login(loginUser, loginPassword);

            if (loginMember != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string memberName = loginMember.Email;
                if (memberName.Equals(adminUser) && loginPassword.Equals(adminPassword))
                {

                    frmMain frmMain = null;
                    frmMain = new frmMain("Admin", adminUser);
                    frmMain.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMain.Show();
                }
                else
                {
                    // User is a normal user, perform normal user actions
                    // For example, view/create/update the profile and view orders history
                }
            }
            else
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

    }
}