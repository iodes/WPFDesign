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

using WPFDesign.Core.Extensions;

namespace WPFDesign.Core.Adorners
{
    // Some classes that derive from AdornerProvider to specify a certain ExtensionServer.

    /// <summary>
    /// An adorner extension that is attached permanently.
    /// </summary>
    [ExtensionServer(typeof(DefaultExtensionServer.PermanentWithDesignPanel))]
    public abstract class PermanentAdornerProvider : AdornerProvider
    {
    }

    /// <summary>
    /// An adorner extension that is attached to selected components.
    /// </summary>
    [ExtensionServer(typeof(SelectionExtensionServer))]
    public abstract class SelectionAdornerProvider : AdornerProvider
    {
    }

    /// <summary>
    /// An adorner extension that is attached to the primary selection.
    /// </summary>
    [ExtensionServer(typeof(PrimarySelectionExtensionServer))]
    public abstract class PrimarySelectionAdornerProvider : AdornerProvider
    {
    }

    /// <summary>
    /// An adorner extension that is attached to the secondary selection.
    /// </summary>
    [ExtensionServer(typeof(SecondarySelectionExtensionServer))]
    public abstract class SecondarySelectionAdornerProvider : AdornerProvider
    {
    }
}