using UnityEngine.UIElements;
using UnityEngine;

namespace FluentVisualElement
{
    public static class VisualElementExtensions
    {
        public static T WithChildren<T>(this T element, params VisualElement[] children)
            where T : VisualElement
        {
            foreach (var child in children)
            {
                element.Add(child);
            }
            return element;
        }

        public static T Name<T>(this T element, string name)
            where T : VisualElement
        {
            element.name = name;
            return element;
        }

        public static T ClassName<T>(this T element, string className)
            where T : VisualElement
        {
            element.AddToClassList(className);
            return element;
        }

        public static T StyleSheet<T>(this T element, StyleSheet styleSheet)
            where T : VisualElement
        {
            element.styleSheets.Add(styleSheet);
            return element;
        }

        public static T Color<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.color = color;
            return element;
        }

        public static T BackgroundColor<T>(this T element, StyleColor backgroundColor)
            where T : VisualElement
        {
            element.style.backgroundColor = backgroundColor;
            return element;
        }

        public static T BackgroundImage<T>(this T element, StyleBackground backgroundImage)
            where T : VisualElement
        {
            element.style.backgroundImage = backgroundImage;
            return element;
        }

        public static T BackgroundPositionX<T>(this T element, StyleBackgroundPosition backgroundPosition)
            where T : VisualElement
        {
            element.style.backgroundPositionX = backgroundPosition;
            return element;
        }

        public static T BackgroundPositionY<T>(this T element, StyleBackgroundPosition backgroundPosition)
            where T : VisualElement
        {
            element.style.backgroundPositionY = backgroundPosition;
            return element;
        }

        public static T BackgroundSize<T>(this T element, StyleBackgroundSize backgroundSize)
            where T : VisualElement
        {
            element.style.backgroundSize = backgroundSize;
            return element;
        }

        public static T BackgroundRepeat<T>(this T element, StyleBackgroundRepeat backgroundRepeat)
            where T : VisualElement
        {
            element.style.backgroundRepeat = backgroundRepeat;
            return element;
        }

        public static T Opacity<T>(this T element, StyleFloat opacity)
            where T : VisualElement
        {
            element.style.opacity = opacity;
            return element;
        }

        public static T Visibility<T>(this T element, StyleEnum<Visibility> visibility)
            where T : VisualElement
        {
            element.style.visibility = visibility;
            return element;
        }

        public static T Display<T>(this T element, StyleEnum<DisplayStyle> display)
            where T : VisualElement
        {
            element.style.display = display;
            return element;
        }

        public static T Material<T>(this T element, StyleMaterialDefinition material)
            where T : TextElement
        {
            element.style.unityMaterial = material;
            return element;
        }

        public static T Width<T>(this T element, StyleLength width)
            where T : VisualElement
        {
            element.style.width = width;
            return element;
        }

        public static T Height<T>(this T element, StyleLength height)
            where T : VisualElement
        {
            element.style.height = height;
            return element;
        }

        public static T MinWidth<T>(this T element, StyleLength minWidth)
            where T : VisualElement
        {
            element.style.minWidth = minWidth;
            return element;
        }

        public static T MinHeight<T>(this T element, StyleLength minHeight)
            where T : VisualElement
        {
            element.style.minHeight = minHeight;
            return element;
        }

        public static T MaxWidth<T>(this T element, StyleLength maxWidth)
            where T : VisualElement
        {
            element.style.maxWidth = maxWidth;
            return element;
        }

        public static T MaxHeight<T>(this T element, StyleLength maxHeight)
            where T : VisualElement
        {
            element.style.maxHeight = maxHeight;
            return element;
        }

        public static T Top<T>(this T element, StyleLength top)
            where T : VisualElement
        {
            element.style.top = top;
            return element;
        }

        public static T Bottom<T>(this T element, StyleLength bottom)
            where T : VisualElement
        {
            element.style.bottom = bottom;
            return element;
        }

        public static T Left<T>(this T element, StyleLength left)
            where T : VisualElement
        {
            element.style.left = left;
            return element;
        }

        public static T Right<T>(this T element, StyleLength right)
            where T : VisualElement
        {
            element.style.right = right;
            return element;
        }

        public static T Position<T>(this T element, Position position)
            where T : VisualElement
        {
            element.style.position = position;
            return element;
        }

        public static T Translate<T>(this T element, StyleTranslate translate)
            where T : VisualElement
        {
            element.style.translate = translate;
            return element;
        }

        public static T Rotate<T>(this T element, StyleRotate rotate)
            where T : VisualElement
        {
            element.style.rotate = rotate;
            return element;
        }

        public static T Scale<T>(this T element, StyleScale scale)
            where T : VisualElement
        {
            element.style.scale = scale;
            return element;
        }

        public static T TransformOrigin<T>(this T element, StyleTransformOrigin transformOrigin)
            where T : VisualElement
        {
            element.style.transformOrigin = transformOrigin;
            return element;
        }

        public static T TransitionDelay<T>(this T element, StyleList<TimeValue> transitionDelay)
            where T : VisualElement
        {
            element.style.transitionDelay = transitionDelay;
            return element;
        }

        public static T TransitionDuration<T>(this T element, StyleList<TimeValue> transitionDuration)
            where T : VisualElement
        {
            element.style.transitionDuration = transitionDuration;
            return element;
        }

        public static T TransitionProperty<T>(this T element, StyleList<StylePropertyName> transitionProperty)
            where T : VisualElement
        {
            element.style.transitionProperty = transitionProperty;
            return element;
        }

        public static T TransitionTimingFunction<T>(this T element, StyleList<EasingFunction> transitionTimingFunction)
            where T : VisualElement
        {
            element.style.transitionTimingFunction = transitionTimingFunction;
            return element;
        }

        public static T Filter<T>(this T element, StyleList<FilterFunction> filter)
            where T : VisualElement
        {
            element.style.filter = filter;
            return element;
        }

        public static T Slice<T>(this T element, StyleInt slice)
            where T : VisualElement
        {
            element.style.unitySliceTop = slice;
            element.style.unitySliceBottom = slice;
            element.style.unitySliceLeft = slice;
            element.style.unitySliceRight = slice;
            return element;
        }

        public static T Slice<T>(this T element, StyleInt top, StyleInt bottom, StyleInt left, StyleInt right)
            where T : VisualElement
        {
            element.style.unitySliceTop = top;
            element.style.unitySliceBottom = bottom;
            element.style.unitySliceLeft = left;
            element.style.unitySliceRight = right;
            return element;
        }

        public static T SliceTop<T>(this T element, StyleInt sliceTop)
            where T : VisualElement
        {
            element.style.unitySliceTop = sliceTop;
            return element;
        }

        public static T SliceBottom<T>(this T element, StyleInt sliceBottom)
            where T : VisualElement
        {
            element.style.unitySliceBottom = sliceBottom;
            return element;
        }

        public static T SliceLeft<T>(this T element, StyleInt sliceLeft)
            where T : VisualElement
        {
            element.style.unitySliceLeft = sliceLeft;
            return element;
        }

        public static T SliceRight<T>(this T element, StyleInt sliceRight)
            where T : VisualElement
        {
            element.style.unitySliceRight = sliceRight;
            return element;
        }

        public static T AspectRatio<T>(this T element, StyleRatio aspectRatio)
            where T : VisualElement
        {
            element.style.aspectRatio = aspectRatio;
            return element;
        }

        public static T Overflow<T>(this T element, StyleEnum<Overflow> overflow)
            where T : VisualElement
        {
            element.style.overflow = overflow;
            return element;
        }

        public static T Text<T>(this T element, string text)
            where T : TextElement
        {
            element.text = text;
            return element;
        }

        public static T FontSize<T>(this T element, StyleLength fontSize)
            where T : TextElement
        {
            element.style.fontSize = fontSize;
            return element;
        }

        public static T Bold<T>(this T element)
            where T : TextElement
        {
            switch (element.style.unityFontStyleAndWeight.value)
            {
                case UnityEngine.FontStyle.Normal:
                    element.style.unityFontStyleAndWeight = UnityEngine.FontStyle.Bold;
                    break;
                case UnityEngine.FontStyle.Italic:
                    element.style.unityFontStyleAndWeight = UnityEngine.FontStyle.BoldAndItalic;
                    break;
                case UnityEngine.FontStyle.Bold:
                case UnityEngine.FontStyle.BoldAndItalic:
                    break;
            }
            return element;
        }

        public static T Italic<T>(this T element)
            where T : TextElement
        {
            switch (element.style.unityFontStyleAndWeight.value)
            {
                case UnityEngine.FontStyle.Normal:
                    element.style.unityFontStyleAndWeight = UnityEngine.FontStyle.Italic;
                    break;
                case UnityEngine.FontStyle.Bold:
                    element.style.unityFontStyleAndWeight = UnityEngine.FontStyle.BoldAndItalic;
                    break;
                case UnityEngine.FontStyle.Italic:
                case UnityEngine.FontStyle.BoldAndItalic:
                    break;
            }
            return element;
        }

        public static T FontStyle<T>(this T element, StyleEnum<FontStyle> fontStyle)
            where T : TextElement
        {
            element.style.unityFontStyleAndWeight = fontStyle;
            return element;
        }

        public static T Font<T>(this T element, StyleFont font)
            where T : TextElement
        {
            element.style.unityFont = font;
            return element;
        }

        public static T Font<T>(this T element, FontDefinition font)
            where T : TextElement
        {
            element.style.unityFontDefinition = font;
            return element;
        }

        public static T TextAutoSize<T>(this T element, StyleTextAutoSize textAutoSize)
            where T : TextElement
        {
            element.style.unityTextAutoSize = textAutoSize;
            return element;
        }

        public static T TextShadow<T>(this T element, StyleTextShadow textShadow)
            where T : TextElement
        {
            element.style.textShadow = textShadow;
            return element;
        }

        public static T TextOverflow<T>(this T element, StyleEnum<TextOverflow> textOverflow)
            where T : TextElement
        {
            element.style.textOverflow = textOverflow;
            return element;
        }

        public static T TextAlign<T>(this T element, StyleEnum<TextAnchor> align)
            where T : TextElement
        {
            element.style.unityTextAlign = align;
            return element;
        }

        public static T TextOutlineColor<T>(this T element, StyleColor textOutlineColor)
            where T : TextElement
        {
            element.style.unityTextOutlineColor = textOutlineColor;
            return element;
        }

        public static T TextOutlineWidth<T>(this T element, StyleFloat textOutlineWidth)
            where T : TextElement
        {
            element.style.unityTextOutlineWidth = textOutlineWidth;
            return element;
        }

        public static T TextOverflowPosition<T>(this T element, StyleEnum<TextOverflowPosition> textOverflowPosition)
            where T : TextElement
        {
            element.style.unityTextOverflowPosition = textOverflowPosition;
            return element;
        }

        public static T TextGenerator<T>(this T element, StyleEnum<TextGeneratorType> textGenerator)
            where T : TextElement
        {
            element.style.unityTextGenerator = textGenerator;
            return element;
        }

        public static T WhiteSpace<T>(this T element, StyleEnum<WhiteSpace> whiteSpace)
            where T : TextElement
        {
            element.style.whiteSpace = whiteSpace;
            return element;
        }

        public static T LetterSpacing<T>(this T element, StyleLength letterSpacing)
            where T : TextElement
        {
            element.style.letterSpacing = letterSpacing;
            return element;
        }

        public static T WordSpacing<T>(this T element, StyleLength wordSpacing)
            where T : TextElement
        {
            element.style.wordSpacing = wordSpacing;
            return element;
        }

        public static T ParagraphSpacing<T>(this T element, StyleLength paragraphSpacing)
            where T : TextElement
        {
            element.style.unityParagraphSpacing = paragraphSpacing;
            return element;
        }

        public static T Margin<T>(this T element, StyleLength margin)
            where T : VisualElement
        {
            element.style.marginTop = margin;
            element.style.marginBottom = margin;
            element.style.marginLeft = margin;
            element.style.marginRight = margin;
            return element;
        }

        public static T Margin<T>(this T element, StyleLength marginTop, StyleLength marginBottom, StyleLength marginLeft, StyleLength marginRight)
            where T : VisualElement
        {
            element.style.marginTop = marginTop;
            element.style.marginBottom = marginBottom;
            element.style.marginLeft = marginLeft;
            element.style.marginRight = marginRight;
            return element;
        }

        public static T MarginX<T>(this T element, StyleLength marginX)
            where T : VisualElement
        {
            element.style.marginLeft = marginX;
            element.style.marginRight = marginX;
            return element;
        }

        public static T MarginY<T>(this T element, StyleLength marginY)
            where T : VisualElement
        {
            element.style.marginTop = marginY;
            element.style.marginBottom = marginY;
            return element;
        }

        public static T MarginTop<T>(this T element, StyleLength marginTop)
            where T : VisualElement
        {
            element.style.marginTop = marginTop;
            return element;
        }

        public static T MarginBottom<T>(this T element, StyleLength marginBottom)
            where T : VisualElement
        {
            element.style.marginBottom = marginBottom;
            return element;
        }

        public static T MarginLeft<T>(this T element, StyleLength marginLeft)
            where T : VisualElement
        {
            element.style.marginLeft = marginLeft;
            return element;
        }

        public static T MarginRight<T>(this T element, StyleLength marginRight)
            where T : VisualElement
        {
            element.style.marginRight = marginRight;
            return element;
        }

        public static T Padding<T>(this T element, StyleLength padding)
            where T : VisualElement
        {
            element.style.paddingTop = padding;
            element.style.paddingBottom = padding;
            element.style.paddingLeft = padding;
            element.style.paddingRight = padding;
            return element;
        }

        public static T Padding<T>(this T element, StyleLength paddingTop, StyleLength paddingBottom, StyleLength paddingLeft, StyleLength paddingRight)
            where T : VisualElement
        {
            element.style.paddingTop = paddingTop;
            element.style.paddingBottom = paddingBottom;
            element.style.paddingLeft = paddingLeft;
            element.style.paddingRight = paddingRight;
            return element;
        }

        public static T PaddingX<T>(this T element, StyleLength paddingX)
            where T : VisualElement
        {
            element.style.paddingLeft = paddingX;
            element.style.paddingRight = paddingX;
            return element;
        }

        public static T PaddingY<T>(this T element, StyleLength paddingY)
            where T : VisualElement
        {
            element.style.paddingTop = paddingY;
            element.style.paddingBottom = paddingY;
            return element;
        }

        public static T PaddingTop<T>(this T element, StyleLength paddingTop)
            where T : VisualElement
        {
            element.style.paddingTop = paddingTop;
            return element;
        }

        public static T PaddingBottom<T>(this T element, StyleLength paddingBottom)
            where T : VisualElement
        {
            element.style.paddingBottom = paddingBottom;
            return element;
        }

        public static T PaddingLeft<T>(this T element, StyleLength paddingLeft)
            where T : VisualElement
        {
            element.style.paddingLeft = paddingLeft;
            return element;
        }

        public static T PaddingRight<T>(this T element, StyleLength paddingRight)
            where T : VisualElement
        {
            element.style.paddingRight = paddingRight;
            return element;
        }

        public static T AlignItems<T>(this T element, Align align)
            where T : VisualElement
        {
            element.style.alignItems = align;
            return element;
        }

        public static T AlignSelf<T>(this T element, Align align)
            where T : VisualElement
        {
            element.style.alignSelf = align;
            return element;
        }

        public static T AlignContent<T>(this T element, Align align)
            where T : VisualElement
        {
            element.style.alignContent = align;
            return element;
        }

        public static T FlexBasis<T>(this T element, Length flexBasis)
            where T : VisualElement
        {
            element.style.flexBasis = flexBasis;
            return element;
        }

        public static T FlexWrap<T>(this T element, Wrap wrap)
            where T : VisualElement
        {
            element.style.flexWrap = wrap;
            return element;
        }

        public static T FlexDirection<T>(this T element, FlexDirection direction)
            where T : VisualElement
        {
            element.style.flexDirection = direction;
            return element;
        }

        public static T FlexGrow<T>(this T element, StyleFloat flexGrow)
            where T : VisualElement
        {
            element.style.flexGrow = flexGrow;
            return element;
        }

        public static T FlexShrink<T>(this T element, StyleFloat flexShrink)
            where T : VisualElement
        {
            element.style.flexShrink = flexShrink;
            return element;
        }

        public static T BorderWidth<T>(this T element, StyleFloat width)
            where T : VisualElement
        {
            element.style.borderTopWidth = width;
            element.style.borderBottomWidth = width;
            element.style.borderLeftWidth = width;
            element.style.borderRightWidth = width;
            return element;
        }

        public static T BorderWidth<T>(this T element, StyleFloat top, StyleFloat bottom, StyleFloat left, StyleFloat right)
            where T : VisualElement
        {
            element.style.borderTopWidth = top;
            element.style.borderBottomWidth = bottom;
            element.style.borderLeftWidth = left;
            element.style.borderRightWidth = right;
            return element;
        }

        public static T BorderTopWidth<T>(this T element, StyleFloat width)
            where T : VisualElement
        {
            element.style.borderTopWidth = width;
            return element;
        }

        public static T BorderBottomWidth<T>(this T element, StyleFloat width)
            where T : VisualElement
        {
            element.style.borderBottomWidth = width;
            return element;
        }

        public static T BorderLeftWidth<T>(this T element, StyleFloat width)
            where T : VisualElement
        {
            element.style.borderLeftWidth = width;
            return element;
        }

        public static T BorderRightWidth<T>(this T element, StyleFloat width)
            where T : VisualElement
        {
            element.style.borderRightWidth = width;
            return element;
        }

        public static T BorderColor<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.borderTopColor = color;
            element.style.borderBottomColor = color;
            element.style.borderLeftColor = color;
            element.style.borderRightColor = color;
            return element;
        }

        public static T BorderColor<T>(this T element, StyleColor top, StyleColor bottom, StyleColor left, StyleColor right)
            where T : VisualElement
        {
            element.style.borderTopColor = top;
            element.style.borderBottomColor = bottom;
            element.style.borderLeftColor = left;
            element.style.borderRightColor = right;
            return element;
        }

        public static T BorderTopColor<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.borderTopColor = color;
            return element;
        }

        public static T BorderBottomColor<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.borderBottomColor = color;
            return element;
        }

        public static T BorderLeftColor<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.borderLeftColor = color;
            return element;
        }

        public static T BorderRightColor<T>(this T element, StyleColor color)
            where T : VisualElement
        {
            element.style.borderRightColor = color;
            return element;
        }

        public static T BorderRadius<T>(this T element, StyleLength radius)
            where T : VisualElement
        {
            element.style.borderTopLeftRadius = radius;
            element.style.borderTopRightRadius = radius;
            element.style.borderBottomLeftRadius = radius;
            element.style.borderBottomRightRadius = radius;
            return element;
        }

        public static T BorderRadius<T>(this T element, StyleLength topLeft, StyleLength topRight, StyleLength bottomLeft, StyleLength bottomRight)
            where T : VisualElement
        {
            element.style.borderTopLeftRadius = topLeft;
            element.style.borderTopRightRadius = topRight;
            element.style.borderBottomLeftRadius = bottomLeft;
            element.style.borderBottomRightRadius = bottomRight;
            return element;
        }

        public static T BorderTopLeftRadius<T>(this T element, StyleLength radius)
            where T : VisualElement
        {
            element.style.borderTopLeftRadius = radius;
            return element;
        }

        public static T BorderTopRightRadius<T>(this T element, StyleLength radius)
            where T : VisualElement
        {
            element.style.borderTopRightRadius = radius;
            return element;
        }

        public static T BorderBottomLeftRadius<T>(this T element, StyleLength radius)
            where T : VisualElement
        {
            element.style.borderBottomLeftRadius = radius;
            return element;
        }

        public static T BorderBottomRightRadius<T>(this T element, StyleLength radius)
            where T : VisualElement
        {
            element.style.borderBottomRightRadius = radius;
            return element;
        }

        public static T Cursor<T>(this T element, StyleCursor cursor)
            where T : VisualElement
        {
            element.style.cursor = cursor;
            return element;
        }

        public static T OverflowClipBox<T>(this T element, StyleEnum<OverflowClipBox> overflowClipBox)
            where T : VisualElement
        {
            element.style.unityOverflowClipBox = overflowClipBox;
            return element;
        }

        public static T OnClick<T>(this T element, System.Action action)
            where T : Button
        {
            element.clicked += action;
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<bool>> action)
            where T : BaseField<bool>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<int>> action)
            where T : BaseField<int>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<float>> action)
            where T : BaseField<float>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<string>> action)
            where T : BaseField<string>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Vector2>> action)
            where T : BaseField<Vector2>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Vector2Int>> action)
            where T : BaseField<Vector2Int>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Vector3>> action)
            where T : BaseField<Vector3>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Vector3Int>> action)
            where T : BaseField<Vector3Int>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Vector4>> action)
            where T : BaseField<Vector4>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Color>> action)
            where T : BaseField<Color>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Bounds>> action)
            where T : BaseField<Bounds>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Rect>> action)
            where T : BaseField<Rect>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T>(this T element, EventCallback<ChangeEvent<Quaternion>> action)
            where T : BaseField<Quaternion>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }

        public static T OnValueChanged<T, U>(this T element, EventCallback<ChangeEvent<U>> action)
            where T : BaseField<U>
        {
            element.RegisterValueChangedCallback(action);
            return element;
        }
    }
}