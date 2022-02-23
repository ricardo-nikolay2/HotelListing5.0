using HotelListing5._0.Controllers.Data;
using HotelListing5._0.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing5._0.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        private IGenericRepository<Country> _countries;

        private IGenericRepository<Hotel> _hotels; 

        public UnitOfWork (DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            //throw new NotImplementedException();
           _context.Dispose();
            GC.SuppressFinalize(this);
        }

    

        public async Task Save()
        {
            //throw new NotImplementedException();
            await _context.SaveChangesAsync();
        }
    }
}
