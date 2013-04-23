// DataErrorsChangedEventArgs.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

// ReSharper disable CheckNamespace
namespace System.ComponentModel
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Provides data for the <see cref="INotifyDataErrorInfo.ErrorsChanged"/> event.
    /// </summary>
    public sealed class DataErrorsChangedEventArgs : EventArgs
    {
        private readonly string _propertyName;

        /// <summary>
        /// Initializes a new instance of the DataErrorsChangedEventArgs class. 
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property for which the errors changed, or <code>null</code> or <see cref="String.Empty">Empty</see> 
        /// for entity-level errors.
        /// </param>
        public DataErrorsChangedEventArgs(string propertyName)
        {
            _propertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of the property that has an error.
        /// </summary>
        /// <value>
        /// The name of the property for which the errors changed, or <code>null</code> or <see cref="String.Empty">Empty</see> 
        /// for entity-level errors.
        /// </value>
        public string PropertyName
        {
            get { return _propertyName; }
        }
    }
}