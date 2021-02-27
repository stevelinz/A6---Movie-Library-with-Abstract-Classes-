namespace A6_MovieOO.Models
{
    public class Show : Media
    {
        public override void Display()
        {

            InputFileShow input = new InputFileShow();
            input.ReadFile();
        }
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
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }
    }
}