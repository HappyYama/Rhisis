﻿using System;
using System.Linq;
using System.Reflection;

namespace Rhisis.Core.Extensions;

public static class ReflectionExtensions
{
    /// <summary>
    /// Check if the given source type implements the given interface type.
    /// </summary>
    /// <param name="sourceType">Source type.</param>
    /// <param name="interfaceType">Interface type.</param>
    /// <returns>True if the source type implements the given generic type.</returns>
    /// <exception cref="ArgumentNullException">Source type or given interface type is null.</exception>
    /// <exception cref="ArgumentException">Given interface type is not an interface.</exception>
    public static bool ImplementsInterface(this Type sourceType, Type interfaceType)
    {
        if (sourceType is null)
        {
            throw new ArgumentNullException(nameof(sourceType));
        }

        if (interfaceType is null)
        {
            throw new ArgumentNullException(nameof(interfaceType));
        }

        if (!interfaceType.IsInterface)
        {
            throw new ArgumentException($"The given interface type '{interfaceType.FullName}' is not an interface.");
        }

        if (interfaceType.IsGenericType)
        {
            return sourceType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == interfaceType);
        }
        else
        {
            return sourceType.GetInterfaces().Any(x => x == interfaceType);
        }
    }

    public static TAttribute GetAttribute<TAttribute>(this PropertyInfo property) where TAttribute : Attribute
    {
        ArgumentNullException.ThrowIfNull(property, nameof(property));

        return property.GetCustomAttribute(typeof(TAttribute)) as TAttribute;
    }

    public static Type FindType(this string typeAsString)
    {
        return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).FirstOrDefault(x => x.Name == typeAsString);
    }

    public static void InvokeMethod(this object @object, string methodName, params object[] parameters)
    {
        MethodInfo method = @object.GetType().GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

        method?.Invoke(@object, parameters);
    }
}
