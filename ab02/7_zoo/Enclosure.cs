namespace zoo
{
    internal class Enclosure
    {
        // Size in square meters
        public double Size;
        public int MaxAnimals;
        public int YearOfConstruction;
        public List<Keeper> Keepers;
        public List<Animal> animals;
        /*public double Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int MaxAnimals
        {
            get
            {
                return maxAnimals;
            }
            set
            {
                maxAnimals = value;
            }
        }
        public int YearOfConstruction
        {
            get
            {
                return yearOfConstruction;
            }
            set
            {
                yearOfConstruction = value;
            }
        }*/
    }
}