using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.Utility
{
    public class SD
    {
        //Add any const variables here
        public const string AdminRole = "Admin";
        public const string RaterRole = "Rater";
        public const string AttendeeRole = "Attendee";
        public const string ApplicantRole = "Applicant";

        //criteria
        public const int MaxRating = 5;
        public const int MinRating = 1;

        //criteria description
        public const string InfoContribution = "Abstract provides valuable insights for teacher education.";
        public const string InfoConferenceFit = "Abstract is directly related to teacher education.";
        public const string InfoMechanics = "Abstract is clear, succinct, and well-organized. Abstract honors the standard rules of correct grammar, punctuation, spelling, and formatting.";

        //user statuses
        public const string Initial = "INITIAL";
        public const string AbstractSubmitted = "SUBMITTED";
        public const string AbstractApproved = "APPROVED";
        public const string AbstractRejected = "REJECTED";
        public const string Registered = "REGISTERED";
        public const string Paid = "PAID";
        public const string Admin = "ADMIN";
        public const string Rater = "RATER";

        //prices
        public const int DevelopedCountry = 1500;
        public const int UndevelopedCountry = 1200;
        public const int GuestPrice = 500;

        //uploads
        public const double MaxUploadMB = 1;
    }
}
