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
    public partial class FormIssueDashboard : Form
    {
        FakeIssueRepository _fakeIssueRepository;
        int selectedProjectId;

        public FormIssueDashboard(FakeIssueRepository fakeIssueRepository, int selectedProjectId)
        {
            InitializeComponent();
            _fakeIssueRepository = fakeIssueRepository;
            this.selectedProjectId = selectedProjectId;
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            this.labelIssueCount.Text = _fakeIssueRepository.GetTotalNumberOfIssues(selectedProjectId).ToString();
            List < Issue > issues = this._fakeIssueRepository.GetAll(selectedProjectId);

            Dictionary<long, int> issuesByMonth = new Dictionary<long, int>();
            foreach (Issue issue in issues)
            {
                DateTime date = new DateTime(issue.DiscoveryDate.Year, issue.DiscoveryDate.Month, 1, 1, 1, 1);
                long integerDate = date.Ticks;
                int discoveries = 1;
                if (!issuesByMonth.ContainsKey(integerDate))
                {
                    issuesByMonth.Add(integerDate, discoveries);
                }
                else
                {
                    discoveries++;
                    issuesByMonth[integerDate] += 1;

                }
            }

            int i = 0;
            foreach (KeyValuePair<long, int> pair in issuesByMonth)
            {
                i++;
                DateTime date = new DateTime(pair.Key);
                this.listBoxIssuesByMonth.Items.Add($"{date.Year} - {pair.Value} : {date.Month}");
            }


            Dictionary<string, int> issuesByDiscoverer = new Dictionary<string, int>();
            foreach (Issue issue in issues)
            {
                int discoveries = 0;
                if (!issuesByDiscoverer.ContainsKey(issue.Discoverer))
                {
                    issuesByDiscoverer.Add(issue.Discoverer, discoveries);
                }
                else
                {
                    discoveries++;
                    issuesByDiscoverer[issue.Discoverer] += 1;

                }
            }

            foreach(KeyValuePair<string, int> pair in issuesByDiscoverer)
            {
                string[] name = pair.Key.Split(' ');
                this.listBoxIssuesByDiscoverer.Items.Add($"{name[1]}, {name[0]} - {pair.Value}");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
