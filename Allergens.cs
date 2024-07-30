using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    [Serializable]
    public class Allergens(string code, string name)
    {
        public string Code { get; set; } = code;
        public string Name { get; set; } = name;
    }
}

