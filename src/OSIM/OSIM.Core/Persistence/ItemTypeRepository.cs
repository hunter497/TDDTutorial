using OSIM.Core.Entities;
using System;

namespace OSIM.Core.Persistence
{
    public interface IItemTypeRepository 
    {
        int Save(ItemType itemType);
    }

    public class ItemTypeRepository : IItemTypeRepository
    {
        public int Save(ItemType itemType)
        {
            throw new NotImplementedException();
        }
    }
}
