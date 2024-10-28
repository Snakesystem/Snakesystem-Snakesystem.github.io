namespace MyPortfolio
{
    public class CarouselItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
    }

    // Model untuk Keterampilan
    public class Skill
    {
        public string Name { get; set; }
    }

    public class ListPortfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }

        // List of programming languages associated with the portfolio
        public List<ProgrammingLanguage> ProgrammingLanguages { get; set; } = new List<ProgrammingLanguage>();
    }

    public class ProgrammingLanguage
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; } // URL of the image representing the programming language
    }

    public class Experiences
    {
        public ProgrammingLanguage Language { get; set; }
        public int YearsExperience { get; set; }
        public int Proficiency { get; set; } // 0 to 100
        public string? Category { get; set; } // URL of the image representing the programming language
    }
}
