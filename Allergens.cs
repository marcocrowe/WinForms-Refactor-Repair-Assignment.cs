using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    [Serializable]
    public class Allergens
    {
        public string Code { get; set; }
        public string Name { get; set; }
        

        public Allergens(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
    }
}

