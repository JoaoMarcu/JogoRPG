using System;

public class Arte
{
    public const string desenho = """
                   _.--.    .--._
                 ."  ."      ".  ".
                ;  ."    /\    ".  ;
                ;  '._,-/  \-,_.`  ;
                \  ,`  / /\ \  `,  /
                 \/    \/  \/    \/
                 ,=_    \/\/    _=,
                 |  "_   \/   _"  |
                 |_   '"-..-"'   _|
                 | "-.        .-" |
                 |    "\    /"    |
                 |      |  |      |
         ___     |      |  |      |     ___
     _,-",  ",   '_     |  |     _'   ,"  ,"-,_
   _(  \  \   \"=--"-.  |  |  .-"--="/   /  /  )_
 ,"  \  \  \   \      "-'--'-"      /   /  /  /  ".
!     \  \  \   \                  /   /  /  /     !
:      \  \  \   \                /   /  /  /      :
""";

    public const string escrito = (@"
  ____ _        _    ____ ___   _    ____   ___  ____  
 / ___| |      / \  |  _ \_ _| / \  |  _ \ / _ \|  _ \ 
| |  _| |     / _ \ | | | | | / _ \ | | | | | | | |_) |
| |_| | |___ / ___ \| |_| | |/ ___ \| |_| | |_| |  _ < 
 \____|_____/_/   \_\____/__/_/   \_\____/ \___/|_| \_\
");

    public void ExibirArte()
    {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(desenho);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(escrito);

            Console.Write("Clique Enter para começar o jogo:");
            Console.ReadLine();
            Console.Clear();

            Console.ResetColor();
    }
}