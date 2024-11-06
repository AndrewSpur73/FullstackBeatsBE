using FullstackBeatsBE.Interfaces;
using FullstackBeatsBE.Models;
using FullstackBeatsBE.Services;
using FullstackBeatsBE.DTO;
using Moq;

namespace FullstackBeatsBE.Tests.CallTests
{
    public class ShowTests
    {

        private readonly Mock<IShowRepository> _mockShowRepository;
        private readonly IShowService _showService;

        public ShowTests()
        {
            _mockShowRepository = new Mock<IShowRepository>();
            _showService = new ShowService(_mockShowRepository.Object);
        }


        [Fact]
        public async Task GetShowsAsync_WhenCalled_ReturnShowsAsync()
        {
            var shows = new List<Show>
            {
                new Show {Id = 1 },
                new Show {Id = 2 },
                new Show {Id = 3 }
            };

            _mockShowRepository.Setup(x => x.GetAllShowsAsync()).ReturnsAsync(shows);

            var result = await _showService.GetAllShowsAsync();

            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public async Task CreateShowAsync_WhenCalled_ReturnNewShowAsync()
        {

            var showDTO = new CreateShowDTO
            {

                HostId = 1,
                Image = "string",
                Description = "more string",
                Rsvps = 7,
                AirDate = DateTime.Now,
                CategoryId = 2

            };

            var show = new Show
            {
                HostId = showDTO.HostId,
                Image = showDTO.Image,
                Description = showDTO.Description,
                Rsvps = showDTO.Rsvps,
                AirDate = showDTO.AirDate,
                CategoryId = showDTO.CategoryId,

            };

            _mockShowRepository.Setup(x => x.CreateShowAsync(showDTO)).ReturnsAsync(show);

            var result = await _showService.CreateShowAsync(showDTO);

            Assert.NotNull(result);
            Assert.Equal(showDTO.HostId, result.HostId);
            Assert.Equal(showDTO.Image, result.Image);
            Assert.Equal(showDTO.Description, result.Description);
            Assert.Equal(showDTO.Rsvps, result.Rsvps);
            Assert.Equal(showDTO.AirDate, result.AirDate);
            Assert.Equal(showDTO.CategoryId, result.CategoryId);

        }

        [Fact]
        public async Task UpdateShowAsync_WhenCalled_ReturnUpdateshowAsync()
        {

            int showid = 1;

            var show = new Show
            {
                HostId = showid,
                Image = "original string",
                Description = "more string",
                Rsvps = 7,
                AirDate = DateTime.Now,
                CategoryId = 2
            };

            var editShowDTO = new UpdateShowDTO
            {
                Image = "not string",
                Description = "less string",
                AirDate = DateTime.Now,
                CategoryId = 3
            };

            var updatedShow = new Show
            {
                Image = editShowDTO.Image,
                Description = editShowDTO.Description,
                AirDate = editShowDTO.AirDate,
                CategoryId = editShowDTO.CategoryId
            };

            _mockShowRepository.Setup(x => x.GetShowByIdAsync(showid)).ReturnsAsync(show);
            _mockShowRepository.Setup(x => x.UpdateShowAsync(showid, editShowDTO)).ReturnsAsync(updatedShow);

            var result = await _showService.UpdateShowAsync(showid, editShowDTO);

            Assert.NotNull(result);
            Assert.Equal(editShowDTO.Image, result.Image);
            Assert.Equal(editShowDTO.Description, result.Description);
            Assert.Equal(editShowDTO.AirDate, result.AirDate);
            Assert.Equal(editShowDTO.CategoryId, result.CategoryId);


        }

        [Fact]
        public async Task DeleteShowAsync_WhenCalled_ReturnDeletedShowAsync()
        {

            int showId = 1;

            var show = new Show
            {
                Id = showId
            };

            _mockShowRepository.Setup(x => x.GetShowByIdAsync(showId)).ReturnsAsync(show);

            await _showService.DeleteShowAsync(showId);

            _mockShowRepository.Verify(x => x.DeleteShowAsync(showId), Times.Once);

            _mockShowRepository.Setup(x => x.GetShowByIdAsync(showId)).ReturnsAsync((Show)null);

        }

        [Fact]
        public async Task GetSingleShowAsync_WhenCalled_ReturnsShow()
        {
            int showId = 1;
            var show = new Show
            {
                Id = 1,
                HostId = 2,
                Image = "image",
                Description = "Description",
                Rsvps = 10,
                AirDate = DateTime.Now,
                CategoryId = 2
            };

            // Setup the repository to return the expected show when requested
            _mockShowRepository.Setup(x => x.GetShowByIdAsync(showId)).ReturnsAsync(show);

            // Act
            var result = await _showService.GetShowByIdAsync(showId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(show.Id, result.Id);
            Assert.Equal(show.Description, result.Description);
            Assert.Equal(show.Image, result.Image);
            Assert.Equal(show.Rsvps, result.Rsvps);
            Assert.Equal(show.AirDate, result.AirDate);
            Assert.Equal(show.CategoryId, result.CategoryId);
        }
    }
}
