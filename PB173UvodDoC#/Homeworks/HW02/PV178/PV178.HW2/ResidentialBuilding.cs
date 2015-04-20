using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW2
{
    class ResidentialBuilding : IBuilding
    {
        private string _builder;
        public string ConstructionCompanyName
        {
            get { return _builder; }
        }

        public ResidentialBuilding(string constructor)
        {
            _builder = constructor;
        }

        public IWorld World
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal CalculateLandTax()
        {
            throw new NotImplementedException();
        }
    }
}
