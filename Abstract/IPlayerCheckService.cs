using System;
using Homework5.Entities;

namespace Homework5.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
