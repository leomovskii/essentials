using UnityEditor;
using UnityEngine;
using System.Reflection;

#if UNITY_EDITOR
namespace Essentials {

	[CustomPropertyDrawer(typeof(ShowIfAttribute))]
	public class ShowIfDrawer : PropertyDrawer {

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			var showIf = (ShowIfAttribute) attribute;
			bool shouldShow = false;

			var target = property.serializedObject.targetObject;
			var memberInfo = target.GetType().GetMember(showIf.Condition, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)[0];

			if (memberInfo != null) {
				switch (memberInfo.MemberType) {
					case MemberTypes.Method:
					var method = (MethodInfo) memberInfo;
					shouldShow = (bool) method.Invoke(target, null);
					break;

					case MemberTypes.Field:
					var field = (FieldInfo) memberInfo;
					shouldShow = (bool) field.GetValue(target);
					break;

					case MemberTypes.Property:
					var propertyInfo = (PropertyInfo) memberInfo;
					shouldShow = (bool) propertyInfo.GetValue(target);
					break;
				}
			}

			if (shouldShow)
				EditorGUI.PropertyField(position, property, label, true);
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			var showIf = (ShowIfAttribute) attribute;
			var target = property.serializedObject.targetObject;

			bool shouldShow = false;
			var memberInfo = target.GetType().GetMember(showIf.Condition, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)[0];

			if (memberInfo != null) {
				switch (memberInfo.MemberType) {
					case MemberTypes.Method:
					var method = (MethodInfo) memberInfo;
					shouldShow = (bool) method.Invoke(target, null);
					break;

					case MemberTypes.Field:
					var field = (FieldInfo) memberInfo;
					shouldShow = (bool) field.GetValue(target);
					break;

					case MemberTypes.Property:
					var propertyInfo = (PropertyInfo) memberInfo;
					shouldShow = (bool) propertyInfo.GetValue(target);
					break;
				}
			}

			return shouldShow ? EditorGUI.GetPropertyHeight(property, label, true) : -EditorGUIUtility.standardVerticalSpacing;
		}
	}
}
#endif