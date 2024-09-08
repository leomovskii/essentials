using System.Collections.Generic;
using System.Linq;

namespace Essentials {
	public static class Collections {

		public static T Random<T>(this List<T> origin) {
			return origin != null && origin.Any() ? origin[UnityEngine.Random.Range(0, origin.Count)] : default;
		}

		/// <summary>iterationsCount less 1 is same as list size</summary>
		public static void Shuffle<T>(this IList<T> origin, int iterationsCount = 0) {
			iterationsCount = iterationsCount <= 0 ? origin.Count : iterationsCount;
			for (int i = 0; i < iterationsCount; i++) {
				int random = UnityEngine.Random.Range(i, iterationsCount);
				(origin[i], origin[random]) = (origin[random], origin[i]);
			}
		}
	}
}