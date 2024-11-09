using MANZO_PROJECT.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [StringLength(255, MinimumLength = 3)]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string PasswordHash { get; set; }

    public bool IsSeller { get; set; }

    [NotMapped]
    [DataType(DataType.Upload)]
    public IFormFile? ProfilePicture { get; set; }

    [Required]
    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Desc { get; set; }




    public virtual List<Order> Orders { get; set; }


}

