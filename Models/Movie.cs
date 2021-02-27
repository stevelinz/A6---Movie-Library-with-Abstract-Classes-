namespace A6_MovieOO.Models
{
    public class Movie : Media
    {
        public override void Display()
        {
            InputFileMovie input = new InputFileMovie();
            input.ReadFile();
        }

        // override properties

        public override int Id
        {
            get
            {
                return 0;
            }
        }

        public override string Title
        {
            get
            {
                return "";
            }
        }

        public string[] Genres { get; }
    }


}