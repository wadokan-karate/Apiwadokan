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
    public class FileLogic : BaseContextLogic, IFileLogic
    {
        public FileLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public int InsertFile(FileEntity file)
        {
            _serviceContext.Files.Add(file);
            _serviceContext.SaveChanges();
            return file.Id;
        }
        public List<FileEntity> GetAllFiles()
        {
            return _serviceContext.Set<FileEntity>().ToList();

        }
    }
    

    }

