using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;

        public ModelManager( IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public void Add(Model model)
        {
            _modelDal.Add(model);
        }

        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }
    }
}
