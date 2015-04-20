using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW2
{
    class IndustrialBuilding : IBuilding
    {
        private string _builder;

        public IndustrialBuilding(string constructor)
        {
            _builder = constructor;
        }

        public string ConstructionCompanyName
        {
            get { return _builder; }
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
