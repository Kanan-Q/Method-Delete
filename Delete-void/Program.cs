using static System.Console;
namespace Delete_void
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World";
            string result = Delete(sentence);
            WriteLine(result);
        }

        static string Delete(string sentence)
        {
            string newSentence = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    newSentence += sentence[i];
                }
            }

            return newSentence;
        }
    }
}

