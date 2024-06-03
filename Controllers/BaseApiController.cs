using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace mi_kan_project_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected string TokenUserId => FindClaim(CustomClaimTypes.USERID);

        private string FindClaim(string claimName)
        {

            //•	HttpContext => อ็อบเจ็กต์ที่ให้ข้อมูลเกี่ยวกับ HTTP request และ response รวมถึงข้อมูลเกี่ยวกับ connection, session, และ user
            //•	User => อ็อบเจ็กต์ที่แทนตัวตนของผู้ใช้ที่กำลังเข้าสู่ระบบ และมีข้อมูลเกี่ยวกับการรับรองความถูกต้อง (authentication) และสิทธิ์การเข้าถึง (authorization)
            //•	Identity => อ็อบเจ็กต์ที่ให้ข้อมูลเกี่ยวกับตัวตนของผู้ใช้ รวมถึงชื่อผู้ใช้, ว่าผู้ใช้นี้ได้รับการรับรองความถูกต้องหรือไม่, และวิธีการรับรองความถูกต้อง
            var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            var claim = claimsIdentity.FindFirst(claimName);

            if (claim == null)
            {
                return null;
            }

            return claim.Value;
        }
    }
}
