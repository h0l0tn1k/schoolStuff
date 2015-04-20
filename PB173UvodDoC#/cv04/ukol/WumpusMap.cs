using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol
{
    class WumpusMap
    {
        private WumpusEnum[,] _map;
        private Coordinates _playerPosition;

        public Coordinates  PlayersPosition
        {
            get { return _playerPosition; }
        }

        public void GoDirection(Direction direction)
        {
            switch (direction)
            { 
                case Direction.Up:  
                        if (PlayersPosition.Y - 1 < 0)
                            throw new WumpusException("Out of map, cannot go!");
                        else{
                            info();
                            _playerPosition.Y--;
                        }
                        break;
                case Direction.Down:
                        if (PlayersPosition.Y + 1 >= _map.Length)
                            throw new WumpusException("Out of map, cannot go!");
                        else
                        {
                            info();
                            _playerPosition.Y++;
                        }
                        break;
                case Direction.Left:
                        if (PlayersPosition.X - 1 < 0)
                            throw new WumpusException("Out of map, cannot go!");
                        else
                        {
                            info();
                            _playerPosition.X--;
                        }
                        break;
                case Direction.Right:
                        if (PlayersPosition.X + 1 >= _map.Length)
                            throw new WumpusException("Out of map, cannot go!");
                        else
                        {
                            info();
                            _playerPosition.X++;
                            
                        }   
                        break;
                default: Console.WriteLine("Error, bad Coordinate!");
                        break;
        
            }
        }

        private void info()
        {
            string message = "";
            switch(_map[_playerPosition.X,_playerPosition.Y])
            {
                case WumpusEnum.Empty: message = "Empty Cell";
                    break;
                case WumpusEnum.Gold: message = "You have Won!";
                    break;
                case WumpusEnum.Hole: message = "You fell into hole!";
                    break;
                case WumpusEnum.Smrad: message = "Stinks here, be careful Wumpus might be around!";
                    break;
                case WumpusEnum.Vanek: message = "Windy here, be careful hole might be around!";
                    break;
                case WumpusEnum.Wumpus: message = "Wumpus found and ate you, you are dead!";
                    break;
                case WumpusEnum.WumpusAndHole: message = "You fell into hole and Wumpus also ate you!"; ;
                    break;

            }

            Console.WriteLine(message);
        }

        public WumpusMap(int size)
        {
            if (size > 0)
                _map = new WumpusEnum[size, size];
            _playerPosition = new Coordinates(size / 2, size / 2);


            for (int i = 0; i < size; i++)
            {
                for (int l = 0; l < size; l++)
                {
                    _map[i,l] = WumpusEnum.Empty;
                }
            }


            Random rnd = new Random();

            while(true)
            {
                Coordinates hole = new Coordinates(rnd.Next(0, size), rnd.Next(0, size));
                if (_map[hole.X, hole.Y] == WumpusEnum.Empty)
                {
                    _map[hole.X, hole.Y] = WumpusEnum.Hole;
                }
                Coordinates gold = new Coordinates(rnd.Next(0, size), rnd.Next(0, size));
                _map[gold.X, gold.Y] = WumpusEnum.Gold;


                break;
            }




            info();

        }
    }

    class WumpusException : Exception
    {
        public WumpusException(string s)
            :base(s)
        {   

        }
    }

    enum Direction
    { 
        Up,
        Down,
        Left,
        Right,
        None
    }


    enum WumpusEnum
    {
        Empty,
        Hole,
        Wumpus,
        WumpusAndHole,
        Gold,
        Smrad,
        Vanek
    }

    class Coordinates
    {
        private int _x;
        private int _y;

        public Coordinates(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        
    }
}
