using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAList
{
    public class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            var hash = 19;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + ISOCode.GetHashCode();
            return hash;
        }

        public override bool Equals(object? obj)
        {
            var country = obj as Country;
            if(country is null) 
                return false;
            return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase)
                && this.ISOCode.Equals(country.ISOCode, StringComparison.OrdinalIgnoreCase);
          
        }
        public override string ToString()
        {
            return $" {Name} ({ISOCode})";
        }
    }
}
