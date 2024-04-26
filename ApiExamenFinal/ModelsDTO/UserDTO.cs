namespace ApiExamenFinal.ModelsDTO
{
    public class UserDTO
    {

        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string UserPassword { get; set; } = null!;

        public int UserRoleId { get; set; }

        public string? UserStatus { get; set; }

        public bool? Activo { get; set; }



    }
}
