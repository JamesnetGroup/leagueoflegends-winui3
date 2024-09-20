using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Windows.Foundation;

namespace Jamesnet.WinUI3
{

    public class CustomWrapPanel : Panel
    {
        public static readonly DependencyProperty HorizontalSpacingProperty =
            DependencyProperty.Register(nameof(HorizontalSpacing), typeof(double), typeof(CustomWrapPanel),
                new PropertyMetadata(0.0, OnSpacingChanged));

        public static readonly DependencyProperty VerticalSpacingProperty =
            DependencyProperty.Register(nameof(VerticalSpacing), typeof(double), typeof(CustomWrapPanel),
                new PropertyMetadata(0.0, OnSpacingChanged));

        public double HorizontalSpacing
        {
            get => (double)GetValue(HorizontalSpacingProperty);
            set => SetValue(HorizontalSpacingProperty, value);
        }

        public double VerticalSpacing
        {
            get => (double)GetValue(VerticalSpacingProperty);
            set => SetValue(VerticalSpacingProperty, value);
        }

        private static void OnSpacingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomWrapPanel panel)
            {
                panel.InvalidateMeasure();
            }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            double curLineWidth = 0;
            double curLineHeight = 0;
            double panelWidth = 0;
            double panelHeight = 0;
            bool isFirstInLine = true;

            foreach (UIElement child in Children)
            {
                child.Measure(availableSize);
                Size childSize = child.DesiredSize;

                if (curLineWidth + childSize.Width > availableSize.Width && !isFirstInLine)
                {
                    panelWidth = Math.Max(panelWidth, curLineWidth - HorizontalSpacing);
                    panelHeight += curLineHeight + VerticalSpacing;
                    curLineWidth = childSize.Width;
                    curLineHeight = childSize.Height;
                    isFirstInLine = true;
                }
                else
                {
                    curLineWidth += childSize.Width + (isFirstInLine ? 0 : HorizontalSpacing);
                    curLineHeight = Math.Max(curLineHeight, childSize.Height);
                    isFirstInLine = false;
                }
            }

            panelWidth = Math.Max(panelWidth, curLineWidth);
            panelHeight += curLineHeight;

            return new Size(panelWidth, panelHeight);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            double curX = 0;
            double curY = 0;
            double curLineHeight = 0;
            bool isFirstInLine = true;

            foreach (UIElement child in Children)
            {
                Size childSize = child.DesiredSize;

                if (curX + childSize.Width > finalSize.Width && !isFirstInLine)
                {
                    curY += curLineHeight + VerticalSpacing;
                    curX = 0;
                    curLineHeight = 0;
                    isFirstInLine = true;
                }

                child.Arrange(new Rect(curX, curY, childSize.Width, childSize.Height));
                curX += childSize.Width + (isFirstInLine ? 0 : HorizontalSpacing);
                curLineHeight = Math.Max(curLineHeight, childSize.Height);
                isFirstInLine = false;
            }

            return finalSize;
        }
    }
}