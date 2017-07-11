//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.LiveContest.RefinementsEcore
{
    
    
    /// <summary>
    /// The default implementation of the EEnum class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/RefinementsEcore")]
    [XmlNamespacePrefixAttribute("ecoreR")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/RefinementsEcore#//EEn" +
        "um")]
    [DebuggerDisplayAttribute("EEnum {Name}")]
    public partial class EEnum : EDataType, IEEnum, IModelElement
    {
        
        private static Lazy<ITypedElement> _eLiteralsReference = new Lazy<ITypedElement>(RetrieveELiteralsReference);
        
        /// <summary>
        /// The backing field for the ELiterals property
        /// </summary>
        private EEnumELiteralsCollection _eLiterals;
        
        private static IClass _classInstance;
        
        public EEnum()
        {
            this._eLiterals = new EEnumELiteralsCollection(this);
            this._eLiterals.CollectionChanging += this.ELiteralsCollectionChanging;
            this._eLiterals.CollectionChanged += this.ELiteralsCollectionChanged;
        }
        
        /// <summary>
        /// The eLiterals property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eLiterals")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("eEnum")]
        [ConstantAttribute()]
        public IOrderedSetExpression<IEEnumLiteral> ELiterals
        {
            get
            {
                return this._eLiterals;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EEnumChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EEnumReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/RefinementsEcore#//EEn" +
                            "um")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveELiteralsReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.RefinementsEcore.EEnum.ClassInstance)).Resolve("eLiterals")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ELiterals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ELiteralsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ELiterals", e, _eLiteralsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ELiterals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ELiteralsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ELiterals", e, _eLiteralsReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int eLiteralsIndex = ModelHelper.IndexOfReference(this.ELiterals, element);
            if ((eLiteralsIndex != -1))
            {
                return ModelHelper.CreatePath("eLiterals", eLiteralsIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "ELITERALS"))
            {
                if ((index < this.ELiterals.Count))
                {
                    return this.ELiterals[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ELITERALS"))
            {
                return this._eLiterals;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._eLiterals))
            {
                return "eLiterals";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/RefinementsEcore#//EEn" +
                        "um")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EEnum class
        /// </summary>
        public class EEnumChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EEnum _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EEnumChildrenCollection(EEnum parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.ELiterals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ELiterals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ELiterals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEEnumLiteral eLiteralsCasted = item.As<IEEnumLiteral>();
                if ((eLiteralsCasted != null))
                {
                    this._parent.ELiterals.Add(eLiteralsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ELiterals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ELiterals.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> eLiteralsEnumerator = this._parent.ELiterals.GetEnumerator();
                try
                {
                    for (
                    ; eLiteralsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eLiteralsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eLiteralsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEEnumLiteral eEnumLiteralItem = item.As<IEEnumLiteral>();
                if (((eEnumLiteralItem != null) 
                            && this._parent.ELiterals.Remove(eEnumLiteralItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ELiterals).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EEnum class
        /// </summary>
        public class EEnumReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EEnum _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EEnumReferencedElementsCollection(EEnum parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.ELiterals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ELiterals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ELiterals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEEnumLiteral eLiteralsCasted = item.As<IEEnumLiteral>();
                if ((eLiteralsCasted != null))
                {
                    this._parent.ELiterals.Add(eLiteralsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ELiterals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ELiterals.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> eLiteralsEnumerator = this._parent.ELiterals.GetEnumerator();
                try
                {
                    for (
                    ; eLiteralsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eLiteralsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eLiteralsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEEnumLiteral eEnumLiteralItem = item.As<IEEnumLiteral>();
                if (((eEnumLiteralItem != null) 
                            && this._parent.ELiterals.Remove(eEnumLiteralItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ELiterals).GetEnumerator();
            }
        }
    }
}
