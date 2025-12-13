

namespace Animation {

	public class SnowFlake {

		private List<string> picture;
		private int i = 0;

		public SnowFlake (List<string> picture) {
			this.picture = picture;
		}

		public string getNextLine () {
			if (i < picture.Count) {
				return picture[i++];
			} else {
				return "";
			}
		}
	}
}
