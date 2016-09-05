using Vienauto.Entity.Entities;
using System.Collections.Generic;

namespace Vienauto.Service.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
    }

    public static class UserDtoExtension
    {
        public static UserDto FromEntityToDto(this User entity)
        {
            return new UserDto
            {
                UserId = entity.Id,
                UserName = entity.UserName,
                FullName = entity.FullName,                
                Mobile = entity.Mobile
            };
        }
    }
}
