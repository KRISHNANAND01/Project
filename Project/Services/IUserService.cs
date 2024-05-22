using Project.DTO;
using System.Collections.Generic;
using TurfBooking.Models;

namespace TurfBooking.Services
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(int id);
        UserDTO AddUser(NewUserDTO newUserDto);
        void UpdateUser(int id, UserDTO userDto);
        void DeleteUser(int id);
        JWTTokenResponse Login(login newlogin);
    }
}
