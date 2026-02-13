# Fluent Visual Element
 Provides fluent extension methods for Unity UI Toolkit.

## Overview

Fluent Visual Element is a library that provides extension methods for constructing Visual Elements in Unity UI Toolkit with method chaining, making it easy to build UIs from C# scripts for editor extensions and other uses.

## Requirements

- Unity 6.0 or later

## Installation

Open the Package Manager and enter the following URL in `+` > `Add package from git URL...`:

```
https://github.com/nuskey8/FluentVisualElement.git?path=/Assets/FluentVisualElement
```

## Example

```cs
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
```

## License

This library is under the [MIT License](LICENSE).