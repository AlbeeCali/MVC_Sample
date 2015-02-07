﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DocsDBModel", "FK_Document_AppUser", "AppUser", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MySampleProject.Models.AppUser), "Document", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySampleProject.Models.Document), true)]

#endregion

namespace MySampleProject.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DocsDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DocsDBEntities object using the connection string found in the 'DocsDBEntities' section of the application configuration file.
        /// </summary>
        public DocsDBEntities() : base("name=DocsDBEntities", "DocsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DocsDBEntities object.
        /// </summary>
        public DocsDBEntities(string connectionString) : base(connectionString, "DocsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DocsDBEntities object.
        /// </summary>
        public DocsDBEntities(EntityConnection connection) : base(connection, "DocsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AppUser> AppUsers
        {
            get
            {
                if ((_AppUsers == null))
                {
                    _AppUsers = base.CreateObjectSet<AppUser>("AppUsers");
                }
                return _AppUsers;
            }
        }
        private ObjectSet<AppUser> _AppUsers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Document> Documents
        {
            get
            {
                if ((_Documents == null))
                {
                    _Documents = base.CreateObjectSet<Document>("Documents");
                }
                return _Documents;
            }
        }
        private ObjectSet<Document> _Documents;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AppUsers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAppUsers(AppUser appUser)
        {
            base.AddObject("AppUsers", appUser);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Documents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDocuments(Document document)
        {
            base.AddObject("Documents", document);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocsDBModel", Name="AppUser")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AppUser : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AppUser object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="phoneArea">Initial value of the PhoneArea property.</param>
        /// <param name="phonePrefix">Initial value of the PhonePrefix property.</param>
        /// <param name="phoneSuffix">Initial value of the PhoneSuffix property.</param>
        /// <param name="enabled">Initial value of the Enabled property.</param>
        public static AppUser CreateAppUser(global::System.String userId, global::System.String firstName, global::System.String lastName, global::System.String email, global::System.String phoneArea, global::System.String phonePrefix, global::System.String phoneSuffix, global::System.Boolean enabled)
        {
            AppUser appUser = new AppUser();
            appUser.UserId = userId;
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.Email = email;
            appUser.PhoneArea = phoneArea;
            appUser.PhonePrefix = phonePrefix;
            appUser.PhoneSuffix = phoneSuffix;
            appUser.Enabled = enabled;
            return appUser;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.String _UserId;
        partial void OnUserIdChanging(global::System.String value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneArea
        {
            get
            {
                return _PhoneArea;
            }
            set
            {
                OnPhoneAreaChanging(value);
                ReportPropertyChanging("PhoneArea");
                _PhoneArea = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneArea");
                OnPhoneAreaChanged();
            }
        }
        private global::System.String _PhoneArea;
        partial void OnPhoneAreaChanging(global::System.String value);
        partial void OnPhoneAreaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhonePrefix
        {
            get
            {
                return _PhonePrefix;
            }
            set
            {
                OnPhonePrefixChanging(value);
                ReportPropertyChanging("PhonePrefix");
                _PhonePrefix = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhonePrefix");
                OnPhonePrefixChanged();
            }
        }
        private global::System.String _PhonePrefix;
        partial void OnPhonePrefixChanging(global::System.String value);
        partial void OnPhonePrefixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneSuffix
        {
            get
            {
                return _PhoneSuffix;
            }
            set
            {
                OnPhoneSuffixChanging(value);
                ReportPropertyChanging("PhoneSuffix");
                _PhoneSuffix = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneSuffix");
                OnPhoneSuffixChanged();
            }
        }
        private global::System.String _PhoneSuffix;
        partial void OnPhoneSuffixChanging(global::System.String value);
        partial void OnPhoneSuffixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhoneExt
        {
            get
            {
                return _PhoneExt;
            }
            set
            {
                OnPhoneExtChanging(value);
                ReportPropertyChanging("PhoneExt");
                _PhoneExt = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhoneExt");
                OnPhoneExtChanged();
            }
        }
        private global::System.String _PhoneExt;
        partial void OnPhoneExtChanging(global::System.String value);
        partial void OnPhoneExtChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Enabled
        {
            get
            {
                return _Enabled;
            }
            set
            {
                OnEnabledChanging(value);
                ReportPropertyChanging("Enabled");
                _Enabled = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Enabled");
                OnEnabledChanged();
            }
        }
        private global::System.Boolean _Enabled;
        partial void OnEnabledChanging(global::System.Boolean value);
        partial void OnEnabledChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocsDBModel", "FK_Document_AppUser", "Document")]
        public EntityCollection<Document> Documents
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Document>("DocsDBModel.FK_Document_AppUser", "Document");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Document>("DocsDBModel.FK_Document_AppUser", "Document", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocsDBModel", Name="Document")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Document : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Document object.
        /// </summary>
        /// <param name="documentId">Initial value of the DocumentId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="pubDate">Initial value of the PubDate property.</param>
        /// <param name="lastChangedBy">Initial value of the LastChangedBy property.</param>
        /// <param name="lastChangeDate">Initial value of the LastChangeDate property.</param>
        public static Document CreateDocument(global::System.Int32 documentId, global::System.String title, global::System.String author, global::System.DateTime pubDate, global::System.String lastChangedBy, global::System.DateTime lastChangeDate)
        {
            Document document = new Document();
            document.DocumentId = documentId;
            document.Title = title;
            document.Author = author;
            document.PubDate = pubDate;
            document.LastChangedBy = lastChangedBy;
            document.LastChangeDate = lastChangeDate;
            return document;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DocumentId
        {
            get
            {
                return _DocumentId;
            }
            set
            {
                if (_DocumentId != value)
                {
                    OnDocumentIdChanging(value);
                    ReportPropertyChanging("DocumentId");
                    _DocumentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DocumentId");
                    OnDocumentIdChanged();
                }
            }
        }
        private global::System.Int32 _DocumentId;
        partial void OnDocumentIdChanging(global::System.Int32 value);
        partial void OnDocumentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime PubDate
        {
            get
            {
                return _PubDate;
            }
            set
            {
                OnPubDateChanging(value);
                ReportPropertyChanging("PubDate");
                _PubDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PubDate");
                OnPubDateChanged();
            }
        }
        private global::System.DateTime _PubDate;
        partial void OnPubDateChanging(global::System.DateTime value);
        partial void OnPubDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastChangedBy
        {
            get
            {
                return _LastChangedBy;
            }
            set
            {
                OnLastChangedByChanging(value);
                ReportPropertyChanging("LastChangedBy");
                _LastChangedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastChangedBy");
                OnLastChangedByChanged();
            }
        }
        private global::System.String _LastChangedBy;
        partial void OnLastChangedByChanging(global::System.String value);
        partial void OnLastChangedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastChangeDate
        {
            get
            {
                return _LastChangeDate;
            }
            set
            {
                OnLastChangeDateChanging(value);
                ReportPropertyChanging("LastChangeDate");
                _LastChangeDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastChangeDate");
                OnLastChangeDateChanged();
            }
        }
        private global::System.DateTime _LastChangeDate;
        partial void OnLastChangeDateChanging(global::System.DateTime value);
        partial void OnLastChangeDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocsDBModel", "FK_Document_AppUser", "AppUser")]
        public AppUser AppUser
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AppUser>("DocsDBModel.FK_Document_AppUser", "AppUser").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AppUser>("DocsDBModel.FK_Document_AppUser", "AppUser").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<AppUser> AppUserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AppUser>("DocsDBModel.FK_Document_AppUser", "AppUser");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<AppUser>("DocsDBModel.FK_Document_AppUser", "AppUser", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocsDBModel", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }

    #endregion
    
}