using MessagePack;

namespace Homies.Data.Constants
{
    public static class Validation
    {
        /// <summary>
        /// Maximal name length
        /// </summary>
        public const int EventNameMaxLength = 20;

        /// <summary>
        /// Minimal name length
        /// </summary>
        public const int EventNameMinLength = 5;

        /// <summary>
        /// Maximal event description length
        /// </summary>
        public const int MaxEventDescriptionLength = 150;

        /// <summary>
        /// Minimal event description length
        /// </summary>
        public const int MinEventDescriptionLength = 15;

        public const string DateFormat = "yyyy-MM-dd H:mm";

        public const int MaxTypeNameLength = 15;

        public const int MinTypeNameLength = 5;
    }
}
