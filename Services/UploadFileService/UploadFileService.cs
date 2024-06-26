﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace mi_kan_project_backend.Services.UploadFileService
{
    public class UploadFileService : IUploadFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public UploadFileService(
            IWebHostEnvironment webHostEnvironment,
            IConfiguration configuration
           )
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }


        public Task DeleteImage(string filename  , string folderName)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                var uploadPath = $"{_webHostEnvironment.WebRootPath}/images/{folderName}/";
                var fullName = uploadPath + filename;

                if (File.Exists(fullName)) File.Delete(fullName);
            }
            return Task.CompletedTask;  //เสร็จสิ้นภาระกิจ 
        }

        public bool IsUpload(IFormFileCollection formFiles)
        {
            return formFiles != null || formFiles?.Count > 0;
        }

        public async Task<List<string>> UploadImages(IFormFileCollection formFiles , string folderName)
        {
            // ไว้เก็บชื่อไฟล์
            var listFileName = new List<string>();
            // uploadPath จะเอามาบวกกับชื่อไฟล์
            var uploadPath = $"{_webHostEnvironment.WebRootPath}/images/{folderName}/";

            // ถ้ามันไม่มีไฟล์น้ให้สร้างขึ้นมา
            if (!Directory.Exists(uploadPath)) Directory.CreateDirectory(uploadPath);

            foreach (var formFile in formFiles)
            {
                // Guid.NewGuid().ToString() สุ่ม id ขึ้นมา + Path.GetExtension(formFile.FileName) เอานามสกุลมา Ex 111111111111.jpg
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);
                string fullName = uploadPath + fileName;
                // สร้่างในมันมีตัวตน
                using (var stream = File.Create(fullName))
                {
                    // Copy เนื้อ ไฟล์มา
                    await formFile.CopyToAsync(stream);
                }
                // นำชื่อไฟล์ใส่ใน List
                listFileName.Add(fileName);
            }
            return listFileName;
        }

        public string Validation(IFormFileCollection formFiles)
        {
            foreach (var file in formFiles)
            {
                // เช็คนามสกุลไฟล์ 
                if (!ValidationExtension(file.FileName))
                {
                    return "Invalid file extension";
                }
                // เช็คขนาดของไฟล์
                if (!ValidationSize(file.Length))
                {
                    return "The file is too large";
                }
            }
            return null;
        }

        public bool ValidationExtension(string filename)
        {
            // สร้าง LIST ขึ้นมา
            string[] permittedExtensions = { ".jpg", ".png" };
            // Path.GetExtension(filename) ดึงนามสกุลไฟล์มา
            // .ToLowerInvariant(); แปลงให้เป็นตัวเล็ก
            string extension = Path.GetExtension(filename).ToLowerInvariant();
            // string.IsNullOrEmpty(extension)  เป็นค่าว่างหรือป่าว
            //!permittedExtensions.Contains(extension) เอานามสกุลไปเช็คว่ามันมีหรือป่าว *** ถ้ามันมีจะเป็น true ไม่มี false และ ทำให้มันตรงข้ามกัน
            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                return false;
            };
            return true;
        }
        // configuration.GetValue<long>("FileSizeLimit") เป็นการเรียกใช้ค้าจาก appsettings.json
        public bool ValidationSize(long fileSize) => _configuration.GetValue<long>("FileSizeLimit") > fileSize;

    }
}
