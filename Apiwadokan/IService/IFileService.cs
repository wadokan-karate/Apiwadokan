using Entities.Entities;

namespace Apiwadokan.IService
{
    public interface IFileService
    {
        int InsertFile(FileEntity fileItem);
        List<FileEntity> GetAllFiles();
    }
}
