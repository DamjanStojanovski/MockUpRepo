using DataLibrary;
using DataLibrary.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class SchoolRepository : BaseRepository, IRepository<School>
    {
        public SchoolRepository(SchoolsDbContext dbContext) : base(dbContext){}

        public IEnumerable<School> GetAll()
        {
            return _dbContext.Schools;
        }
        public School GetById(Guid id)
        {
            var school = _dbContext.Schools.SingleOrDefault(s => s.Id == id);
            if(school == null)
            {
                throw new ApplicationException("The specified school does not exists!");
            }
            return school;
        }
        public int Insert(School entity)
        {
            if(entity != null)
            {
                throw new ApplicationException("The School exists!");
            }
            _dbContext.Schools.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(School entity)
        {
            if (entity == null)
            {
                throw new ApplicationException("The School does not exists!");
            }
            _dbContext.Schools.Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Guid id)
        {
            var school = _dbContext.Schools.SingleOrDefault(s => s.Id == id);
            if(school == null)
            {
                throw new ApplicationException("School does not exists!");
            }
            _dbContext.Schools.Remove(school);
            return _dbContext.SaveChanges();
        }
    }
}
