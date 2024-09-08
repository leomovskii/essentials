using System.Collections;
using UnityEngine;

namespace Essentials {
	public static class MonoBeh {

		public static void StartCoroutineSafe(this MonoBehaviour origin, ref Coroutine coroutine, IEnumerator routine) {
			if (coroutine != null)
				origin.StopCoroutine(coroutine);
			coroutine = origin.StartCoroutine(routine);
		}

		public static T GetOrAddComponent<T>(this MonoBehaviour origin) where T : Component {
			return origin.TryGetComponent<T>(out T instance) ? instance : origin.gameObject.AddComponent<T>();
		}
	}
}