using System;



Console.WriteLine("Welcome to the Magic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
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
        Random r = new Random();
        int genRand= r.Next(0,19);
        Console.WriteLine("Random Number = "+genRand);
        // MooseSays("HERE");
    }
    else{
        Environment.Exit(0);
        // MooseSays("This is not right");
    }
}