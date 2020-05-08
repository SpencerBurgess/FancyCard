using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FancyCard.Models
{
    /// <summary>
    /// Special card message.
    /// </summary>
    public class CardMessage
    {
        /// <summary>
        /// Lines in messsage.
        /// </summary>
        public List<Label> Lines { get; set; }
    }
}
