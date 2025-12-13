using System;

namespace Animation { 

    public class Main {
        //private static Animate animate;
    
        public static void main () {
        instructions:
            Console.WriteLine("Wybierz animacje:");
            Console.WriteLine("1 - œnierzynki");
            //...

            string answer = Console.ReadLine();

            try {
                int a = Convert.ToInt32(answer);
                switch (a) {
                case 1:
                    //animate = new SnowFlakes();
                    Console.WriteLine("Œnierzynki");
                    break;
                //...
                default:
                    throw new WrongOptionException();
                }
            } catch (Exception e) when (e is FormatException || e is WrongOptionException) {
                Console.WriteLine("Nieprawid³owa opcja");
                Console.WriteLine("***************************************************************************");
                goto instructions;
            }
        }

        private class WrongOptionException : Exception {
            public WrongOptionException () : base("wybrano z³¹ opcje") { }
        }

    }
}