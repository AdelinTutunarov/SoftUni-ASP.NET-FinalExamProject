namespace MoviesWatchlist.Common
{
    public static class EntityValidationConstants
    {
        public static class Genre
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class Person
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;
            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
            public const int NationalityMinLength = 3;
            public const int NationalityMaxLength = 50;
        }

        public static class Movie 
        {
            public const int TitleMinLength = 1;
            public const int TitleMaxLength = 200;
            public const int ReleaseYearMinValue = 1900;
            public const int ReleaseYearMaxValue = 2024;
            public const int RatingMinValue = 1;
            public const int RatingMaxValue = 10;
            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 1000;
            public const int ImageURLMinLength = 5;
            public const int ImageURLMaxLength = 2048;
        }
    }
}
