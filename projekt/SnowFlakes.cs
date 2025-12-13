

namespace Animation {

    public class SnowFlakes : Animate {

        private List<SnowFlake> flakes;

        public SnowFlakes() {
            flakes = new List<SnowFlake>();

            try {
                foreach (string file in Directory.GetFiles("C:\\Users\\User\\Desktop\\studia\\kredek\\projekt\\projekt\\pliki\\platki_sniegu")) {
                    readFile(file);
                }
            } catch (Exception e) {
                Console.WriteLine("B³¹d: problem z wczytywaniem p³atków œniegu");
            }
        }

        private void readFile(string file) {
            List<string> picture = new List<string>();

            foreach (string line in File.ReadAllLines(file)) {
                picture.Add(line);
            }

            flakes.Add(new SnowFlake(picture));
        }

        protected override void nextFrame () {
            Console.WriteLine("sf - animation");
        }
    }
}