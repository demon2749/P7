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
            foreach(Requirement req in _Requirements)
            {
                if(req.Statement == requirment.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            
            
            _Requirements.Add(requirment);

        }
        public List<Requirement> GetAll(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public string Remove(Requirement requirement)
        {
            foreach (Requirement req in _Requirements)
            {
                if (req == requirement)
                {
                    _Requirements.Remove(requirement);
                    return NO_ERROR;
                }
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public string Modify(Requirement requirement)
        {

            if(IsDupliclateStatement(requirement.Statement))
            {
                return DUPLICATE_STATEMENT_ERROR;
            }

            int index = 0;

            foreach(Requirement req in _Requirements)
            {
                if(requirement.Id == req.Id)
                {
                    _Requirements[index] = requirement;
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            foreach(Requirement req in _Requirements)
            {
                if(req.Id == requirementId)
                {
                    return req;
                }
            }

            throw new Exception();
        }
        public int CountByFeatureId(int featureId)
        {
            int count = 0;

            foreach (Requirement req in _Requirements)
            {
                if (req.FeatureId == featureId)
                {
                    count++;
                }
            }

            return count;
        }
        public void RemoveByFeatureId(int featureId)
        {
            foreach(Requirement req in _Requirements)
            {
                if(req.FeatureId == featureId)
                {
                    Remove(req);
                }
            }
        }

        private bool IsDupliclateStatement(string requirementStatement)
        {
            bool isDuplicate = false;
            foreach (Requirement req in _Requirements)
            {
                if (requirementStatement == req.Statement)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
    }
}
