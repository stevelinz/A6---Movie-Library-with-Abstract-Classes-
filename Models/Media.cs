namespace A6_MovieOO.Models
{
    public abstract class Media
    {
        protected int _id = 0;
        protected string _title = "";

        // Abstract properties
        public abstract int Id { get; }
        public abstract string Title { get; }

        // Abstract method
        public abstract void Display();
    }


}
