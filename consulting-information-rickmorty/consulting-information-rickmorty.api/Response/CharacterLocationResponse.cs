namespace consulting_information_rickmorty.api.Response
{
    internal class CharacterLocationResponse
    {
        /// <summary>
        /// Name to the character's last known location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's last known location.
        /// </summary>
        public string Url { get; set; }
    }
}
