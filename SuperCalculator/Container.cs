namespace SuperCalculator;

public class Container : IContainer
{
    private readonly Dictionary<Type, Type> _factories = new();

    public void Register<TFrom, TTo>(string instanceName = null) where TTo : TFrom
    {
        Register(typeof(TFrom), typeof(TTo), instanceName);
    }
    
    public void Register(Type from, Type to, string instanceName = null)
    {
        if (!_factories.TryAdd(from, to))
        {
            throw new ArgumentException($"Type '{from.FullName}' already registered.");
        }
    }

    public void Register(Type type, string instanceName = null)
    {
        Register(type, type, instanceName);
    }

    public void Register<T>(string instanceName = null)
    {
        Register(typeof(T), instanceName);
    }

    public bool IsRegistered(Type type, string instanceName = null)
    {
        return _factories.ContainsKey(type);
    }

    public bool IsRegistered<T>(string instanceName = null)
    {
        return IsRegistered(typeof(T), instanceName);
    }

    public object Resolve(Type type, string instanceName = null)
    {
        if (!IsRegistered(type, instanceName))
        {
            throw new ArgumentException($"Type '{type.FullName}' is not registered.");
        }
        
        var instance = _factories[type];
        return CreateInstance(instance, instanceName);
    }

    private object CreateInstance(Type type, string instanceName = null)
    {
        var parameters = type.GetConstructors()
            .OrderByDescending(o => o.GetParameters().Count())
            .First()
            .GetParameters()
            .Select(parameter => 
                Resolve(parameter.ParameterType, instanceName))
            .ToArray();

        return Activator.CreateInstance(type, parameters)!;
    }
    public T Resolve<T>(string instanceName = null)
    {
        return (T)Resolve(typeof(T), instanceName);
    }
}