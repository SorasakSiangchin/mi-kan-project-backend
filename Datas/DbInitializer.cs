using mi_kan_project_backend.Models;

namespace mi_kan_project_backend.Datas
{
    public static class DbInitializer
    {
        public static async Task Initialize(DataContext context)
        {
            //if (!context.Students.Any())
            //{
            //    var students = new List<Student>
            //    {
            //        new Student
            //        {
            //            FirstName = "FirstName 01" ,
            //            LastName = "LastName 01" ,
            //            Email = "Email01@gmail.com",
            //            Address = "Address01" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl01" ,
            //            PhoneNumber = "0616032203" ,
            //            Hobby = "Hobby01" ,
            //            Religion = "Religion01" ,
            //            IdCard = "111111111111" ,
            //            ClassId = Guid.Parse("8D28BDF3-8A15-466C-AB16-DDFF8A0F47CD") ,
            //            ClassRoomId = Guid.Parse("147D58EA-F729-462D-B3DF-0C437836B2E8") ,
            //            GenderId = Guid.Parse("7EDA7B74-4C09-43CA-B9D4-5219A644A153") ,
            //            SchoolId = Guid.Parse("EFFEBFD5-ECBE-4993-BF31-20FAB7BE13AD") ,
            //            SchoolYearId = Guid.Parse("38F25C60-07D0-4706-AF73-94365A6E1FDB") ,
            //            TermId = Guid.Parse("3F654BD2-4303-41D5-A4A3-EDE8A4F80C41")
            //        } ,
            //        new Student
            //        {
            //            FirstName = "FirstName 02" ,
            //            LastName = "LastName 02" ,
            //            Email = "Email02@gmail.com",
            //            Address = "Address02" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl02" ,
            //            PhoneNumber = "0616032203" ,
            //            Hobby = "Hobby02" ,
            //            Religion = "Religion02" ,
            //            IdCard = "2222222222222" ,
            //            ClassId = Guid.Parse("8D28BDF3-8A15-466C-AB16-DDFF8A0F47CD") ,
            //            ClassRoomId = Guid.Parse("147D58EA-F729-462D-B3DF-0C437836B2E8") ,
            //            GenderId = Guid.Parse("7EDA7B74-4C09-43CA-B9D4-5219A644A153") ,
            //            SchoolId = Guid.Parse("EFFEBFD5-ECBE-4993-BF31-20FAB7BE13AD") ,
            //            SchoolYearId = Guid.Parse("38F25C60-07D0-4706-AF73-94365A6E1FDB") ,
            //            TermId = Guid.Parse("3F654BD2-4303-41D5-A4A3-EDE8A4F80C41")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 03" ,
            //            LastName = "LastName 03" ,
            //            Email = "Email03@gmail.com",
            //            Address = "Address03" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl03" ,
            //            PhoneNumber = "0616032203" ,
            //            Hobby = "Hobby03" ,
            //            Religion = "Religion03" ,
            //            IdCard = "3333333333333" ,
            //            ClassId = Guid.Parse("8D28BDF3-8A15-466C-AB16-DDFF8A0F47CD") ,
            //            ClassRoomId = Guid.Parse("147D58EA-F729-462D-B3DF-0C437836B2E8") ,
            //            GenderId = Guid.Parse("7EDA7B74-4C09-43CA-B9D4-5219A644A153") ,
            //            SchoolId = Guid.Parse("EFFEBFD5-ECBE-4993-BF31-20FAB7BE13AD") ,
            //            SchoolYearId = Guid.Parse("38F25C60-07D0-4706-AF73-94365A6E1FDB") ,
            //            TermId = Guid.Parse("3F654BD2-4303-41D5-A4A3-EDE8A4F80C41")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 04" ,
            //            LastName = "LastName 04" ,
            //            Email = "Email04@gmail.com",
            //            Address = "Address04" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl04" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby04" ,
            //            Religion = "Religion04" ,
            //            IdCard = "4444444444444" ,
            //            ClassId = Guid.Parse("8D28BDF3-8A15-466C-AB16-DDFF8A0F47CD") ,
            //            ClassRoomId = Guid.Parse("147D58EA-F729-462D-B3DF-0C437836B2E8") ,
            //            GenderId = Guid.Parse("7EDA7B74-4C09-43CA-B9D4-5219A644A153") ,
            //            SchoolId = Guid.Parse("EFFEBFD5-ECBE-4993-BF31-20FAB7BE13AD") ,
            //            SchoolYearId = Guid.Parse("38F25C60-07D0-4706-AF73-94365A6E1FDB") ,
            //            TermId = Guid.Parse("3F654BD2-4303-41D5-A4A3-EDE8A4F80C41")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 05" ,
            //            LastName = "LastName 05" ,
            //            Email = "Email05@gmail.com",
            //            Address = "Address05" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl05" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby05" ,
            //            Religion = "Religion05" ,
            //            IdCard = "5555555555555" ,
            //            ClassId = Guid.Parse("8D28BDF3-8A15-466C-AB16-DDFF8A0F47CD") ,
            //            ClassRoomId = Guid.Parse("147D58EA-F729-462D-B3DF-0C437836B2E8") ,
            //            GenderId = Guid.Parse("7EDA7B74-4C09-43CA-B9D4-5219A644A153") ,
            //            SchoolId = Guid.Parse("EFFEBFD5-ECBE-4993-BF31-20FAB7BE13AD") ,
            //            SchoolYearId = Guid.Parse("38F25C60-07D0-4706-AF73-94365A6E1FDB") ,
            //            TermId = Guid.Parse("3F654BD2-4303-41D5-A4A3-EDE8A4F80C41")
            //        },


            //        new Student
            //        {
            //            FirstName = "FirstName 06" ,
            //            LastName = "LastName 06" ,
            //            Email = "Email06@gmail.com",
            //            Address = "Address06" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl06" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby06" ,
            //            Religion = "Religion06" ,
            //            IdCard = "6666666666666" ,
            //            ClassId = Guid.Parse("80239CA8-A90E-4FD3-829D-E494B0A51879") ,
            //            ClassRoomId = Guid.Parse("B59FC659-9E33-4C9A-9CA0-13D0D1092A33") ,
            //            GenderId = Guid.Parse("93D14A1F-5ACB-423E-8DC5-9E46D2C387BC") ,
            //            SchoolId = Guid.Parse("D35C8B95-BA4B-4AE3-921A-F57353508CB3") ,
            //            SchoolYearId = Guid.Parse("7CDD6742-7E14-4C8A-B42A-CAD3305F5F79") ,
            //            TermId = Guid.Parse("BCAB1F1E-4BCC-4776-B701-D363CC2341DC")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 07" ,
            //            LastName = "LastName 07" ,
            //            Email = "Email07@gmail.com",
            //            Address = "Address07" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl07" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby07" ,
            //            Religion = "Religion07" ,
            //            IdCard = "7777777777777" ,
            //            ClassId = Guid.Parse("80239CA8-A90E-4FD3-829D-E494B0A51879") ,
            //            ClassRoomId = Guid.Parse("B59FC659-9E33-4C9A-9CA0-13D0D1092A33") ,
            //            GenderId = Guid.Parse("93D14A1F-5ACB-423E-8DC5-9E46D2C387BC") ,
            //            SchoolId = Guid.Parse("D35C8B95-BA4B-4AE3-921A-F57353508CB3") ,
            //            SchoolYearId = Guid.Parse("7CDD6742-7E14-4C8A-B42A-CAD3305F5F79") ,
            //            TermId = Guid.Parse("BCAB1F1E-4BCC-4776-B701-D363CC2341DC")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 08" ,
            //            LastName = "LastName 08" ,
            //            Email = "Email08@gmail.com",
            //            Address = "Address08" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl08" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby08" ,
            //            Religion = "Religion08" ,
            //            IdCard = "8888888888888" ,
            //            ClassId = Guid.Parse("80239CA8-A90E-4FD3-829D-E494B0A51879") ,
            //            ClassRoomId = Guid.Parse("B59FC659-9E33-4C9A-9CA0-13D0D1092A33") ,
            //            GenderId = Guid.Parse("93D14A1F-5ACB-423E-8DC5-9E46D2C387BC") ,
            //            SchoolId = Guid.Parse("D35C8B95-BA4B-4AE3-921A-F57353508CB3") ,
            //            SchoolYearId = Guid.Parse("7CDD6742-7E14-4C8A-B42A-CAD3305F5F79") ,
            //            TermId = Guid.Parse("BCAB1F1E-4BCC-4776-B701-D363CC2341DC")
            //        },

            //        new Student
            //        {
            //            FirstName = "FirstName 09" ,
            //            LastName = "LastName 09" ,
            //            Email = "Email09@gmail.com",
            //            Address = "Address09" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl09" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby09" ,
            //            Religion = "Religion09" ,
            //            IdCard = "9999999999999" ,
            //            ClassId = Guid.Parse("80239CA8-A90E-4FD3-829D-E494B0A51879") ,
            //            ClassRoomId = Guid.Parse("B59FC659-9E33-4C9A-9CA0-13D0D1092A33") ,
            //            GenderId = Guid.Parse("93D14A1F-5ACB-423E-8DC5-9E46D2C387BC") ,
            //            SchoolId = Guid.Parse("D35C8B95-BA4B-4AE3-921A-F57353508CB3") ,
            //            SchoolYearId = Guid.Parse("7CDD6742-7E14-4C8A-B42A-CAD3305F5F79") ,
            //            TermId = Guid.Parse("BCAB1F1E-4BCC-4776-B701-D363CC2341DC")
            //        },
            //        new Student
            //        {
            //            FirstName = "FirstName 10" ,
            //            LastName = "LastName 10" ,
            //            Email = "Email10@gmail.com",
            //            Address = "Address10" ,
            //            Birthday = DateTime.Now ,
            //            ImageUrl = "ImageUrl10" ,
            //            PhoneNumber = "0870226114" ,
            //            Hobby = "Hobby10" ,
            //            Religion = "Religion10" ,
            //            IdCard = "1010101010101" ,
            //            ClassId = Guid.Parse("80239CA8-A90E-4FD3-829D-E494B0A51879") ,
            //            ClassRoomId = Guid.Parse("B59FC659-9E33-4C9A-9CA0-13D0D1092A33") ,
            //            GenderId = Guid.Parse("93D14A1F-5ACB-423E-8DC5-9E46D2C387BC") ,
            //            SchoolId = Guid.Parse("D35C8B95-BA4B-4AE3-921A-F57353508CB3") ,
            //            SchoolYearId = Guid.Parse("7CDD6742-7E14-4C8A-B42A-CAD3305F5F79") ,
            //            TermId = Guid.Parse("BCAB1F1E-4BCC-4776-B701-D363CC2341DC")
            //        }
            //    };
            //    context.AddRange(students);
            //}

            //if (!context.Classes.Any())
            //{
            //    var classes = new List<Class> {  
            //        new Class()
            //        {
            //            ClassNameTh = "ป.1" ,
            //            ClassNameEn = "" ,
            //        } ,
            //         new Class()
            //        {
            //            ClassNameTh = "ป.2" ,
            //            ClassNameEn = "" ,
            //        },
            //          new Class()
            //        {
            //            ClassNameTh = "ป.3" ,
            //            ClassNameEn = "" ,
            //        },
            //           new Class()
            //        {
            //            ClassNameTh = "ป.4" ,
            //            ClassNameEn = "" ,
            //        },
            //            new Class()
            //        {
            //            ClassNameTh = "ป.5" ,
            //            ClassNameEn = "" ,
            //        },
            //             new Class()
            //        {
            //            ClassNameTh = "ป.6" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.1" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.2" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.3" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.4" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.5" ,
            //            ClassNameEn = "" ,
            //        },
            //              new Class()
            //        {
            //            ClassNameTh = "ม.6" ,
            //            ClassNameEn = "" ,
            //        }
            //    };

            //    context.AddRange(classes);
            //}

            //if (!context.Abilities.Any())
            //{
            //    var abilities = new List<Ability>
            //    {
            //        // วิทย์
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("DF6596C8-06D3-457E-9EC2-05F472477C86") ,
            //            StudentId = Guid.Parse("A7DD0F10-BE87-4B33-8929-0842A7B29D73") ,
            //        } ,

            //        // เครื่องกลและอิเล็กทรอนิกส์
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("ABC3F87F-004F-47AB-925A-24AD4AD6ACC7") ,
            //            StudentId = Guid.Parse("A7DD0F10-BE87-4B33-8929-0842A7B29D73") ,
            //        },
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("ABC3F87F-004F-47AB-925A-24AD4AD6ACC7") ,
            //            StudentId = Guid.Parse("2C2B7F84-930C-49EE-8CDB-16CBF43F366F") ,
            //        },

            //        // ภาษา
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("15C9598B-BA51-49FD-986D-2EFF93621E99") ,
            //            StudentId = Guid.Parse("3540E3B9-C1BD-4F03-83CD-53986999A34F") ,
            //        },
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("15C9598B-BA51-49FD-986D-2EFF93621E99") ,
            //            StudentId = Guid.Parse("2C29A7BC-7F61-4A71-AC0F-78047289BB7F") ,
            //        },
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("15C9598B-BA51-49FD-986D-2EFF93621E99") ,
            //            StudentId = Guid.Parse("5FCE2DF8-0A91-4174-96A7-818C4B9A368F") ,
            //        },

            //        // การได้ยิน
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("8DF255E1-262A-4A70-8F57-CBC01E6DD342") ,
            //            StudentId = Guid.Parse("4E16F2FB-8F86-492F-BF71-8314500EDBD0") ,
            //        },
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("8DF255E1-262A-4A70-8F57-CBC01E6DD342") ,
            //            StudentId = Guid.Parse("0AE2D105-45FE-4021-A6C1-A6751E682AEB") ,
            //        },

            //        // คณิตศาสตร์
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("AEB9C6AF-7633-42AC-B571-7814C0494741") ,
            //            StudentId = Guid.Parse("0AE2D105-45FE-4021-A6C1-A6751E682AEB") ,
            //        },
            //        new Ability
            //        {
            //            MultipleIntelligencesId = Guid.Parse("AEB9C6AF-7633-42AC-B571-7814C0494741") ,
            //            StudentId = Guid.Parse("155EDDCD-F78F-4DFD-8AC7-DB781BAE4AB1") ,
            //        },
            //    };

            //    context.AddRange(abilities);
            //    //}

            //    if (!context.MultipleIntelligences.Any())
            //    {
            //        var multipleIntelligences = new List<MultipleIntelligences>
            //      {
            //    new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "ภาษา"
            //    } ,

            //     new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "คณิตศาสตร์"
            //    },

            //      new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "วิทยาศาสตร์"
            //    },

            //       new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "เครื่องกลและอิเล็กทรอนิกส์"
            //    },

            //        new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "ศิลปะ/มิติสัมพันธ์"
            //    },
            //         new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "การได้ยิน"
            //    },

            //          new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "การเคลื่อนไหวกล้ามเนื้อ"
            //    },

            //           new MultipleIntelligences
            //    {
            //        MultipleIntelligencesName = "สังคมและอารมณ์"
            //    }
            //};
            //        context.AddRange(multipleIntelligences);
            //    }

            //    context.SaveChanges();
            //}
        }
    }
}
