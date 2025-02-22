﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager:IAboutServices
	{
		IAboutDal _aboutdal;

		public AboutManager(IAboutDal aboutdal)
		{
			_aboutdal = aboutdal;
		}

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
		{
			return _aboutdal.GetListAll();
		}

        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);

        }
    }
}
