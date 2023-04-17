using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ResourceLogic : BaseContextLogic, IResourceLogic
    {
        public ResourceLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void DeleteResourceById(int Id)
        {
            var chooseResource = _serviceContext.Set<ResourceEntity>().Where(p => p.Id == Id).First();
            _serviceContext.Resources.Remove(chooseResource);
            _serviceContext.SaveChanges();
        }

        public void InsertResource(ResourceEntity product)
        {
            _serviceContext.Resources.Add(product);
            _serviceContext.SaveChanges();
        }

        public void PatchResource(ResourceEntity product)
        {
            _serviceContext.Resources.Update(product);
            _serviceContext.SaveChanges();
        }

        public List<ResourceEntity> GetResource()
        {
            return _serviceContext.Set<ResourceEntity>().ToList();

        }
        public List<ResourceEntity> GetAllResources()
        {
            return _serviceContext.Set<ResourceEntity>().ToList();

        }


    }
}

    

