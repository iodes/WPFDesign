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
using System.Windows;
using WPFDesign.Core;
using WPFDesign.Designer.Themes;

namespace WPFDesign.Designer.Extensions
{
    public partial class ArrangeItemsContextMenu
    {
        private DesignItem designItem;

        public ArrangeItemsContextMenu(DesignItem designItem)
        {
            this.designItem = designItem;

            SpecialInitializeComponent();
        }

        /// <summary>
        /// Fixes InitializeComponent with multiple Versions of same Assembly loaded
        /// </summary>
        public void SpecialInitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri(VersionedAssemblyResourceDictionary.GetXamlNameForType(this.GetType()),
                    UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }

            this.InitializeComponent();
        }

        void Click_ArrangeLeft(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems, ArrangeDirection.Left);
        }

        void Click_ArrangeHorizontalCentered(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems,
                ArrangeDirection.HorizontalMiddle);
        }

        void Click_ArrangeRight(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems, ArrangeDirection.Right);
        }

        void Click_ArrangeTop(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems, ArrangeDirection.Top);
        }

        void Click_ArrangeVerticalCentered(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems, ArrangeDirection.VerticalMiddle);
        }

        void Click_ArrangeBottom(object sender, System.Windows.RoutedEventArgs e)
        {
            ModelTools.ArrangeItems(this.designItem.Services.Selection.SelectedItems, ArrangeDirection.Bottom);
        }
    }
}