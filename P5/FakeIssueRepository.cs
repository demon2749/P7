using System;
using System.Collections.Generic;

namespace P6
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        private static List<Issue> _Issues = new List<Issue>();

        private string ValidateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        private bool IsDuplicate(string title)
        {
            throw new NotImplementedException();
        }

        // Interface Implementation:

        public string Add(Issue issue)
        {
            throw new NotImplementedException();
        }
        public List<Issue> GetAll(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public bool Remove(Issue issue)
        {
            throw new NotImplementedException();
        }
        public string Modify(Issue issue)
        {
            throw new NotImplementedException();
        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

    }
}
