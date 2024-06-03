using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace mi_kan_project_backend.Extenstions
{
    public static class StudentExtentions
    {
        public static IQueryable<Student> SearchName
            (this IQueryable<Student> students , string? studentName)
        {
            if(string.IsNullOrEmpty(studentName)) return students;

            var lowerCaseSearchNameTerm = studentName.Trim().ToLower();

            return students
                .Where(s => 
                    s.FirstName.ToLower().Contains(lowerCaseSearchNameTerm) || 
                    s.LastName.ToLower().Contains(lowerCaseSearchNameTerm));
        }

        public static IQueryable<Student> FilterByClassId
           (this IQueryable<Student> students, string? classId)
        {
            if (string.IsNullOrEmpty(classId)) return students;

            return students.Where(s => s.ClassId == Guid.Parse(classId));
        }

        public static IQueryable<Student> FilterByClassRoomId
            (this IQueryable<Student> students, string? classRoomId)
        {
            if (string.IsNullOrEmpty(classRoomId)) return students;

            return students.Where(s => s.ClassRoomId == Guid.Parse(classRoomId));
        }

        public static IQueryable<Student> FilterBySchoolYearId
            (this IQueryable<Student> students, string? schoolYearId)
        {
            if (string.IsNullOrEmpty(schoolYearId)) return students;

            return students.Where(s => s.SchoolYearId == Guid.Parse(schoolYearId));
        }

        public static IQueryable<Student> FilterByTermId
            (this IQueryable<Student> students, string? termId)
        {
            if (string.IsNullOrEmpty(termId)) return students;

            return students.Where(s => s.TermId == Guid.Parse(termId));
        }

        public static IQueryable<Student> FilterByGenderId
            (this IQueryable<Student> students, string? genderId)
        {
            if (string.IsNullOrEmpty(genderId)) return students;

            return students.Where(s => s.GenderId == Guid.Parse(genderId));
        }

        public static IQueryable<Student> FilterBySchoolId
            (this IQueryable<Student> students, string? schoolId)
        {
            if (string.IsNullOrEmpty(schoolId)) return students;

            return students.Where(s => s.SchoolId == Guid.Parse(schoolId));
        }

        public static IQueryable<Student> FilterIsAction
         (this IQueryable<Student> students, bool? isAction)
        {
            return students.Where(s => s.IsActive == isAction);
        }
    }
}
