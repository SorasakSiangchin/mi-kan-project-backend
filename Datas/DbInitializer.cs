using Microsoft.AspNetCore.Identity;

namespace mi_kan_project_backend.Datas
{
    public static class DbInitializer
    {
        public static async Task Initialize(DataContext context)
        {
            if(context.MultipleIntelligences.Any()) return;

            var multipleIntelligences = new List<MultipleIntelligences>
            {
                new MultipleIntelligences
                {
                    MultipleIntelligencesName = "ภาษา"
                } ,

                 new MultipleIntelligences
                {
                    MultipleIntelligencesName = "คณิตศาสตร์"
                },

                  new MultipleIntelligences
                {
                    MultipleIntelligencesName = "วิทยาศาสตร์"
                },

                   new MultipleIntelligences
                {
                    MultipleIntelligencesName = "เครื่องกลและอิเล็กทรอนิกส์"
                },

                    new MultipleIntelligences
                {
                    MultipleIntelligencesName = "ศิลปะ/มิติสัมพันธ์"
                },
                     new MultipleIntelligences
                {
                    MultipleIntelligencesName = "การได้ยิน"
                },

                      new MultipleIntelligences
                {
                    MultipleIntelligencesName = "การเคลื่อนไหวกล้ามเนื้อ"
                },

                       new MultipleIntelligences
                {
                    MultipleIntelligencesName = "สังคมและอารมณ์"
                }
            };

            context.AddRange(multipleIntelligences);
            context.SaveChanges();
        }
    }
}
