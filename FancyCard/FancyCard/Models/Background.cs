using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FancyCard.Models
{
    /// <summary>
    /// Background image data model.
    /// </summary>
    public class Background
    {
        /// <summary>
        /// Background layers.
        /// </summary>
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// Compile background layers and get overall background image.
        /// </summary>
        /// <returns>Image object.</returns>
        public Image GetImage()
        {
            return LayersToImage();
        }

        private Image LayersToImage()
        {
            throw new NotImplementedException();
        }
    }
}
