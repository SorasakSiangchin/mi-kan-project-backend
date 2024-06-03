using AutoMapper;
using mi_kan_project_backend.AppHelper;
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

            CreateMap<User, UserResponseDto>()
                .ForMember(cnd => cnd.ImageUrl ,
                opt => opt.MapFrom(src =>
                        !string.IsNullOrEmpty(src.ImageUrl) ? $"{GetConfigure.UserImageDir}/{src.ImageUrl}" : ""));

            CreateMap<Student, StudentDto>()
                .ForMember(cnd => cnd.ImageUrl ,
                opt => opt.MapFrom(src =>
                        !string.IsNullOrEmpty(src.ImageUrl) ? $"{GetConfigure.StudentImageDir}/{src.ImageUrl}" : ""));
        }
    }
}
