namespace mi_kan_project_backend.Services.TermService
{
    public interface ITermService
    {
        Task<List<Term>> GetTermAll();
    }
}
