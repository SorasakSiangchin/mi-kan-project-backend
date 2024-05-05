namespace mi_kan_project_backend.Services.UploadFileService
{
    public interface IUploadFileService
    {
        //ตรวจสอบมีการอัพโหลดไฟล์เข้ามาหรือไม่
        // IFormFileCollection เป็น interfaces ที่ใช้สำหรับ UploadFile
        bool IsUpload(IFormFileCollection formFiles);
        //ตรวจสอบนามสกุลไฟล์หรือรูปแบบที่่ต้องการ
        string Validation(IFormFileCollection formFiles);
        //อัพโหลดและส่งรายชื่อไฟล์ออกมา
        Task<List<string>> UploadImages(IFormFileCollection formFiles , string folderName);
        Task DeleteImage(string filename, string folderName);
    }
}
