// INotifyDataErrorInfo.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections;
using System.Collections.Specialized;

// ReSharper disable CheckNamespace
namespace System.ComponentModel
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Defines members that data entity classes can implement to provide custom synchronous and asynchronous validation support.
    /// </summary>
    /// <remarks>
    /// This interface enables data entity classes to implement custom validation rules and expose validation results 
    /// asynchronously. This interface also supports custom error objects, multiple errors per property, cross-property errors, 
    /// and entity-level errors. Cross-property errors are errors that affect multiple properties. You can associate these errors 
    /// with one or all of the affected properties, or you can treat them as entity-level errors. Entity-level errors are errors 
    /// that either affect multiple properties or affect the entire entity without affecting a particular property.
    /// </remarks>
    public interface INotifyDataErrorInfo
    {
        /// <summary>
        /// Occurs when the validation errors have changed for a property or for the entire entity.
        /// </summary>
        /// <remarks>
        /// The implementing class should raise this event on the user interface thread whenever the GetErrors return value changes, 
        /// even if the return value implements <see cref="INotifyCollectionChanged"/>.
        /// </remarks>
        event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        /// <summary>
        /// Gets the validation errors for a specified property or for the entire entity.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property for which the errors changed, or <code>null</code> or <see cref="String.Empty">Empty</see> 
        /// for entity-level errors.
        /// </param>
        /// <returns>The validation errors for the property or entity.</returns>
        IEnumerable GetErrors(string propertyName);

        /// <summary>
        /// Gets a value that indicates whether the entity has validation errors.
        /// </summary>
        /// <remarks>
        /// This property returns false if there are no known entity-level or property-level validation errors for the entity at 
        /// the time it is accessed. However, some validation rules may still be running asynchronously as described for the 
        /// <see cref="GetErrors"/> method. 
        /// </remarks>
        /// <value><code>true</code> if the entity currently has validation errors; otherwise, <code>false</code>.</value>
        bool HasErrors { get; }
    }
}