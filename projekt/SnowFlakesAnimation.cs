

namespace Animation {

    public class SnowFlakesAnimation : Animate {

        private SnowFlakes flakes;
        private Queue<string> frameParts;

        public SnowFlakesAnimation () {
            frameParts = new Queue<string>(50);
            flakes = new SnowFlakes();

            for (int i = 0; i < 50; i++) {
                frameParts.Enqueue("");
            }
        }

        protected override string nextFrame () {
            string frame = "";

            foreach (string s in frameParts) {
                frame = s + '\n' + frame;
            }

            changeFrame();
            return frame;
        }

        private void changeFrame() {
            frameParts.Dequeue();
            frameParts.Enqueue(flakes.nextLine());
        }
    }
}


