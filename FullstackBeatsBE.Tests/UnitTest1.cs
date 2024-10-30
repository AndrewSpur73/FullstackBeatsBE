using FullstackBeatsBE.Interfaces;
using FullstackBeatsBE.Models;
using FullstackBeatsBE.Services;
using Moq;

namespace FullstackBeatsBE.Test
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
            Assert.Equal(2, result.Count);
        }
    }
}
