﻿using System;

namespace Balea.DSL.AspNetCore
{
    /// <summary>
    /// Decorate action parameter to be allow be used on auhtorization policies using the
    /// <see cref="ParameterPropertyBag"/> property bag.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter,AllowMultiple = false,Inherited = false)]
    public class AbacParameterAttribute
        :Attribute
    { }
}
