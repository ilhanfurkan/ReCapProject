using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //burrada gerekli kodlar gerekli sorgular olacak bunlar gerçekleşirse aşağıda ki işlemi yapacak.
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBrandId(int id)
        {

            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
