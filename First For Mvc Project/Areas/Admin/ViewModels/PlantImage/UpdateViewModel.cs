﻿namespace First_For_Mvc_Project.Areas.Admin.ViewModels.PlantImage
{
    public class UpdateViewModel
    {
        public string? ImageUrL { get; set; }
        public int? Order { get; set; }
        public IFormFile? Image { get; set; }
    }
}
