using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
namespace Essentials {
	[CustomPropertyDrawer(typeof(PreviewAttribute))]
	class SpritePreviewDrawer : PropertyDrawer {
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			var largePreview = (PreviewAttribute) attribute;
			return property.propertyType == SerializedPropertyType.ObjectReference && property.objectReferenceValue != null
				? EditorGUIUtility.singleLineHeight + largePreview.Size
				: EditorGUIUtility.singleLineHeight;
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			var largePreview = (PreviewAttribute) attribute;
			
			var labelRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
			EditorGUI.PropertyField(labelRect, property, label);

			if (property.propertyType == SerializedPropertyType.ObjectReference && property.objectReferenceValue is Sprite sprite) {
				var previewRect = new Rect(position.x, position.y + EditorGUIUtility.singleLineHeight, largePreview.Size, largePreview.Size);

				Texture2D texture = sprite.texture;
				Rect textureRect = sprite.textureRect;
				var uvRect = new Rect(textureRect.x / texture.width, textureRect.y / texture.height, textureRect.width / texture.width, textureRect.height / texture.height);

				GUI.DrawTextureWithTexCoords(previewRect, texture, uvRect, true);
			}
		}
	}
}
#endif