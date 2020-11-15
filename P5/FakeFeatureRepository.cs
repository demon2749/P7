using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class FakeFeatureRepository : IFeatureRepository
    {

        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "";
        public const string NOT_FOUND_ERROR = "";
        public const string INVALID_PROJECT_ID_ERROR = "";

        private static List<Feature> _Features = new List<Feature>();

        public FakeFeatureRepository()
        {
            if(_Features.Count() == 0)
            {
                Add(new Feature { Id = 1, ProjectId = 1, Title = "Flamethrower" });
                Add(new Feature { Id = 2, ProjectId = 1, Title = "Heat Capacitor" });
                Add(new Feature { Id = 3, ProjectId = 1, Title = "Expanded Napalm Canisters" });
                Add(new Feature { Id = 4, ProjectId = 2, Title = "Cool Menu Button" });
            }
        }

        public string Add(Feature feature)
        {
            throw new NotImplementedException();
        }
        public List<Feature> GetAll(int ProjectId)
        {
            throw new NotImplementedException();
        }
        public string Remove(Feature feature)
        {
            throw new NotImplementedException();
        }
        public string Modify(Feature feature)
        {
            throw new NotImplementedException();
        }
        public Feature GetFeatureById(int featureId)
        {
            throw new NotImplementedException();
        }
        public Feature GetFeatureByTitle(string title)
        {
            throw new NotImplementedException();
        }

    }
}
