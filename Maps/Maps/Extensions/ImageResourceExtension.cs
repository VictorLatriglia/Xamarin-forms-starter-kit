using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maps.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var assembly = typeof(App);
            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, assembly);

            return imageSource;
        }
    }
}
