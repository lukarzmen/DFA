using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat1
{
    class Automat
    {
        public Automat()
        {
            SciezkaStanow = new List<int>();
            StanyAkceptujace = new List<int> { 5,6,7,8,9};
        }
        public List<int> SciezkaStanow { get; set; }
        public int Stan { get; set; }
        public bool CzyAkceptujacy
        {
            get
            {
                return StanyAkceptujace.Any(x => x == Stan);
            }
        }

        public List<int> StanyAkceptujace { get; set; }
        public void AutomatDoNapojow(int moneta)
        {
            if (moneta == 1 || moneta == 2 || moneta == 5)
                switch (Stan)
                {
                    case 0:
                        if (moneta == 1)
                            Przejscie(1);
                        if (moneta == 2)
                            Przejscie(2);
                        if (moneta == 5)
                            Przejscie(5);
                        break;
                    case 1:
                        if (moneta == 1)
                            Przejscie(2);
                        if (moneta == 2)
                            Przejscie(3);
                        if (moneta == 5)
                            Przejscie(6);
                        break;
                    case 2:
                        if (moneta == 1)
                            Przejscie(3);
                        if (moneta == 2)
                            Przejscie(4);
                        if (moneta == 5)
                            Przejscie(7);
                        break;
                    case 3:
                        if (moneta == 1)
                            Przejscie(4);
                        if (moneta == 2)
                            Przejscie(5);
                        if (moneta == 5)
                            Przejscie(8);
                        break;
                    case 4:
                        if (moneta == 1)
                            Przejscie(5);
                        if (moneta == 2)
                            Przejscie(6);
                        if (moneta == 5)
                            Przejscie(9);
                        break;
                    case 5:
                        if (moneta == 1 || moneta == 2 || moneta == 5)
                            Przejscie(5);
                        break;
                    case 6:
                        if (moneta == 1 || moneta == 2 || moneta == 5)
                            Przejscie(6);
                        break;
                    case 7:
                        if (moneta == 1 || moneta == 2 || moneta == 5)
                            Przejscie(7);
                        break;
                    case 8:
                        if (moneta == 1 || moneta == 2 || moneta == 5)
                            Przejscie(8);
                        break;
                    case 9:
                        if (moneta == 1 || moneta == 2 || moneta == 5)
                            Przejscie(9);
                        break;
                }

        }
        private void Przejscie(int stan)
        {
            SciezkaStanow.Add(stan);
            Stan = stan;
        }
    }
}
