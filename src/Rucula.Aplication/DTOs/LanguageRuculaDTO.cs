﻿namespace Rucula.Aplication;
using System.ComponentModel.DataAnnotations;
public class LanguageRuculaDTO
{
        [Required]
        public string? Code { get; set; }
        public string? Description { get;set; }
        public string? Description2 { get;set; }
}
