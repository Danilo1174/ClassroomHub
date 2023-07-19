using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
       
        public void Create(User user) 
        { 
            _userRepository.Add(user);
        }
        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public User GetById(Guid id)
        {
            return new User();
        }
       
        public void Delete(Guid id)
        {
            _userRepository.Delete(id);

        }

		public IEnumerable<User> GetAll()
		{
			return _userRepository.GetAll();
		}
	}
}
