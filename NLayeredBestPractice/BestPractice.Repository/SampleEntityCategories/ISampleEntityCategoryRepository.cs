﻿namespace BestPractice.Repository.SampleEntityCategories;

/// <summary>
/// Defines a repository interface for <see cref="SampleEntityCategory"/> entities, extending the generic repository.
/// This interface includes additional methods specific to <see cref="SampleEntityCategory"/>.
/// </summary>
public interface ISampleEntityCategoryRepository : IGenericRepository<SampleEntityCategory, int>
{
    /// <summary>
    /// Retrieves a <see cref="SampleEntityCategory"/> entity by its identifier, including its associated <see cref="BestPractice.Repository.SampleEntities.SampleEntity"/> entities.
    /// </summary>
    /// <param name="id">The identifier of the category to retrieve.</param>
    /// <returns>A task representing the asynchronous operation. The task result contains the category if found; otherwise, <c>null</c>.</returns>
    Task<SampleEntityCategory?> GetSampleEntityCategoryWithSampleEntitiesAsync(int id);

    /// <summary>
    /// Retrieves a queryable collection of <see cref="SampleEntityCategory"/> entities, including their associated <see cref="BestPractice.Repository.SampleEntities.SampleEntity"/> entities.
    /// </summary>
    /// <returns>An <see cref="IQueryable{T}"/> representing the collection of categories with their associated entities.</returns>
    IQueryable<SampleEntityCategory?> GetSampleEntityCategoryWithSampleEntities();
}