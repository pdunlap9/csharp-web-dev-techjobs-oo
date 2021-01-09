using System;
namespace TechJobsOO
{
    public class CoreCompetency :JobField
    {
        //public int id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public CoreCompetency()
        //{
        //    id = nextId;
        //    nextId++;
        //}

        public CoreCompetency(string value) : base(value)
        {
          //  Value = value;
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency competency &&
        //           id == competency.id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}

