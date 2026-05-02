using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork;

public class Container
{
    public Dictionary<Type, Type> Types { get; set; } = new();

    public void Add<TAbstraction, TImplementation>()
    {
        Type typeAbs = typeof(TAbstraction);
        Type typeImp = typeof(TImplementation);

        if (!typeImp.IsAssignableFrom(typeAbs))
        {
            throw new ArgumentException($"{typeAbs} does not implement {typeImp}");
        }
        
        Types[typeAbs]  = typeImp;
    }

    public TAbstraction? Resolve<TAbstraction>()
    {
        var result = Resolve(typeof(TAbstraction));
        return result == null ? default(TAbstraction) :  (TAbstraction)result;
    }

    public object? Resolve(Type type)
    {
        if (!Types.ContainsKey(type))
        {
            throw new ArgumentException($"{type} does not register");
        }
        
        Type typeImp = Types[type];

        var currentCtor = typeImp.GetConstructors().
                MinBy(constructor => constructor
                    .GetParameters()
                    .Length);
        if (currentCtor == null)
        {
            throw new ArgumentException($"{type} does not have a parameterless or public constructor");
        }
        
        var args = currentCtor
            .GetParameters()
            .Select( param => Resolve(param.ParameterType))
            .ToArray();
        
        return Activator.CreateInstance(typeImp, args);
    }
}