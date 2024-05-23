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

namespace Family2Person.Families
{
    
    
    /// <summary>
    /// The public interface for FamilyMember
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FamilyMember))]
    [XmlDefaultImplementationTypeAttribute(typeof(FamilyMember))]
    [ModelRepresentationClassAttribute("platform:/plugin/Families/model/Families.ecore#//FamilyMember")]
    public interface IFamilyMember : IModelElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        [DisplayNameAttribute("name")]
        [CategoryAttribute("FamilyMember")]
        [XmlElementNameAttribute("name")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fatherInverse property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("fatherInverse")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("father")]
        IFamily FatherInverse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The motherInverse property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("motherInverse")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("mother")]
        IFamily MotherInverse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sonsInverse property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("sonsInverse")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("sons")]
        IFamily SonsInverse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The daughtersInverse property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("daughtersInverse")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("daughters")]
        IFamily DaughtersInverse
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired before the FatherInverse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FatherInverseChanging;
        
        /// <summary>
        /// Gets fired when the FatherInverse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FatherInverseChanged;
        
        /// <summary>
        /// Gets fired before the MotherInverse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MotherInverseChanging;
        
        /// <summary>
        /// Gets fired when the MotherInverse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MotherInverseChanged;
        
        /// <summary>
        /// Gets fired before the SonsInverse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SonsInverseChanging;
        
        /// <summary>
        /// Gets fired when the SonsInverse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SonsInverseChanged;
        
        /// <summary>
        /// Gets fired before the DaughtersInverse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DaughtersInverseChanging;
        
        /// <summary>
        /// Gets fired when the DaughtersInverse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DaughtersInverseChanged;
    }
}

