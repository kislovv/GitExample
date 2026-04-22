using System;
using System.Linq;

namespace ClassWork;

public class MiniMapper
{
    public static TDestination Map<TSource, TDestination>(TSource source) 
        where TDestination: new()
    {
        Type sourceType = typeof(TSource);
        Type destinationType = typeof(TDestination);
        TDestination destination = new TDestination();
        
        foreach (var propertyInfo in sourceType.GetProperties())
        {
            if (!propertyInfo.CanRead)
            {
                continue;
            }
            
            var correctProperty = destinationType.GetProperties()
                .FirstOrDefault(property => (property.Name == propertyInfo.Name) 
                                            && (property.PropertyType == propertyInfo.PropertyType) 
                                            && property.CanWrite);
            if (correctProperty is null)
            {
                continue;
            }
            correctProperty.SetValue(destination, propertyInfo.GetValue(source));
        }
        
        return destination;
    }
}