using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    [Serializable]
    public class Recipe
    {
        public string recipeBookCode { get; set; }
        public string recipeBookName { get; set; }
        public List<string> recipeBookAllergens { get; set; }

        public Recipe(string rCode, string rName, List<string> rAllergens)
        {
            this.recipeBookCode = rCode;
            this.recipeBookName = rName;
            this.recipeBookAllergens = rAllergens;
        }
    }
}
