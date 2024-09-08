using UnityEngine.Networking;

namespace Essentials {
	public static class NetworkExtensions  {

		public static UnityWebRequestAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOp) {
			return new UnityWebRequestAwaiter(asyncOp);
		}
	}
}