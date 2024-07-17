﻿using System.ComponentModel.DataAnnotations;

namespace VisualEssence.Domain.DTOs
{
    public class UserPaisDTO
    {
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
