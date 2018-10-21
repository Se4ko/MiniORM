namespace MiniORMProject.Interfaces
{
    using System.Collections.Generic;

    public interface IDbContex
    {
        bool Persist(object entity);

        T FindById<T>(int id);

        IEnumerable<T> FindAll<T>();

        IEnumerable<T> FindAll<T>(string where);

        void Delete<T>(object entity);

        void DeleteById<T>(int id);
    }
}