using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using FluentVisualElement;
using FluentVisualElement.Editor;

[CustomEditor(typeof(Sandbox))]
public class SandboxEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        return new VisualElement()
            .WithChildren(
                new VisualElement()
                    .FlexGrow(1f)
                    .MarginRight(5f)
                    .WithChildren(
                        new Label("Foo")
                            .Bold()
                            .TextAlign(TextAnchor.MiddleCenter),
                        new FloatField()
                            .BindTo(serializedObject, "foo")
                            .OnValueChanged(x =>
                            {
                                Debug.Log($"Foo {x.previousValue} -> {x.newValue}");
                            })
                    ),
                new VisualElement()
                    .FlexGrow(1f)
                    .MarginRight(5f)
                    .WithChildren(
                        new Label("Bar")
                            .Bold()
                            .TextAlign(TextAnchor.MiddleCenter),
                        new TextField()
                            .BindTo(serializedObject, "bar")
                            .OnValueChanged(x =>
                            {
                                Debug.Log($"Bar {x.previousValue} -> {x.newValue}");
                            })
                    ),
                new VisualElement()
                    .FlexGrow(1f)
                    .WithChildren(
                        new Label("Baz")
                            .Bold()
                            .TextAlign(TextAnchor.MiddleCenter),
                        new Vector3Field()
                            .BindTo(serializedObject, "baz")
                            .OnValueChanged(x =>
                            {
                                Debug.Log($"Baz {x.previousValue} -> {x.newValue}");
                            })
                    )
            ).FlexDirection(FlexDirection.Row);
    }
}