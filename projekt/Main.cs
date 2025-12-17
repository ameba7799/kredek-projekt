

namespace Animation { 

    public class Main {

        private static Animate animateObject;
    
        public static void main () {
        instructions:
            Console.WriteLine("Wybierz animacje:");
            Console.WriteLine((int) Options.SNOW + " - " + Options.SNOW.description());
            Console.WriteLine((int) Options.CAT + " - " + Options.CAT.description());
//            Console.WriteLine("3 - Nasionko")
            //...

            string answer = Console.ReadLine();

            try {
                switch (Enum.Parse(typeof(Options), answer)) {
                case Options.SNOW:
                    animateObject = new SnowFlakesAnimation();
                    break;
                case Options.CAT:
                    animateObject = new CatAnimation();
                    break;
//                case 3:
//                    animateObject = new PlantAnimation();
//                    break;
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

    public enum Options {
            SNOW = 1,
            CAT = 2
    }

    public static class OptionsExtensions {
        public static string description (this Options option) {
            switch (option) {
            case Options.SNOW:
                return "Pada œnieg";
            case Options.CAT:
                return "Kotek";
            default:
                return "";
            }
        }
    }
}