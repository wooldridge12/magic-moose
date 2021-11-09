using System;



Console.WriteLine("Welcome to the Magic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("To exit App just push the enter.");
Console.WriteLine();
MooseSays("HI, I'M MAGIC!!!");
MooseQuestion();

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


bool MagicMoose(string magic)
{
    Console.Write($"{magic}");
    string answer = Console.ReadLine().ToLower();
    

    if (answer != "")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseQuestion()
{
    bool isTrue = MagicMoose("Ask me a question as you would a magic 8 ball!:");
    if (isTrue)
    {
        //This is the Random methed it will randomly pick a number between 0-19.
        int randonnumber = 0;

        Random r = new Random();
        randonnumber = r.Next(1,20);
        Console.WriteLine("Random Number = "+randonnumber);

        //Here we are setting up case 1 so number 1 will invoke the console.writeline. This is how we are turning an int into a string in a way.
        switch (randonnumber)
        {
            case 1:
            Console.WriteLine("Ask again later.");
                break;
            case 2:
            Console.WriteLine("Better not tell you now.");
                break;
            case 3:
            Console.WriteLine("Cannot predict now.");
                break;
            case 4:
            Console.WriteLine("Concentrate and ask again.");
                break;
            case 5:
            Console.WriteLine("Don’t count on it.");
                break;
            case 6:
            Console.WriteLine("It is certain.");
                break;
            case 7:
            Console.WriteLine("It is decidedly so.");
                break;
            case 8:
            Console.WriteLine("Most likely.");
                break;
            case 9:
            Console.WriteLine("My reply is no.");
                break;
            case 10:
            Console.WriteLine("My sources say no.");
                break;
            case 11:
            Console.WriteLine("Outlook not so good.");
                break;
            case 12:
            Console.WriteLine("Outlook good.");
                break;
            case 13:
            Console.WriteLine("Reply hazy, try again.");
                break;
            case 14:
            Console.WriteLine("Signs point to yes.");
                break;
            case 15:
            Console.WriteLine("Very doubtful.");
                break;
            case 16:
            Console.WriteLine("Without a doubt.");
                break;
            case 17:
            Console.WriteLine("Yes.");
                break;
            case 18:
            Console.WriteLine("Yes – definitely.");
                break;
            case 19:
            Console.WriteLine("You may rely on it.");
                break;
            case 20:
            Console.WriteLine("As I see it, yes.");
                break;
            // default:
            //     break;
        }
        Console.ReadLine();
    }
    else{
        Environment.Exit(0);
    }
}