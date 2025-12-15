

namespace Animation { 

    public class Main {

        private static Animate animateObject;
    
        public static void main () {
        instructions:
            Console.WriteLine("Wybierz animacje:");
            Console.WriteLine("1 - œnierzynki");
            Console.WriteLine("2 - kot");
            //...

            string answer = Console.ReadLine();

            try {
                int a = Convert.ToInt32(answer);
                switch (a) {
                case 1:
                    animateObject = new SnowFlakesAnimation();
                    break;
                case 2:
                    animateObject = new CatAnimation();
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

            
            animateObject.animate();
        }

        private class WrongOptionException : Exception {
            public WrongOptionException () : base("wybrano z³¹ opcje") { }
        }
    }
}