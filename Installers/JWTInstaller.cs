﻿using mi_kan_project_backend.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace mi_kan_project_backend.Installers
{
    public class JWTInstaller : IInstallers
    {
        public void InstallServices(WebApplicationBuilder builder)
        {
            var jwtSetting = new JwtSetting();
            builder.Services.AddSingleton(jwtSetting);
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                 {
                     options.TokenValidationParameters =
                         new TokenValidationParameters
                         {
                             // คนซื้อตั๋ว
                             ValidateIssuer = true,
                             // ระบุชื่อคนออกต๋ัว
                             ValidIssuer = jwtSetting.Issuer,
                             //---------------------------------
                             ValidateAudience = true,
                             ValidAudience = jwtSetting.Audience,
                             //---------------------------------
                             // มีการตรวจสอบอายุการใช้งาน
                             ValidateLifetime = true,
                             // มีการตรวจสอบการ login ว่า login หรือป่าว
                             ValidateIssuerSigningKey = true,
                             //---------------------------------
                             // ใช้ในการใส่รหัสลับ
                             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting.Key)),
                             // ถ้าต๋วหมดอายุแล้วให้ต่ออายุป่าว
                             // จากตัวอย่างถ้าตั๋วหมดอายุแล้วให้หมดไปเลยไม่มีการต่ออายุ
                             ClockSkew = TimeSpan.Zero
                         };
                 });
        }
    }
}
