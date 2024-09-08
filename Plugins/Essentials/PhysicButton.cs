using UnityEngine;
using UnityEngine.Events;

namespace Essentials {
	public class PhysicButton : MonoBehaviour {

		[SerializeField] private UnityEvent _onClick;

		public UnityEvent OnClick => _onClick;

		private void OnMouseDown() {
			_onClick?.Invoke();
		}
	}
}