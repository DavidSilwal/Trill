﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Microsoft.StreamProcessing.Internal
{
    using System;

    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class GeneratedFastDictionary : CommonBaseTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"// *********************************************************************
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License
// *********************************************************************
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.StreamProcessing;
using Microsoft.StreamProcessing.Internal.Collections;

[DataContract]
public sealed class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(this.classname));
            this.Write("<TKey, TValue> : FastDictionary");
            this.Write(this.ToStringHelper.ToStringWithCulture(this.dictType));
            this.Write("<TKey, TValue>\r\n{\r\n    private static Func<TKey, TKey, bool> equalsFunc;\r\n    pri" +
                    "vate static Func<TKey, int> getHashCodeFunc;\r\n    private static int defaultSize" +
                    " = 10;\r\n\r\n    public ");
            this.Write(this.ToStringHelper.ToStringWithCulture(this.classname));
            this.Write(@"() : base(defaultSize, equalsFunc ?? EqualityComparerExpression<TKey>.DefaultEqualsFunction, getHashCodeFunc ?? EqualityComparerExpression<TKey>.DefaultGetHashCodeFunction) { }

    public static void Initialize(Func<TKey, TKey, bool> equals, Func<TKey, int> getHashCode, int size = 10) {
        equalsFunc = equals;
        getHashCodeFunc = getHashCode;
        defaultSize = size;
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
}
