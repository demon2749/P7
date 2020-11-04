using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueModify : Form
    {
        FakeIssueStatusRepository _FakeIssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository _FakeIssueRepository = new FakeIssueRepository();
        FakeAppUserRepository _FakeAppUserRepository = new FakeAppUserRepository();
        private int currentIssueId;

        public FormIssueModify(int Id)
        {
            InitializeComponent();
            currentIssueId = Id;
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            textBoxId.Text = currentIssueId.ToString();
        }
    }
}
