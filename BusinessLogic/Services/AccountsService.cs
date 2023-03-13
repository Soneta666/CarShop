using Core.DTOs.User;
using Core.Entities;
using Core.Helpers;
using Core.Interfaces;
using Core.Resources;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountsService(UserManager<User> userManager,
                               SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IdentityUser> Get(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
                throw new HttpException(ErrorMessages.UserByIdNotFound, HttpStatusCode.NotFound);

            return user;
        }

        public async Task Login(LoginDto dto)
        {
            var user = await userManager.FindByNameAsync(dto.Username);

            if (user == null || !await userManager.CheckPasswordAsync(user, dto.Password))
                throw new HttpException(ErrorMessages.InvalidCreds, HttpStatusCode.BadRequest);

            await signInManager.SignInAsync(user, true);
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        public async Task Register(RegisterDto dto)
        {
            User user = new()
            {
                UserName = dto.Username,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Photo = dto.Photo,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Birthday = dto.Birthday,
            };

            var result = await userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                string message = string.Join(", ", result.Errors.Select(x => x.Description));

                throw new HttpException(message, HttpStatusCode.BadRequest);
            }
        }
    }
}
