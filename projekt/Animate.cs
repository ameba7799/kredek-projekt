

namespace Animation {

    public abstract class Animate {

        public void animate () {
            while (true) {
                Console.Clear();
                Console.Write(nextFrame());
                Thread.Sleep(100);
            }
        } 

        protected abstract string nextFrame ();

    }
}