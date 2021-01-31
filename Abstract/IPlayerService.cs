using System;
using Homework5.Entities;

namespace Homework5.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);

        void Update(Player player);

        void Delete(Player player);
    }
}
