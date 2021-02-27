
namespace A6_MovieOO.Models
{
    public class Program
    {
        static void Main(string[] args)
        {

        GoAgain:
            System.Console.WriteLine("View: [M]ovie, [S]how, [V]ideo, [E]xit");

            string typePick = System.Console.ReadLine();

            if (typePick == "V" || typePick == "v")
            {

                InputFileVideo input2 = new InputFileVideo();
                input2.Display();
            }
            else if (typePick == "M" || typePick == "m")
            {
                InputFileMovie input = new InputFileMovie();
                input.Display();
            }
            else if (typePick == "S" || typePick == "s")
            {
                InputFileShow input3 = new InputFileShow();
                input3.Display();
            }
            else if (typePick == "E" || typePick == "e")
            {
                System.Environment.Exit(0);
            }
            if (typePick != "E" || typePick != "e")
            {
                goto GoAgain;
            }
        }

    }

}














