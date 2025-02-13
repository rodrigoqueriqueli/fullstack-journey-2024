﻿using System.ComponentModel.DataAnnotations;

namespace SmartFinancial.Core.Requests.Categories
{
    public class CreateCategoryRequest : BaseRequest
    {
        [Required(ErrorMessage = "Invalid Title")]
        [MaxLength(80, ErrorMessage = "Title must have until 80 characters")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;
    }
}
