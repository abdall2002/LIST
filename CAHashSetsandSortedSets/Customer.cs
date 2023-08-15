using System;

namespace CAHashSetsandSortedSets
{

    public class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()   // لتجنب التصادم
        {
            var hash = 17;
            hash = hash * 397 + Name.GetHashCode();
            return hash;
        }

        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if(customer == null) 
                return false;
            return this.Telephone.Equals(customer.Telephone);
        }
        public override string ToString()
        {
            return $"{Name} ({Telephone})";
        }

        public int CompareTo(Customer other)
        {
            if (object.ReferenceEquals(this, other))
                return 0;

            if (other is null)
                return -1;

            return this.Name.CompareTo(other.Name);
        }
    }
}