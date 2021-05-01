using DeskBooker.Core.DataInterface;
using DeskBooker.Core.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        private readonly DeskBookingRequest _request;
        private readonly List<Desk> _availableDesks;
        private readonly DeskBookingRequestProcessor _processor;
        private readonly Mock<IDeskBookingRepository> _deskBookingRepositoryMock;
        private readonly Mock<IDeskRepository> _deskRepositoryMock;


        // in xunit the setup method is the constructor
        public DeskBookingRequestProcessorTests()
        {
            _request = new DeskBookingRequest()
            {
                FirstName = "First",
                LastName = "Last",
                Email = "a@a.com",
                Date = new DateTime(2020, 7, 8)
            };
            _availableDesks = new List<Desk> { new Desk {Id = 7 } };
            _deskBookingRepositoryMock = new Mock<IDeskBookingRepository>();
            _deskRepositoryMock = new Mock<IDeskRepository>();

            // lw 3ayza a5leha lama ta5od ay date trag3 el list ha7ot IsAny lakn lw 3ayzha trag3 el list f date el request bs
            // hab3tlha request.date
            _deskRepositoryMock.Setup(x => x.GetAvailableDesks(_request.Date))
                .Returns(_availableDesks);

            _processor = new DeskBookingRequestProcessor(_deskBookingRepositoryMock.Object, _deskRepositoryMock.Object);
        }
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValue()
        {
            //Act
            DeskBookingResult result = _processor.BookDesk(_request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(_request.FirstName, result.FirstName);
            Assert.Equal(_request.LastName, result.LastName);
            Assert.Equal(_request.Email, result.Email);
            Assert.Equal(_request.Date, result.Date);

        }

        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookDesk(null));

            //the test pass if the null exception thrown from request parameter
            Assert.Equal("request", exception.ParamName);
        }

        [Fact]
        public void ShouldSaveDataBooking()
        {
            DeskBooking savedDeskBooking = null;
            _deskBookingRepositoryMock.Setup(x => x.Save(It.IsAny<DeskBooking>()))
                .Callback<DeskBooking>( deskbooking =>
                {
                    savedDeskBooking = deskbooking;
                });
            _processor.BookDesk(_request);

            _deskBookingRepositoryMock.Verify(x => x.Save(It.IsAny<DeskBooking>()), Times.Once);

            Assert.NotNull(savedDeskBooking);
            Assert.Equal(_request.FirstName, savedDeskBooking.FirstName);
            Assert.Equal(_request.LastName, savedDeskBooking.LastName);
            Assert.Equal(_request.Email, savedDeskBooking.Email);
            Assert.Equal(_request.Date, savedDeskBooking.Date);
            Assert.Equal(_availableDesks.First().Id, savedDeskBooking.DeskId);

        }

        [Fact]
        public void ShouldNotSaveDataBookingIfDeskNotAvailable()
        {
            _availableDesks.Clear();

            _processor.BookDesk(_request);

            _deskBookingRepositoryMock.Verify(x => x.Save(It.IsAny<DeskBooking>()), Times.Never);

        }

        [Theory]
        [InlineData(DeskBookingResultCode.Success,true)]
        [InlineData(DeskBookingResultCode.NoDeskAvailable, false)]
        public void ShouldReturnExpectedResultCode(DeskBookingResultCode deskBookingResultCode, bool deskIsAvailable)
        {
            if(!deskIsAvailable)
            {
                _availableDesks.Clear();
            }
            var result = _processor.BookDesk(_request);
            Assert.Equal(deskBookingResultCode, result.Code);
        }

        [Theory]
        [InlineData(5, true)]
        [InlineData(null, false)]
        public void ShouldReturnExpectedDeskBookingId(int? deskBookingId, bool deskIsAvailable)
        {
            if (!deskIsAvailable)
            {
                _availableDesks.Clear();
            }
            else
            {
                _deskBookingRepositoryMock.Setup(x => x.Save(It.IsAny<DeskBooking>()))
                    .Callback<DeskBooking>(deskBooking =>
                    {
                        deskBooking.Id = deskBookingId.Value;
                    });
            }
            var result = _processor.BookDesk(_request);
            Assert.Equal(deskBookingId , result.DeskBookingId);
        }
    }
}
