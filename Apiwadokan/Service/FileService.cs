using Apiwadokan.IService;
using Data;
using Entities.Entities;

namespace Apiwadokan.Service
{
    public class FileService : IFileService
    {
        private readonly ServiceContext _serviceContext;
        public FileService(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
        public int InsertFile(FileEntity fileItem)
        {
            try
            {
                _serviceContext.Files.Add(fileItem);
                _serviceContext.SaveChanges();
                return fileItem.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<FileEntity> GetAllFiles()
        {
            return _serviceContext.Set<FileEntity>().ToList();
        }

    }
}

