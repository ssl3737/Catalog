using System;

namespace Catalog.Api.Entities
{
    public record Item
    {
        public Guid Id { get; init; } //init only properties .net5
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

    }
}