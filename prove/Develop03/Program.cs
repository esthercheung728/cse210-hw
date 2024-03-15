using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "5 Trust in the Lord with all your heart and lean not on your own understanding; 6 in all your ways submit to him, and he will make your paths straight.");
        library.AddScripture(new Reference("Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        library.AddScripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        library.AddScripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest.");
        library.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}