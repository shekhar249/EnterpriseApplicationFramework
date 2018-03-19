﻿/*************************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at http://xceed.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Xceed.Wpf.AvalonDock.Controls
{
    abstract class DropTargetBase : DependencyObject
    {
        #region IsDraggingOver

        /// <summary>
        /// IsDraggingOver Attached Dependency Property
        /// </summary>
        public static readonly DependencyProperty IsDraggingOverProperty =
            DependencyProperty.RegisterAttached("IsDraggingOver", typeof(bool), typeof(DropTargetBase),
                new FrameworkPropertyMetadata((bool)false));

        /// <summary>
        /// Gets the IsDraggingOver property.  This dependency property 
        /// indicates if user is dragging a window over the target element.
        /// </summary>
        public static bool GetIsDraggingOver(DependencyObject d)
        {
            return (bool)d.GetValue(IsDraggingOverProperty);
        }

        /// <summary>
        /// Sets the IsDraggingOver property.  This dependency property 
        /// indicates if user is dragging away a window from the target element.
        /// </summary>
        public static void SetIsDraggingOver(DependencyObject d, bool value)
        {
            d.SetValue(IsDraggingOverProperty, value);
        }

        #endregion
    }
}
