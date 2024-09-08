using VideoStore.Core;

namespace VideoStore.Data
{
    public class TestData : IVideoData
    {
        List<Video> _videoList;

        public TestData()
        {
            _videoList = new List<Video>()
            {
                new Video
                {
                    Id = 1, Title = "Movie Title 1",
                    ReleaseDate = new DateTime(2018, 1, 21),
                    Genre = MovieGenre.Action
                },
                new Video
                {
                    Id = 1, Title = "Movie Title 1",
                    ReleaseDate = new DateTime(2019, 3, 21),
                    Genre = MovieGenre.Drama
                },
                new Video
                {
                    Id = 3, Title = "Movie Title 3",
                    ReleaseDate = new DateTime(2020, 2, 21),
                    Genre = MovieGenre.Romance
                },
            };
            //  End of _videoList
        }
        //  End of TestData constructor.

        public IEnumerable<Video> ListVideos() => _videoList.OrderBy(x => x.Title);

    }
}
