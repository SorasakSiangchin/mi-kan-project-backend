using AutoMapper;
using mi_kan_project_backend.Dtos.Student;

namespace mi_kan_project_backend
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        { 
            CreateMap<CreateStudentDto , Student>().ReverseMap();

            CreateMap<UpdateStudentDto, Student>().ReverseMap();

            CreateMap<SchoolResponseDto, School>().ReverseMap();

            CreateMap<RegisterRequestDto, User>().ReverseMap();
        }
    }
}
