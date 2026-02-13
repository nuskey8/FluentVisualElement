using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace FluentVisualElement.Editor
{
    public static class EditorVisualElementExtensions
    {
        public static T BindTo<T>(this T element, SerializedProperty property)
            where T : BindableElement
        {
            element.BindProperty(property);
            return element;
        }

        public static T BindTo<T>(this T element, SerializedObject serializedObject, string propertyPath)
            where T : BindableElement
        {
            element.bindingPath = propertyPath;
            element.Bind(serializedObject);
            return element;
        }
    }
}