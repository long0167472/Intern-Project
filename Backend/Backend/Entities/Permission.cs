﻿using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public User User { get; set; }

        public Role Role { get; set; }
    }

}
