using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FancyCard.Models
{
    /// <summary>
    /// Fancy Card class.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Unique Identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Card title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Card description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Message for card.
        /// </summary>
        public CardMessage Message { get; set; }

        /// <summary>
        /// Background image.
        /// </summary>
        public Image Background { get; set; }
    }
}
