using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapRentCatContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapRentCatContext context = new ReCapRentCatContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             select new RentalDetailDto {RentalId=r.RentalId,CompanyName=cu.CompanyName,CarName=c.CarName,RentDate=r.RentDate
                             , ReturnDate=r.ReturnDate};

                return result.ToList();

            }
        }
    }
}
