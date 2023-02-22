namespace consulting_information_rickmorty.api.Models
{
    public class Location
    {
        /// <summary>
        /// Gets the id of the location.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of the location.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the dimension in which the location is located.
        /// </summary>
        public string Dimension { get; }

        /// <summary>
        /// Gets list of character who have been last seen in the location.
        /// </summary>
        public IEnumerable<Uri> Residents { get; }

        /// <summary>
        /// Gets link to the location's own endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the location was created in the database. 
        /// </summary>
        public DateTime? Created { get; }
    }
}
