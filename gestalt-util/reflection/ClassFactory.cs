using System;

namespace gestalt_util.reflection
{
    public interface ClassFactory
    {
        T instantiateClass<T>(Type type);
        

    }
}