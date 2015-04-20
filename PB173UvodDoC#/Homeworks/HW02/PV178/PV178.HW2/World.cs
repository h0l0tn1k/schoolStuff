using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW2
{
    class World : IWorld
    {
        private int _width;
        private int _height;
        private int _freeTiles;

        private Dictionary<ICoordinates,IBuilding> _buildings;

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int FreeTiles
        {
            get { return _freeTiles; }
        }

        public World(int width,int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentOutOfRangeException();

            _width = width;
            _height = height;
            _freeTiles = width * height;
            _buildings = new Dictionary<ICoordinates,IBuilding>();
        }


        public ICoordinates GetBuildingLocation(IBuilding building)
        {
            if (building == null)
                throw new ArgumentNullException();

            if (!_buildings.ContainsValue(building))
                throw new InvalidOperationException("Budova není ve městě.");


            foreach (var item in _buildings)
            {
                if (item.Value == building)
                    return item.Key;
            }

            return new Coordinates(0,0);
        }

        public IBuilding GetBuildingAt(ICoordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public void Build(ICoordinates coordinates, IBuilding building)
        {
            //FreeTiles--;
            throw new NotImplementedException();
        }

        public decimal CalculateLandTax()
        {
            throw new NotImplementedException();
        }
    }
}
