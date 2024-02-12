namespace TaskBoardApp.Data
{
    /// <summary>
	/// Constants values for model validation
	/// </summary>
    public static class DataConstants
    {
        public static class TaskConstants
        {
            /// <summary>
            /// Maximal Title length
            /// </summary>
            public const int MaxTitleLength = 70;

            /// <summary>
            /// Minimal Title length
            /// </summary>
            public const int MinTitleLength = 5;

            /// <summary>
            /// Maximal Description length
            /// </summary>
            public const int MaxDescriptionLength = 1000;

            /// <summary>
            /// Minimal Description legth
            /// </summary>
            public const int MinDescriptionLength = 10;
        }

        public static class BoardConstants
        {
            /// <summary>
            /// Maximal board name length
            /// </summary>
            public const int MaxBoardNameLength = 30;

            /// <summary>
            /// Minimal board name length
            /// </summary>
            public const int MinBoardNameLength = 3;
        }
    }
}
