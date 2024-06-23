using AutoMapper;

namespace mi_kan_project_backend.Extenstions
{
    public static class MultipleIntelligencesExtentions
    {
        public static IQueryable<MultipleIntelligences> MultipleIntelligencesInsertStudent
                (this IQueryable<MultipleIntelligences> multipleIntelligences , IMapper mapper , string? schoolId)
        {
 
            return multipleIntelligences;
        }
    }
}
