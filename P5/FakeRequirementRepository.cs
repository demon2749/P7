using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "";
        public const string EMPTY_STATEMENT_ERROR = "";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "";
        public const string MISSING_FEATUREID_ERROR = "";
        public const string MISSING_PROJECTID_ERROR = "";

        private static List<Requirement> _Requirements = new List<Requirement>();

        public FakeRequirementRepository()
        {
            if (_Requirements.Count() == 0)
            {
                Add(new Requirement { Id = 1, ProjectId = 1, FeatureId = 1, Statement = "Must Function" });
                Add(new Requirement { Id = 2, ProjectId = 1, FeatureId = 1, Statement = "Must Meet School Safety Guidelines For On-Campus Flamethrowers" });
                Add(new Requirement { Id = 3, ProjectId = 1, FeatureId = 2, Statement = "Must suppress to under 3 gigajoules of power" });
                Add(new Requirement { Id = 4, ProjectId = 2, FeatureId = 4, Statement = "Needs to function" });
            }
        }

        public string Add(Requirement requirment)
        {
            throw new NotImplementedException();
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public string Remove(Requirement requirement)
        {
            throw new NotImplementedException();
        }
        public string Modify(Requirement requirement)
        {
            throw new NotImplementedException();
        }
        public Requirement GetRequirementById(int requirementId)
        {
            throw new NotImplementedException();
        }
        public int CountByFeatureId(int featureId)
        {
            throw new NotImplementedException();
        }
        public void RemoveByFeatureId(int featureId)
        {
            throw new NotImplementedException();
        }

    }
}
