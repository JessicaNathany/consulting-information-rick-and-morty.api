namespace consulting_information_rickmorty.api.Models
{
    public class CharacterLocation
    {
        /// <summary>
        /// Gets name to the character's last known location.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets link to the character's last known location.
        /// </summary>
        public Uri Url { get; }
    }
}
