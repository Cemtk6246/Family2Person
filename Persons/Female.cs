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
    /// The default implementation of the Female class
    /// </summary>
    [XmlNamespaceAttribute("platform:/plugin/Persons/model/Persons.ecore")]
    [XmlNamespacePrefixAttribute("Persons")]
    [ModelRepresentationClassAttribute("platform:/plugin/Persons/model/Persons.ecore#//Female")]
    [DebuggerDisplayAttribute("Female {Name}")]
    public partial class Female : Person, IFemale, IModelElement
    {
        
        private static IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("platform:/plugin/Persons/model/Persons.ecore#//Female")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("platform:/plugin/Persons/model/Persons.ecore#//Female")));
            }
            return _classInstance;
        }
    }
}

