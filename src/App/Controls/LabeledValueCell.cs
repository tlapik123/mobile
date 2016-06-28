﻿using Xamarin.Forms;

namespace Bit.App.Controls
{
    public class LabeledValueCell : ExtendedViewCell
    {
        public LabeledValueCell(
            string labelText = null,
            string valueText = null,
            string button1Text = null,
            string button2Text = null)
        {
            var containerStackLayout = new StackLayout
            {
                Padding = new Thickness(15, 10),
                Orientation = StackOrientation.Horizontal
            };

            var labelValueStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            if(labelText != null)
            {
                Label = new Label
                {
                    Text = labelText,
                    FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                    Style = (Style)Application.Current.Resources["text-muted"],
                    VerticalOptions = LayoutOptions.Start
                };

                labelValueStackLayout.Children.Add(Label);
            }

            Value = new Label
            {
                Text = valueText,
                LineBreakMode = LineBreakMode.TailTruncation,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            labelValueStackLayout.Children.Add(Value);

            containerStackLayout.Children.Add(labelValueStackLayout);

            var buttonStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };

            if(button1Text != null)
            {
                Button1 = new Button
                {
                    Text = button1Text,
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Center,
                    Margin = new Thickness(0)
                };

                buttonStackLayout.Children.Add(Button1);
            }

            if(button2Text != null)
            {
                Button2 = new Button
                {
                    Text = button2Text,
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Center,
                    Margin = new Thickness(0)
                };

                buttonStackLayout.Children.Add(Button2);
            }

            containerStackLayout.Children.Add(buttonStackLayout);

            View = containerStackLayout;
        }

        public Label Label { get; private set; }
        public Label Value { get; private set; }
        public Button Button1 { get; private set; }
        public Button Button2 { get; private set; }
    }
}
