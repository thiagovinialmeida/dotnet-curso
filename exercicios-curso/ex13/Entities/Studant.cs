namespace Ex13.Entities
{
    internal class Studant
    {
        public int Id { get; set; }

        public Studant(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Studant))
            {
                return false;
            }
            Studant other = obj as Studant;

            return Id.Equals(other.Id);
        }
    }
}
