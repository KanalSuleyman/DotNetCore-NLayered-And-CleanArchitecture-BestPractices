﻿namespace CleanArchitecture.Application.Features.SampleEntityCategory.Create;

/// <summary>
/// Represents a response object returned after successfully creating a <see cref="CleanArchitecture.Domain.Entities.SampleEntityCategory"/>.
/// This record contains the identifier of the newly created category.
/// </summary>
/// <param name="Id">The unique identifier of the created sample entity category.</param>
public record CreateSampleEntityCategoryResponse(int Id);