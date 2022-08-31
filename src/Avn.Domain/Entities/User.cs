﻿namespace Avn.Domain.Entities;

[Table(nameof(User), Schema = nameof(EntitySchema.Auth))]
public class User : IEntity
{
    public User() => UserId = Guid.NewGuid();

    [Key]
    public Guid UserId { get; set; }

    [Required]
    [MaxLength(150)]
    public string FullName { get; set; } = null!;

    [Required]
    [MaxLength(128)]
    public string Email { get; set; }

    [Required]
    public bool EmailIsApproved { get; set; }

    [Required]
    [MaxLength(256)]
    [Column(TypeName = "varchar")]
    public string Password { get; set; }

    [Required]
    [MaxLength(256)]
    [Column(TypeName = "varchar")]
    public string PasswordSalt { get; set; }

    public UserType UserType { get; set; }
   
    [Required]
    [MaxLength(256)]
    public string WalletAdress { get; set; }

    public bool IsActive { get; set; }

    [MaxLength(150)]
    public string OrganizationName { get; set; } = null!;

    public ICollection<UserJwtToken> UserJwtTokens { get; set; }
    public ICollection<Project> Projects { get; set; }
    public ICollection<Event> Events { get; set; }
}