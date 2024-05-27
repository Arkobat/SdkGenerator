using DiffChecker.Model;
using SchemaConsumer.Shared.Model;

namespace DiffChecker.Service;

public class DiffService
{
    public List<ModelDiff> Compare(List<Schema> oldSchemas, List<Schema> newSchemas)
    {
        var comparator = new SchemaComparator();
        // Find all the schemas thas has been removed
        var removedSchemas = oldSchemas.Except(newSchemas, comparator)
            .Select(s => new ModelDiff()
            {
                Type = DifferenceType.Removed,
                Namespace = s.Namespace,
                Name = s.Name,
                Differences = [],
                Properties = []
            }).ToList();

        // Find all the new schemas that has been created
        var addedSchemas = newSchemas.Except(oldSchemas, comparator)
            .Select(s => new ModelDiff()
            {
                Type = DifferenceType.Added,
                Namespace = s.Namespace,
                Name = s.Name,
                Differences = [],
                Properties = []
            }).ToList();

        // Get all schemas that are common in both old and new schemas
        var commonSchemas = newSchemas.Intersect(oldSchemas, comparator)
            .Select(newSchema =>
            {
                var oldSchema = oldSchemas.First(s => comparator.Equals(s, newSchema));
                var differences = GetDifferences(oldSchema, newSchema).ToList();
                var propertyDiffs = Compare(((ObjectSchema) oldSchema).Properties, ((ObjectSchema) newSchema).Properties);
                if (differences.Count == 0 && propertyDiffs.Count == 0) return null;

                return new ModelDiff()
                {
                    Type = DifferenceType.Modified,
                    Namespace = newSchema.Namespace,
                    Name = newSchema.Name,
                    Differences = differences,
                    Properties = propertyDiffs
                };
            })
            .Where(m => m is not null)
            .OfType<ModelDiff>()
            .ToList();

        return removedSchemas
            .Concat(addedSchemas)
            .Concat(commonSchemas)
            .ToList();
    }

    private IEnumerable<Difference> GetDifferences(Schema oldSchema, Schema newSchema)
    {
        // Compare type
        if (oldSchema.Type != newSchema.Type)
        {
            yield return new Difference()
            {
                Path = nameof(Schema.Type),
                OldValue = oldSchema.Type.ToString(),
                NewValue = newSchema.Type.ToString()
            };
        }

        // Compare namespace
        if (oldSchema.Namespace != newSchema.Namespace)
        {
            yield return new Difference()
            {
                Path = nameof(Schema.Namespace),
                OldValue = oldSchema.Namespace,
                NewValue = newSchema.Namespace
            };
        }

        // Compare name
        if (oldSchema.Name != newSchema.Name)
        {
            yield return new Difference()
            {
                Path = nameof(Schema.Name),
                OldValue = oldSchema.Name,
                NewValue = newSchema.Name
            };
        }

        switch (oldSchema)
        {
            // Switch on the type of schema and compare the properties
            case ObjectSchema os:
            {
                foreach (var diff in GetDifferences(os, (ObjectSchema) newSchema))
                {
                    yield return diff;
                }

                break;
            }
            case EnumSchema es:
            {
                foreach (var diff in GetDifferences(es, (EnumSchema) newSchema))
                {
                    yield return diff;
                }

                break;
            }
        }
    }

    private IEnumerable<Difference> GetDifferences(ObjectSchema oldSchema, ObjectSchema newSchema)
    {
        // Compare abstract
        if (oldSchema.Abstract != newSchema.Abstract)
        {
            yield return new Difference()
            {
                Path = nameof(ObjectSchema.Abstract),
                OldValue = Stringify.ToString(oldSchema.Abstract),
                NewValue = Stringify.ToString(newSchema.Abstract)
            };
        }

        // Compare extends
        if (oldSchema.Extends != newSchema.Extends)
        {
            yield return new Difference()
            {
                Path = nameof(ObjectSchema.Extends),
                OldValue = Stringify.ToString(oldSchema.Extends),
                NewValue = Stringify.ToString(newSchema.Extends)
            };
        }


        // Compare generics
        if (
            // Compare if either one is null
            oldSchema.Generics is null && newSchema.Generics is not null ||
            oldSchema.Generics is not null && newSchema.Generics is null ||
            // Compare if they have same values
            oldSchema.Generics is not null && newSchema.Generics is not null &&
            !oldSchema.Generics.SequenceEqual(newSchema.Generics)
        )
        {
            yield return new Difference()
            {
                Path = nameof(ObjectSchema.Generics),
                OldValue = Stringify.ToString(oldSchema.Generics),
                NewValue = Stringify.ToString(newSchema.Generics)
            };
        }
    }


    private static List<PropertyDiff> Compare(List<SchemaProperty> oldProps, List<SchemaProperty> newProps)
    {
        // Compare properties
        var comparator = new PropertyComparer();

        // Find all the properties that has been removed
        var removedProps = oldProps.Except(newProps, comparator)
            .Select(s => new PropertyDiff()
            {
                Type = DifferenceType.Removed,
                Name = s.Name,
                Differences = [],
            }).ToList();

        // Find all the new properties that has been added
        var addedProps = newProps.Except(oldProps, comparator)
            .Select(s => new PropertyDiff()
            {
                Type = DifferenceType.Removed,
                Name = s.Name,
                Differences = [],
            }).ToList();

        // Get all properties that are common in both old and new schemas
        var commonSchemas = newProps.Intersect(oldProps, comparator)
            .Select(newProp =>
            {
                var oldProp = oldProps.First(s => comparator.Equals(s, newProp));
                var differences = GetDifferences(oldProp, newProp).ToList();
                if (differences.Count == 0) return null;

                return new PropertyDiff()
                {
                    Type = DifferenceType.Modified,
                    Name = newProp.Name,
                    Differences = differences,
                };
            })
            .Where(m => m is not null)
            .OfType<PropertyDiff>()
            .ToList();

        // Return all the differences
        return removedProps
            .Concat(addedProps)
            .Concat(commonSchemas)
            .ToList();
    }


    private static IEnumerable<Difference> GetDifferences(SchemaProperty oldProperty, SchemaProperty newProperty)
    {
        // Compare type
        if (oldProperty.Type != newProperty.Type)
        {
            yield return new Difference()
            {
                Path = nameof(SchemaProperty.Type),
                OldValue = oldProperty.Type,
                NewValue = newProperty.Type
            };
        }

        // Compare name
        if (oldProperty.Name != newProperty.Name)
        {
            yield return new Difference()
            {
                Path = nameof(SchemaProperty.Name),
                OldValue = oldProperty.Name,
                NewValue = newProperty.Name
            };
        }

        // Compare nullable
        if (oldProperty.Nullable != newProperty.Nullable)
        {
            yield return new Difference()
            {
                Path = nameof(SchemaProperty.Nullable),
                OldValue = Stringify.ToString(oldProperty.Nullable),
                NewValue = Stringify.ToString(newProperty.Nullable)
            };
        }
    }

    private static IEnumerable<Difference> GetDifferences(EnumSchema oldSchema, EnumSchema newSchema)
    {
        // Compare values
        if (!oldSchema.Values.SequenceEqual(newSchema.Values))
        {
            yield return new Difference()
            {
                Path = nameof(EnumSchema.Values),
                OldValue = Stringify.ToString(newSchema.Values),
                NewValue = Stringify.ToString(newSchema.Values)
            };
        }
    }
}