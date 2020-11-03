using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;

namespace P6
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        private static List<Issue> _Issues = new List<Issue>()
        {
            new Issue()
            {
                Id = 1,
                ProjectId = 1,
                Title = "Title",
                DiscoveryDate = new DateTime(2020, 1, 1, 1, 1, 1),
                Discoverer = "First Last",
                InitialDescription = "Super duper super bug",
                Component = "what is this?",
                IssueStatusId = 1,
            },
            new Issue()
            {
                Id = 2,
                ProjectId = 1,
                Title = "Title",
                DiscoveryDate = new DateTime(2020, 1, 1, 1, 1, 1),
                Discoverer = "First Last",
                InitialDescription = "Super duper super bug",
                Component = "what is this?",
                IssueStatusId = 1,
            }
        };

        private string ValidateIssue(Issue issue)
        {
            if (issue.Title == "" || issue.Title == null)
            {
                return EMPTY_TITLE_ERROR;
            }

            if (issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }

            if (DateTime.Compare(issue.DiscoveryDate, System.DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }

            if (issue.Discoverer == "" || issue.Discoverer == null)
            {
                return EMPTY_DISCOVERER_ERROR;
            }

            return NO_ERROR;
        }

        private bool IsDuplicate(string title)
        {
            foreach(Issue issue in _Issues)
            {
                if(issue.Title == title)
                {
                    return true;
                }
            }
            return false;
        }

        // Interface Implementation:

        public string Add(Issue issue)
        {
            string check = ValidateIssue(issue);
            if (check == NO_ERROR && IsDuplicate(issue.Title) == false)
            {
                _Issues.Add(issue);
                return NO_ERROR;
            }
            else
            {
                if (IsDuplicate(issue.Title) == true)
                {
                    return "Titles must be unique across all projects.";
                }
                else
                {
                    return check;
                }
            }
        }
        public List<Issue> GetAll(int ProjectId)
        {
            List<Issue> ListOfIssues = new List<Issue>();

            foreach(Issue issue in _Issues)
            {
                if(issue.ProjectId == ProjectId)
                {
                    ListOfIssues.Add(issue);
                }
            }

            return ListOfIssues;
        }
        public bool Remove(Issue issue)
        {
            foreach (Issue current in _Issues)
            {
                if (issue == current)
                {
                    _Issues.Remove(issue);
                    return true;
                }
            }

            return false;
        }
        public string Modify(Issue issue)
        {
            throw new NotImplementedException();
        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int count = 0;
            foreach(Issue issue in _Issues)
            {
                if(issue.ProjectId == ProjectId)
                {
                    count++;
                }
            }

            return count;
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public Issue GetIssueById(int Id)
        {

            foreach (Issue issue in _Issues)
            {
                if(issue.Id == Id)
                {
                    return issue;
                }
            }

            return null;
        }
    }
}
