namespace Epicenter.Models
{
    public class EpisodeViewModel : ShowViewModel
    {
        public int EpisodeId { get; set; }
        public int EpisodeNumber { get; set; }
        public int SeasonNumber { get; set; }
        public double EpisodeRating { get; set; }
        public string Description { get; set; }
    }
}
