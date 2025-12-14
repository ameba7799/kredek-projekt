

namespace Animation {

    public class SnowFlakes {

        private const string dir = "C:\\Users\\User\\Desktop\\studia\\kredek\\projekt\\projekt\\pliki\\platki_sniegu";
        private Random rnd;

        private List<List<string>> flakes;

        private int currentFlake;
        private int currentShiftX;
        private int currentShiftY;
        private int iterator;

        public SnowFlakes () {
            flakes = new List<List<string>>(17);
            readFlakes();

            rnd = new Random();
            restartFlake();
        }


        private void readFlakes () {
            try {
                foreach (string file in Directory.GetFiles(dir)) {
                    List<string> picture = new List<string>();

                    foreach (string line in File.ReadAllLines(file)) {
                        picture.Add(line);
                    }

                    picture.Reverse();
                    flakes.Add(picture);
                }
            } catch (Exception e) {
                Console.WriteLine("B³¹d: problem z wczytywaniem p³atków œniegu");
            }
        }

        private void restartFlake() {
            iterator = 0;
            currentFlake = rnd.Next(flakes.Count);
            currentShiftX = rnd.Next(1, 10) * 10;
            currentShiftY = rnd.Next(1, 5);
        }

        public string nextLine() {
            if (iterator == flakes[currentFlake].Count + currentShiftY) {
                restartFlake();
            }

            string line = new string(' ', currentShiftX);

            if (iterator < flakes[currentFlake].Count) {
                line = line + flakes[currentFlake][iterator];
            }

            iterator++;
            return line;
        }
    }
}