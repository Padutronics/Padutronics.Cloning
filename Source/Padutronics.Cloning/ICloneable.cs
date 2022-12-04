using System;

namespace Padutronics.Cloning;

public interface ICloneable<out T> : ICloneable
{
    new T Clone();
}