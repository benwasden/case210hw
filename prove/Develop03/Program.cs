// This main program is a bit large because I decided to make this program centered around helping seminary students memorize the hardest doctrinal mastery passage.
// (At least it was for me :-) ). Rather than having just one verse, it lets the user memorize the whole verse and then moves onto the next one for all 6 verses that are displayed.
// I'm sure I could have written another class or a function to consolidate each verse and that would have been neater, but I was having issues with that and this was working so I just left as is.
// I also added a checker in the Scripture class as well that checks to make sure there's at least 3 words that aren't hidden before hiding. If there aren't, it sets numberToHide to the remaining word count.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("JSH", 1, 15);
        Scripture scripture = new Scripture(reference, "After I had retired to the place where I had previously designed to go, having looked around me, and finding myself alone, I kneeled down and began to offer up the desires of my heart to God. I had scarcely done so, when immediately I was seized upon by some power which entirely overcame me, and had such an astonishing influence over me as to bind my tongue so that I could not speak. Thick darkness gathered around me, and it seemed to me for a time as if I were doomed to sudden destruction.");

        Console.Clear();
        Console.WriteLine("----Joseph Smith--History 1:15-20 Doctrinal Mastery Memorizer----");
        Console.WriteLine("This program goes verse by verse in the Joseph Smith History Doctrinal Mastery to help Seminary students memorize it.");
        Console.WriteLine();
        Console.WriteLine("Verse 15");
        Console.WriteLine();
        Console.Write(reference.GetDisplayText("JSH", 1, 15, 15));
        Console.WriteLine(scripture.GetDisplayText());

        // while (scripture.IsCompletelyHidden() == false)
        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 15");
                    Console.WriteLine();
                    Console.Write(reference.GetDisplayText("JSH", 1, 15, 15));
                    Console.WriteLine(scripture.GetDisplayText());
                }
            }
        }
        
        Reference reference2 = new Reference("JSH", 1, 16);
        Scripture scripture2 = new Scripture(reference2, "But, exerting all my powers to call upon God to deliver me out of the power of this enemy which had seized upon me, and at the very moment when I was ready to sink into despair and abandon myself to destruction—not to an imaginary ruin, but to the power of some actual being from the unseen world, who had such marvelous power as I had never before felt in any being—just at this moment of great alarm, I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me.");

        Console.Clear();
        Console.WriteLine("Verse 16");
        Console.WriteLine();
        Console.Write(reference2.GetDisplayText("JSH", 1, 16, 16));
        Console.WriteLine(scripture2.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture2.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture2.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 16");
                    Console.WriteLine();
                    Console.Write(reference2.GetDisplayText("JSH", 1, 16, 16));
                    Console.WriteLine(scripture2.GetDisplayText());
                }
            }      
        }

        Reference reference3 = new Reference("JSH", 1, 17);
        Scripture scripture3 = new Scripture(reference3, "It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—This is My Beloved Son. Hear Him!");

        Console.Clear();
        Console.WriteLine("Verse 17");
        Console.WriteLine();
        Console.Write(reference3.GetDisplayText("JSH", 1, 17, 17));
        Console.WriteLine(scripture3.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture3.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture3.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 17");
                    Console.WriteLine();
                    Console.Write(reference3.GetDisplayText("JSH", 1, 17, 17));
                    Console.WriteLine(scripture3.GetDisplayText());
                }
            }      
        }

        Reference reference4 = new Reference("JSH", 1, 18);
        Scripture scripture4 = new Scripture(reference4, "My object in going to inquire of the Lord was to know which of all the sects was right, that I might know which to join. No sooner, therefore, did I get possession of myself, so as to be able to speak, than I asked the Personages who stood above me in the light, which of all the sects was right (for at this time it had never entered into my heart that all were wrong)—and which I should join.");

        Console.Clear();
        Console.WriteLine("Verse 18");
        Console.WriteLine();
        Console.Write(reference4.GetDisplayText("JSH", 1, 18, 18));
        Console.WriteLine(scripture4.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture4.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture4.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 18");
                    Console.WriteLine();
                    Console.Write(reference4.GetDisplayText("JSH", 1, 18, 18));
                    Console.WriteLine(scripture4.GetDisplayText());
                }
            }      
        }

        Reference reference5 = new Reference("JSH", 1, 19);
        Scripture scripture5 = new Scripture(reference5, "I was answered that I must join none of them, for they were all wrong; and the Personage who addressed me said that all their creeds were an abomination in his sight; that those professors were all corrupt; that: 'they draw near to me with their lips, but their hearts are far from me, they teach for doctrines the commandments of men, having a form of godliness, but they deny the power thereof.'");

        Console.Clear();
        Console.WriteLine("Verse 19");
        Console.WriteLine();
        Console.Write(reference5.GetDisplayText("JSH", 1, 19, 19));
        Console.WriteLine(scripture5.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture5.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture5.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 19");
                    Console.WriteLine();
                    Console.Write(reference5.GetDisplayText("JSH", 1, 19, 19));
                    Console.WriteLine(scripture5.GetDisplayText());
                }
            }      
        }

        Reference reference6 = new Reference("JSH", 1, 20);
        Scripture scripture6 = new Scripture(reference6, "He again forbade me to join with any of them; and many other things did he say unto me, which I cannot write at this time. When I came to myself again, I found myself lying on my back, looking up into heaven. When the light had departed, I had no strength; but soon recovering in some degree, I went home. And as I leaned up to the fireplace, mother inquired what the matter was. I replied, 'Never mind, all is well—I am well enough off.' I then said to my mother, 'I have learned for myself that Presbyterianism is not true.' It seems as though the adversary was aware, at a very early period of my life, that I was destined to prove a disturber and an annoyer of his kingdom; else why should the powers of darkness combine against me? Why the opposition and persecution that arose against me, almost in my infancy?");

        Console.Clear();
        Console.WriteLine("Verse 20");
        Console.WriteLine();
        Console.Write(reference6.GetDisplayText("JSH", 1, 20, 20));
        Console.WriteLine(scripture6.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                if (scripture6.IsCompletelyHidden() == true)
                {
                    Console.WriteLine("Nice job! Good luck with memorization!");
                    break;
                }
                else
                {
                    scripture6.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("Verse 20");
                    Console.WriteLine();
                    Console.Write(reference6.GetDisplayText("JSH", 1, 20, 20));
                    Console.WriteLine(scripture6.GetDisplayText());
                }
            }      
        }
    }
}