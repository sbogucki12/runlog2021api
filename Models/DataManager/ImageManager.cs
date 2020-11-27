using runlog2021api.Models.Repository;
using System;
using System.Collections.Generic;

namespace runlog2021api.Models.DataManager
{
    public class ImageManager : IDataRepository<Image>
    {
        readonly RunContext _imageContext;
        public ImageManager(RunContext context)
        {
            _imageContext = context;
        }

        public void Add(Image img)
        {
            _imageContext.Images.Add(img);
            _imageContext.SaveChanges();
        }

        public void AddMany(List<Image> list)
        {
            throw new NotImplementedException();
        }

        public void Delete(Image entity)
        {
            throw new NotImplementedException();
        }

        public Image Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Image dbEntity, Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
