//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class AlreadyExistsGuestException : Xeption
    {
        public AlreadyExistsGuestException(Exception innerException)
            : base(message: "Guest already exists", innerException)
        { }
    }
}
