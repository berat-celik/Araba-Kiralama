using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<0)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {


            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.BrandId==brandId));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length<0)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }

            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
