using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.Models.ViewModels
{
    public class AbstractReviewVM
    {
        public Abstract Abstract { get; set; }
        public IEnumerable<AbstractRating> AbstractRatings { get; set; }
    }
}
