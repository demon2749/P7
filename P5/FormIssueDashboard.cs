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
            List < Issue > issues = this._fakeIssueRepository.GetAll(selectedProjectId);

/*            issues.Sort((a, b) => { 
                if(a.DiscoveryDate.Year == b.DiscoveryDate.Year)
                {
                    if(a.DiscoveryDate.Month == b.DiscoveryDate.Month)
                    {
                        return 0;
                    }

                    return a.DiscoveryDate.Month > b.DiscoveryDate.Month ? 1 : -1;
                }
                return a.DiscoveryDate.Year > b.DiscoveryDate.Year ? 1 : -1;
            });*/

            int i = 0;
            foreach(Issue issue in issues)
            {
                i++;
                this.listBoxIssuesByMonth.Items.Add($"{issue.DiscoveryDate.Year} - {i}: {issue.DiscoveryDate.Month}");
            }

            Dictionary<string, int> issuesByDiscoverer = new Dictionary<string, int>();
            foreach (Issue issue in issues)
            {
                int discoveries = 0;
                if (issuesByDiscoverer.ContainsKey(issue.Discoverer))
                {
                    issuesByDiscoverer.TryGetValue(issue.Discoverer, out discoveries);
                }
                discoveries++;
                issuesByDiscoverer.Add(issue.Discoverer, discoveries);
            }

            foreach(KeyValuePair<string, int> pair in issuesByDiscoverer)
            {
                this.listBoxIssuesByMonth.Items.Add($"{pair.Key} - {pair.Value}");
            }


        }
    }
}
