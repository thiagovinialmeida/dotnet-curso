namespace Ex14.Entites
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate() { }
        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Candidate)) { return false; }
            Candidate other = (Candidate)obj;
            return Name.Equals(other.Name);
        }

    }
}

