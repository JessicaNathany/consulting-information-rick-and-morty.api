namespace consulting_information_rickmorty.api.Models
{
    public class Episode
    {
        /// <summary>
        /// Gets the id of the episode.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the episode.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the air date of the episode.
        /// </summary>
        public DateTime? AirDate { get; }

        /// <summary>
        ///	Gets the code of the episode. 
        /// </summary>
        public string EpisodeCode { get; }

        /// <summary>
        /// Gets list of characters who have been seen in the episode.
        /// </summary>
        public IEnumerable<Uri> Characters { get; }

        /// <summary>
        /// Gets link to the episode's own endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the episode was created in the database.
        /// </summary>
        public DateTime? Created { get; }
    }
}
