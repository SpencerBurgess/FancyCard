using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FancyCard.Models
{
    /// <summary>
    /// Background Image Layer.
    /// This can be an image, gradient, or color, with a level of transparency.
    /// </summary>
    public class Layer
    {
        /// <summary>
        /// Background color in HEX code.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Background Image, this can be transparent.
        /// </summary>
        public Image BacgroundImage { get; set; }

        /// <summary>
        /// Image opacity
        /// </summary>
        public int Opacity { get; set; }

        /// <summary>
        /// Get rendered image of layer.
        /// </summary>
        /// <returns>Image object.</returns>
        public Image GetRenderedImage()
        {
            // Render background with Skia and return Image.
            return new Image();
        }
    }
}
