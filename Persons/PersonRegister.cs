//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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

namespace Family2Person.Persons
{
    
    
    /// <summary>
    /// The default implementation of the PersonRegister class
    /// </summary>
    [XmlNamespaceAttribute("platform:/plugin/Persons/model/Persons.ecore")]
    [XmlNamespacePrefixAttribute("Persons")]
    [ModelRepresentationClassAttribute("platform:/plugin/Persons/model/Persons.ecore#//PersonRegister")]
    public partial class PersonRegister : ModelElement, IPersonRegister, IModelElement
    {
        
        private static Lazy<ITypedElement> _personsReference = new Lazy<ITypedElement>(RetrievePersonsReference);
        
        /// <summary>
        /// The backing field for the Persons property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private PersonRegisterPersonsCollection _persons;
        
        private static IClass _classInstance;
        
        public PersonRegister()
        {
            this._persons = new PersonRegisterPersonsCollection(this);
            this._persons.CollectionChanging += this.PersonsCollectionChanging;
            this._persons.CollectionChanged += this.PersonsCollectionChanged;
        }
        
        /// <summary>
        /// The persons property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("persons")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("personsInverse")]
        [ConstantAttribute()]
        public IOrderedSetExpression<IPerson> Persons
        {
            get
            {
                return this._persons;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new PersonRegisterChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PersonRegisterReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("platform:/plugin/Persons/model/Persons.ecore#//PersonRegister")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrievePersonsReference()
        {
            return ((ITypedElement)(((ModelElement)(Family2Person.Persons.PersonRegister.ClassInstance)).Resolve("persons")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Persons property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PersonsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Persons", e, _personsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Persons property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PersonsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Persons", e, _personsReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int personsIndex = ModelHelper.IndexOfReference(this.Persons, element);
            if ((personsIndex != -1))
            {
                return ModelHelper.CreatePath("persons", personsIndex);
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
            if ((reference == "PERSONS"))
            {
                if ((index < this.Persons.Count))
                {
                    return this.Persons[index];
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
            if ((feature == "PERSONS"))
            {
                return this._persons;
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
            if ((container == this._persons))
            {
                return "persons";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("platform:/plugin/Persons/model/Persons.ecore#//PersonRegister")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PersonRegister class
        /// </summary>
        public class PersonRegisterChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PersonRegister _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PersonRegisterChildrenCollection(PersonRegister parent)
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
                    count = (count + this._parent.Persons.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Persons.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Persons.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPerson personsCasted = item.As<IPerson>();
                if ((personsCasted != null))
                {
                    this._parent.Persons.Add(personsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Persons.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Persons.Contains(item))
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
                IEnumerator<IModelElement> personsEnumerator = this._parent.Persons.GetEnumerator();
                try
                {
                    for (
                    ; personsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = personsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    personsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPerson personItem = item.As<IPerson>();
                if (((personItem != null) 
                            && this._parent.Persons.Remove(personItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Persons).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PersonRegister class
        /// </summary>
        public class PersonRegisterReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PersonRegister _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PersonRegisterReferencedElementsCollection(PersonRegister parent)
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
                    count = (count + this._parent.Persons.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Persons.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Persons.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPerson personsCasted = item.As<IPerson>();
                if ((personsCasted != null))
                {
                    this._parent.Persons.Add(personsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Persons.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Persons.Contains(item))
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
                IEnumerator<IModelElement> personsEnumerator = this._parent.Persons.GetEnumerator();
                try
                {
                    for (
                    ; personsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = personsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    personsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPerson personItem = item.As<IPerson>();
                if (((personItem != null) 
                            && this._parent.Persons.Remove(personItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Persons).GetEnumerator();
            }
        }
    }
}

