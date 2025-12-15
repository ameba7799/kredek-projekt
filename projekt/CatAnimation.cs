

namespace Animation {

    public class CatAnimation : Animate {

        private const string prefix = "C:\\Users\\User\\Desktop\\studia\\kredek\\projekt\\projekt\\pliki\\koty\\banner";
        private const string sufix = ".txt";
        private const int filesNumber = 12;

        private List<string> frames;
        private int iterator;

        public CatAnimation() {
            frames = new List<string>(12);
            iterator = 0;
            readframes();
        }

        private void readframes () {
            try {
                for (int i = 1; i <= filesNumber; i++) {
                    frames.Add(File.ReadAllText(prefix + i + sufix));
                }
            } catch (Exception e) {
                Console.WriteLine("B³¹d: problem z wczytywaniem animacji kota");
            }
        }

        protected override string nextFrame () { 
            if (iterator == frames.Count) {
                iterator = 0;
            }

            return frames[iterator++];
        }
    }
}