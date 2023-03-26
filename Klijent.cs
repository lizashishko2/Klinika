using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Klient
    {
        /*/private bool[] diseases = new bool[4];

        public bool HasDisease(Disease disease)
        {
            return diseases[(int)disease];
        }

        public void SetDisease(Disease disease, bool hasDisease)
        {
            diseases[(int)disease] = hasDisease;
        }
        /*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Disease> Diseases { get; set; } = new List<Disease>();

        public List<SelectedService> SelectedServices { get; set; } = new List<SelectedService>();

        public class Disease
        {
            public string Name { get; set; }
            public int Level { get; set; }
        }

        public class SelectedService
        {
            public Service Service { get; set; }
            public int Level { get; set; }
        }
    }
}
