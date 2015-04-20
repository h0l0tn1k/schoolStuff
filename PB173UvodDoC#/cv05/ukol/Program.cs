using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3};
            FiniteAutomata<int> automat = new FiniteAutomata<int>(arr);
            int[] isOk = {1,2,3,1,2,2};
            Console.WriteLine(automat.Launch(isOk));
        }
    }

   
    class FiniteAutomata<T>
    {
        private T[] _alphabet;
        private Dictionary<T,int> _map;
        private int _stages;

        public FiniteAutomata(T[] alpha)
        {
            _alphabet = alpha;
            _map = new Dictionary<T, int>();
            _stages = 1;

            foreach (T item in _alphabet)
            {
                _map.Add(item, _stages++);
            }

        }

        public bool Launch(T[] value)
        {
            foreach (T item in value)
            {
                if (_map.ContainsKey(item))
                    continue;
                else
                    return false;
            }

            return true;
        }
        
    }
}
