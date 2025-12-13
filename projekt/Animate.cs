

namespace Animation {

    public abstract class Animate {

        public void animate () {
            while (true) {
                nextFrame();
                Thread.Sleep(100);
            }
        } 

        protected abstract void nextFrame ();

    }
}