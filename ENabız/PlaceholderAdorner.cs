using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace ENabız
{
    public class PlaceholderAdorner : Adorner
    {
        public PlaceholderAdorner(TextBox textBox) : base(textBox) { }

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (AdornedElement is not TextBox textBoxControl)
                return;

            string placeholderValue = TextBoxHelper.GetPlaceholder(textBoxControl);
            if (string.IsNullOrEmpty(placeholderValue))
                return;

            var typeface = new Typeface(
                textBoxControl.FontFamily,
                textBoxControl.FontStyle,
                textBoxControl.FontWeight,
                textBoxControl.FontStretch
            );

            var formattedText = new FormattedText(
                placeholderValue,
                CultureInfo.CurrentCulture,
                textBoxControl.FlowDirection,
                typeface,
                textBoxControl.FontSize,
                SystemColors.GrayTextBrush, // Daha okunabilir bir renk
                VisualTreeHelper.GetDpi(textBoxControl).PixelsPerDip
            )
            {
                MaxTextWidth = Math.Max(textBoxControl.ActualWidth - textBoxControl.Padding.Left - textBoxControl.Padding.Right, 10),
                MaxTextHeight = Math.Max(textBoxControl.ActualHeight, 10)
            };

            // Başlangıç koordinatı
            Point renderingOffset = new Point(textBoxControl.Padding.Left, textBoxControl.Padding.Top);

            // Template üzerinden hizalama ayarı
            if (textBoxControl.Template.FindName("PART_ContentHost", textBoxControl) is FrameworkElement part)
            {
                Point partPosition = part.TransformToAncestor(textBoxControl).Transform(new Point(0, 0));
                renderingOffset.X += partPosition.X;
                renderingOffset.Y += partPosition.Y;

                formattedText.MaxTextWidth = Math.Max(part.ActualWidth - renderingOffset.X, 10);
                formattedText.MaxTextHeight = Math.Max(part.ActualHeight, 10);
            }

            // Ortaya hizalama
            renderingOffset.X = (textBoxControl.ActualWidth - formattedText.Width) / 2;
            renderingOffset.Y = (textBoxControl.ActualHeight - formattedText.Height) / 2;

            drawingContext.DrawText(formattedText, renderingOffset);
        }
    }
}
