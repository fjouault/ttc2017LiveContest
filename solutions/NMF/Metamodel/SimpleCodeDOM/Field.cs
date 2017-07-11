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

namespace TTC2017.LiveContest.SimpleCodeDOM
{
    
    
    /// <summary>
    /// The default implementation of the Field class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM")]
    [XmlNamespacePrefixAttribute("codeDom")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Field")]
    [DebuggerDisplayAttribute("Field {Name}")]
    public partial class Field : Member, IField, IModelElement
    {
        
        private static Lazy<ITypedElement> _fieldTypeReference = new Lazy<ITypedElement>(RetrieveFieldTypeReference);
        
        /// <summary>
        /// The backing field for the FieldType property
        /// </summary>
        private ITypeReference _fieldType;
        
        private static Lazy<ITypedElement> _initValueReference = new Lazy<ITypedElement>(RetrieveInitValueReference);
        
        /// <summary>
        /// The backing field for the InitValue property
        /// </summary>
        private IExpression _initValue;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The FieldType property
        /// </summary>
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public ITypeReference FieldType
        {
            get
            {
                return this._fieldType;
            }
            set
            {
                if ((this._fieldType != value))
                {
                    ITypeReference old = this._fieldType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFieldTypeChanging(e);
                    this.OnPropertyChanging("FieldType", e, _fieldTypeReference);
                    this._fieldType = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetFieldType;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetFieldType;
                    }
                    this.OnFieldTypeChanged(e);
                    this.OnPropertyChanged("FieldType", e, _fieldTypeReference);
                }
            }
        }
        
        /// <summary>
        /// The InitValue property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IExpression InitValue
        {
            get
            {
                return this._initValue;
            }
            set
            {
                if ((this._initValue != value))
                {
                    IExpression old = this._initValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInitValueChanging(e);
                    this.OnPropertyChanging("InitValue", e, _initValueReference);
                    this._initValue = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInitValue;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInitValue;
                    }
                    this.OnInitValueChanged(e);
                    this.OnPropertyChanged("InitValue", e, _initValueReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new FieldChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new FieldReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Field")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FieldType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FieldTypeChanging;
        
        /// <summary>
        /// Gets fired when the FieldType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FieldTypeChanged;
        
        /// <summary>
        /// Gets fired before the InitValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InitValueChanging;
        
        /// <summary>
        /// Gets fired when the InitValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InitValueChanged;
        
        private static ITypedElement RetrieveFieldTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.Field.ClassInstance)).Resolve("FieldType")));
        }
        
        /// <summary>
        /// Raises the FieldTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFieldTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FieldTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FieldTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFieldTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FieldTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the FieldType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetFieldType(object sender, System.EventArgs eventArgs)
        {
            this.FieldType = null;
        }
        
        private static ITypedElement RetrieveInitValueReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.Field.ClassInstance)).Resolve("InitValue")));
        }
        
        /// <summary>
        /// Raises the InitValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInitValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InitValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InitValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInitValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InitValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InitValue property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInitValue(object sender, System.EventArgs eventArgs)
        {
            this.InitValue = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.FieldType))
            {
                return ModelHelper.CreatePath("FieldType");
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
            if ((reference == "FIELDTYPE"))
            {
                return this.FieldType;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "FIELDTYPE"))
            {
                this.FieldType = ((ITypeReference)(value));
                return;
            }
            if ((feature == "INITVALUE"))
            {
                this.InitValue = ((IExpression)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "FieldType"))
            {
                return new FieldTypeProxy(this);
            }
            if ((attribute == "InitValue"))
            {
                return new InitValueProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "FieldType"))
            {
                return new FieldTypeProxy(this);
            }
            if ((reference == "InitValue"))
            {
                return new InitValueProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//Field")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Field class
        /// </summary>
        public class FieldChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Field _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FieldChildrenCollection(Field parent)
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
                    if ((this._parent.FieldType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.FieldTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.FieldTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.FieldType == null))
                {
                    ITypeReference fieldTypeCasted = item.As<ITypeReference>();
                    if ((fieldTypeCasted != null))
                    {
                        this._parent.FieldType = fieldTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.FieldType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.FieldType))
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
                if ((this._parent.FieldType != null))
                {
                    array[arrayIndex] = this._parent.FieldType;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.FieldType == item))
                {
                    this._parent.FieldType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.FieldType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Field class
        /// </summary>
        public class FieldReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Field _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FieldReferencedElementsCollection(Field parent)
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
                    if ((this._parent.FieldType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.InitValue != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.FieldTypeChanged += this.PropagateValueChanges;
                this._parent.InitValueChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.FieldTypeChanged -= this.PropagateValueChanges;
                this._parent.InitValueChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.FieldType == null))
                {
                    ITypeReference fieldTypeCasted = item.As<ITypeReference>();
                    if ((fieldTypeCasted != null))
                    {
                        this._parent.FieldType = fieldTypeCasted;
                        return;
                    }
                }
                if ((this._parent.InitValue == null))
                {
                    IExpression initValueCasted = item.As<IExpression>();
                    if ((initValueCasted != null))
                    {
                        this._parent.InitValue = initValueCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.FieldType = null;
                this._parent.InitValue = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.FieldType))
                {
                    return true;
                }
                if ((item == this._parent.InitValue))
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
                if ((this._parent.FieldType != null))
                {
                    array[arrayIndex] = this._parent.FieldType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.InitValue != null))
                {
                    array[arrayIndex] = this._parent.InitValue;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.FieldType == item))
                {
                    this._parent.FieldType = null;
                    return true;
                }
                if ((this._parent.InitValue == item))
                {
                    this._parent.InitValue = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.FieldType).Concat(this._parent.InitValue).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the FieldType property
        /// </summary>
        private sealed class FieldTypeProxy : ModelPropertyChange<IField, ITypeReference>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FieldTypeProxy(IField modelElement) : 
                    base(modelElement, "FieldType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITypeReference Value
            {
                get
                {
                    return this.ModelElement.FieldType;
                }
                set
                {
                    this.ModelElement.FieldType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the InitValue property
        /// </summary>
        private sealed class InitValueProxy : ModelPropertyChange<IField, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InitValueProxy(IField modelElement) : 
                    base(modelElement, "InitValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.InitValue;
                }
                set
                {
                    this.ModelElement.InitValue = value;
                }
            }
        }
    }
}
