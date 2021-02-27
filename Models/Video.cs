namespace A6_MovieOO.Models
{
    public class Video : Media
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
                return 3;
            }
        }
        public override string Title
        {
            get
            {
                return "";
            }
        }
        public string Format { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }
    }

}
