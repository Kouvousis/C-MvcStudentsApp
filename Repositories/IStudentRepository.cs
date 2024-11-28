using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Course>> GetStudentCoursesAsync(int id);
        Task<Student?> GetByAM(string? am);
        Task<List<User>> GetAllUsersStudentsAsync();

    }
}
