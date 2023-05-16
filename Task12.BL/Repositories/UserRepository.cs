using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task12.BL.BLModels;
using Task12.BL.DALModels;

namespace Task12.BL.Repositories
{
    // We need this for DI!!!
    public interface IUserRepository
    {
        IEnumerable<BLUser> GetAll();
    }

    public class UserRepository : IUserRepository
    {
        private readonly Task12Context _dbContext;
        private readonly IMapper _mapper;
        public UserRepository(Task12Context dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<BLUser> GetAll()
        {
            // First retrieve collection from database
            var dbUsers = _dbContext.Users;

            // Then Map it to BL model collection using IMapper
            var blUsers = _mapper.Map<IEnumerable<BLUser>>(dbUsers);

            return blUsers;
        }
    }
}
