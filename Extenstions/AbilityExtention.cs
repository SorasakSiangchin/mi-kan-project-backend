namespace mi_kan_project_backend.Extenstions
{
    public static class AbilityExtention
    {
        public static IQueryable<Ability> FilterBySchoolId(this IQueryable<Ability> abilities , string? schoolId)
        {
            if(string.IsNullOrEmpty(schoolId)) return abilities;

            abilities = abilities.Where(a => a.Student.SchoolId == Guid.Parse(schoolId));

            return abilities;
        }
        //public string? MultipleIntelligencesId { get; set; }
 

        // ค้นหาจากชื่อนักเรียน
        // TODO : เพื่อได้ใช้
        public static IQueryable<Ability> FilterByStudentName(this IQueryable<Ability> abilities, string? name)
        {
            if (string.IsNullOrEmpty(name)) return abilities;

            var lowerAndTrimText = name.Trim().ToLower();

            abilities = abilities.Where(a => 
                a.Student.FirstName.ToLower().Contains(lowerAndTrimText) || 
                a.Student.LastName.ToLower().Contains(lowerAndTrimText));

            return abilities;
        }


        public static IQueryable<Ability> FilterByClassId(this IQueryable<Ability> abilities, string? classId)
        {
            if (string.IsNullOrEmpty(classId)) return abilities;

            abilities = abilities.Where(a => a.Student.ClassId == Guid.Parse(classId));

            return abilities;
        }

        // ค้นหานักเรียนจากความสามารถ
        public static IQueryable<Ability> FilterByMultipleIntelligencesId (this IQueryable<Ability> abilities, string? MultipleIntelligencesId)
        {
            if (string.IsNullOrEmpty(MultipleIntelligencesId)) return abilities;

            abilities = abilities.Where(a => a.MultipleIntelligencesId == Guid.Parse(MultipleIntelligencesId));

            return abilities;
        }

        // ค้นหานักเรียนจากชั้นเรียน
        public static IQueryable<Ability> FilterByClassRoomId(this IQueryable<Ability> abilities, string? classRoomId)
        {
            if (string.IsNullOrEmpty(classRoomId)) return abilities;

            abilities = abilities.Where(a => a.Student.ClassRoomId == Guid.Parse(classRoomId));

            return abilities;
        }

        // ค้นหานักเรียนจากชั้นเรียน
        public static IQueryable<Ability> FilterByGenderId(this IQueryable<Ability> abilities, string? genderId)
        {
            if (string.IsNullOrEmpty(genderId)) return abilities;

            abilities = abilities.Where(a => a.Student.GenderId == Guid.Parse(genderId));

            return abilities;
        }
    }
}
