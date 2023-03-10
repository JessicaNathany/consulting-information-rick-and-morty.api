using consulting_information_rickmorty.api.Enums;

namespace consulting_information_rickmorty.api.Models
{
    public class Character
    {
        /// <summary>
        /// Gets the id of the character.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the status of the character ('Alive', 'Dead' or 'unknown').
        /// </summary>
        public CharacterStatus Status { get; }

        /// <summary>
        /// Gets the species of the character.
        /// </summary>
        public string Species { get; }

        /// <summary>
        /// Gets the type or subspecies of the character.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the gender of the character ('Female', 'Male', 'Genderless' or 'unknown').
        /// </summary>
        public CharacterGender Gender { get; }

        /// <summary>
        /// Gets name and link to the character's last known location endpoint.
        /// </summary>
        public CharacterLocation Location { get; }

        /// <summary>
        /// Gets name and link to the character's origin location.
        /// </summary>
        public CharacterOrigin Origin { get; }

        /// <summary>
        /// Gets link to the character's image. All images are 300x300px and most are medium shots or portraits since they are intended to be used as avatars.
        /// </summary>
        public Uri Image { get; }

        /// <summary>
        /// Gets list of episodes in which this character appeared.
        /// </summary>
        public IEnumerable<Uri> Episode { get; }

        /// <summary>
        /// Gets link to the character's own URL endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the character was created in the database.
        /// </summary>
        public DateTime? Created { get; }
    }
}
