using DataLibrary;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class MuncipalityRepository : BaseRepository, IRepository<Municipality>
    {
        public MuncipalityRepository(SchoolsDbContext dbContext) : base(dbContext) { }


        public IEnumerable<Municipality> GetAll()
        {
            return _dbContext.Municipalities;
        }
        public Municipality GetById(Guid id)
        {
            var muuncipality = _dbContext.Municipalities.SingleOrDefault(m => m.Id == id);
            return muuncipality;
        }
        public int Insert(Municipality entity)
        {
            _dbContext.Municipalities.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(Municipality entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Guid id)
        {
            var muncipality = _dbContext.Municipalities.SingleOrDefault(m => m.Id == id);
            if(muncipality == null)
            {
                return -1;
            }
            _dbContext.Municipalities.Remove(muncipality);
            return _dbContext.SaveChanges();
        }  
    }
    
 }

