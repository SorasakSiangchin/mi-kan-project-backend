﻿namespace mi_kan_project_backend.Dtos.Ability
{
    public class CreateAbilityDto
    {
        public string MultipleIntelligencesId { get; set; } // พหุปัญญา
        public string? SchoolYear { get; set; } // ปีการศึกษา
        public int? Score { get; set; }
        public string StudentId { get; set; } // นักเรียน
    }
}
