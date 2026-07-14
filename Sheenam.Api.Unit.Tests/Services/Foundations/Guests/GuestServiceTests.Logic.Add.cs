//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using FluentAssertions;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Unit.Tests.Services.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldAddGuestInWrongWayAsync()
        {
            //Arrange
            Guest randomGuest = new Guest
            {
                Id = Guid.NewGuid(),
                Address = "123 Main St",
                DateOfBirth = new DateTimeOffset(),
                Email = "radom@mail.ru",
                FirstName = "Alex",
                LastName = "Doe",
                Gender = GenderType.Male,
                PhoneNumber = "123-456-7890"
            };

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest))
                    .ReturnsAsync(randomGuest);
            //Act
            Guest actual = await this.guestService.AddGuestAsync(randomGuest);
            //Assert
            actual.Should().BeEquivalentTo(randomGuest);
        }

        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            // given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest = returningGuest;
            // when

            // then
        }
    }
}
