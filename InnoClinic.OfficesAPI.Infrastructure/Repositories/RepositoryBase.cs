using InnoCLinic.OfficesAPI.Core.Contracts;
using InnoCLinic.OfficesAPI.Core.Contracts.Attributes;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Settings;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace InnoClinic.OfficesAPI.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : IDocument
    {
        private readonly IMongoCollection<T> _collection;

        public RepositoryBase(IOfficeStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<T>(GetCollectionName(typeof(T)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((CollectionAttribute)documentType.GetCustomAttributes(typeof(CollectionAttribute), true)
                .FirstOrDefault())?.CollectionName;
        }

        public async Task Create(T entity) => await _collection.InsertOneAsync(entity);

        public async Task Delete(Expression<Func<T, bool>> expression) => await _collection.FindOneAndDeleteAsync(expression);

        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression) => (await _collection.FindAsync(expression)).ToList();

        public async Task Update(T entity) => await _collection.ReplaceOneAsync(x => x.Id.Equals(entity.Id), entity);
    }
}
