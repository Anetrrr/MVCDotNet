﻿using MVCAssignment.Models.Domain;

namespace MVCAssignment.Repositories.Abstract
{
    public interface IPublisherService
    {
        bool Add(Publisher model);
        bool Update(Publisher model);
        bool Delete(int id);
        Publisher FindById(int id);
        IEnumerable<Publisher> GetAll();

    }
}
