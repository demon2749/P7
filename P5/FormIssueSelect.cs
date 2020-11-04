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
    public partial class FormIssueSelect : Form
    {
        int selectedProjectId;
        string action;// Use this to either call the modify or the remove menu.

        public FormIssueSelect(int Id, string action)
        {
            InitializeComponent();
            selectedProjectId = Id;
            this.action = action;
        }

        private void FormIssueSelect_Load(object sender, EventArgs e)
        {
            // fill datagrid

        }
    }
}
