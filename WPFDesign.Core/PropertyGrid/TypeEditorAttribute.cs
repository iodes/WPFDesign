﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;

namespace WPFDesign.Core.PropertyGrid
{
    /// <summary>
    /// Attribute to specify that the decorated class is a editor for properties with the specified
    /// return type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class TypeEditorAttribute : Attribute
    {
        readonly Type supportedPropertyType;

        /// <summary>
        /// Creates a new TypeEditorAttribute that specifies that the decorated class is a editor
        /// for properties with the return type "<paramref name="supportedPropertyType"/>".
        /// </summary>
        public TypeEditorAttribute(Type supportedPropertyType)
        {
            if (supportedPropertyType == null)
                throw new ArgumentNullException("supportedPropertyType");
            this.supportedPropertyType = supportedPropertyType;
        }

        /// <summary>
        /// Gets the supported property type.
        /// </summary>
        public Type SupportedPropertyType
        {
            get { return supportedPropertyType; }
        }
    }
}