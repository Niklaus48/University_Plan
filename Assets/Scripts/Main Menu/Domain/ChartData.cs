using System;
using System.Collections.Generic;

namespace Main_Menu.Domain
{
    public struct ChartData : IEquatable<ChartData>
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public List<int> PlanIds { get; set; }

        public bool Equals(ChartData other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            return obj is ChartData other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Note, PlanIds);
        }
    }
}