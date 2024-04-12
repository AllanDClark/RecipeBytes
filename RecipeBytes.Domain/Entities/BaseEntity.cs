using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBytes.Domain.Entities
{
    public abstract class BaseEntity
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsSoftDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not BaseEntity other)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (GetUnproxiedType(this) != GetUnproxiedType(other))
                return false;
            if (Id.Equals(default) || other.Id.Equals(default))
                return false;
            return Id.Equals(other.Id);
        }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetUnproxiedType(this).ToString() + Id).GetHashCode();
        }

        internal static Type GetUnproxiedType(object obj)
        {
            Type type = obj.GetType();
            string typeString = type.ToString();

            if (typeString.Contains("Castle.Proxies"))
                return type.BaseType;
            return type;
        }
    }
}
