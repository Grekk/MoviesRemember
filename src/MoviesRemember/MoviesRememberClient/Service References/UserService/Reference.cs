﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesRememberClient.UserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TinyMovie", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MoviesRememberClient.UserService.Movie))]
    public partial class TinyMovie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ApiIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PressRatingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrailerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> UserRatingsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Actors {
            get {
                return this.ActorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActorsField, value) != true)) {
                    this.ActorsField = value;
                    this.RaisePropertyChanged("Actors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ApiId {
            get {
                return this.ApiIdField;
            }
            set {
                if ((this.ApiIdField.Equals(value) != true)) {
                    this.ApiIdField = value;
                    this.RaisePropertyChanged("ApiId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalTitle {
            get {
                return this.OriginalTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTitleField, value) != true)) {
                    this.OriginalTitleField = value;
                    this.RaisePropertyChanged("OriginalTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureUrl {
            get {
                return this.PictureUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureUrlField, value) != true)) {
                    this.PictureUrlField = value;
                    this.RaisePropertyChanged("PictureUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PressRatings {
            get {
                return this.PressRatingsField;
            }
            set {
                if ((this.PressRatingsField.Equals(value) != true)) {
                    this.PressRatingsField = value;
                    this.RaisePropertyChanged("PressRatings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trailer {
            get {
                return this.TrailerField;
            }
            set {
                if ((object.ReferenceEquals(this.TrailerField, value) != true)) {
                    this.TrailerField = value;
                    this.RaisePropertyChanged("Trailer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> UserRatings {
            get {
                return this.UserRatingsField;
            }
            set {
                if ((this.UserRatingsField.Equals(value) != true)) {
                    this.UserRatingsField = value;
                    this.RaisePropertyChanged("UserRatings");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class Movie : MoviesRememberClient.UserService.TinyMovie {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<MoviesRememberClient.UserService.Link> LinkListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SynopsisField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<MoviesRememberClient.UserService.Link> LinkList {
            get {
                return this.LinkListField;
            }
            set {
                if ((object.ReferenceEquals(this.LinkListField, value) != true)) {
                    this.LinkListField = value;
                    this.RaisePropertyChanged("LinkList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Synopsis {
            get {
                return this.SynopsisField;
            }
            set {
                if ((object.ReferenceEquals(this.SynopsisField, value) != true)) {
                    this.SynopsisField = value;
                    this.RaisePropertyChanged("Synopsis");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Link", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class Link : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HrefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Href {
            get {
                return this.HrefField;
            }
            set {
                if ((object.ReferenceEquals(this.HrefField, value) != true)) {
                    this.HrefField = value;
                    this.RaisePropertyChanged("Href");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserMovie", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class UserMovie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ApiIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> RateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ShouldDeleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ApiId {
            get {
                return this.ApiIdField;
            }
            set {
                if ((this.ApiIdField.Equals(value) != true)) {
                    this.ApiIdField = value;
                    this.RaisePropertyChanged("ApiId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureUrl {
            get {
                return this.PictureUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureUrlField, value) != true)) {
                    this.PictureUrlField = value;
                    this.RaisePropertyChanged("PictureUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((object.ReferenceEquals(this.ReleaseDateField, value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ShouldDelete {
            get {
                return this.ShouldDeleteField;
            }
            set {
                if ((this.ShouldDeleteField.Equals(value) != true)) {
                    this.ShouldDeleteField = value;
                    this.RaisePropertyChanged("ShouldDelete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TinyUserMovieList", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class TinyUserMovieList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MoviesRememberClient.UserService.PagedListOfUserMoviel_P5pM7zr TinyUserMoviesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MoviesRememberClient.UserService.PagedListOfUserMoviel_P5pM7zr TinyUserMovies {
            get {
                return this.TinyUserMoviesField;
            }
            set {
                if ((object.ReferenceEquals(this.TinyUserMoviesField, value) != true)) {
                    this.TinyUserMoviesField = value;
                    this.RaisePropertyChanged("TinyUserMovies");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PagedListOfUserMoviel_P5pM7zr", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class PagedListOfUserMoviel_P5pM7zr : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentPageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<MoviesRememberClient.UserService.UserMovie> EntityListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalPageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentPage {
            get {
                return this.CurrentPageField;
            }
            set {
                if ((this.CurrentPageField.Equals(value) != true)) {
                    this.CurrentPageField = value;
                    this.RaisePropertyChanged("CurrentPage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<MoviesRememberClient.UserService.UserMovie> EntityList {
            get {
                return this.EntityListField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityListField, value) != true)) {
                    this.EntityListField = value;
                    this.RaisePropertyChanged("EntityList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalPage {
            get {
                return this.TotalPageField;
            }
            set {
                if ((this.TotalPageField.Equals(value) != true)) {
                    this.TotalPageField = value;
                    this.RaisePropertyChanged("TotalPage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalResult {
            get {
                return this.TotalResultField;
            }
            set {
                if ((this.TotalResultField.Equals(value) != true)) {
                    this.TotalResultField = value;
                    this.RaisePropertyChanged("TotalResult");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAction", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class UserAction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MoviesRememberClient.UserService.Action ActionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MovieNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MoviesRememberClient.UserService.Action Action {
            get {
                return this.ActionField;
            }
            set {
                if ((this.ActionField.Equals(value) != true)) {
                    this.ActionField = value;
                    this.RaisePropertyChanged("Action");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieIdField, value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MovieName {
            get {
                return this.MovieNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieNameField, value) != true)) {
                    this.MovieNameField = value;
                    this.RaisePropertyChanged("MovieName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Action", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    public enum Action : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ADD_MOVIE = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DELETE_MOVIE = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SHOW_MOVIE = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddMovie", ReplyAction="http://tempuri.org/IUserService/AddMovieResponse")]
        void AddMovie(System.Guid userId, string userName, MoviesRememberClient.UserService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteMovie", ReplyAction="http://tempuri.org/IUserService/DeleteMovieResponse")]
        void DeleteMovie(string userName, MoviesRememberClient.UserService.UserMovie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateMovie", ReplyAction="http://tempuri.org/IUserService/UpdateMovieResponse")]
        void UpdateMovie(MoviesRememberClient.UserService.UserMovie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserMovieList", ReplyAction="http://tempuri.org/IUserService/GetUserMovieListResponse")]
        MoviesRememberClient.UserService.TinyUserMovieList GetUserMovieList(System.Guid userId, int numPage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUserAction", ReplyAction="http://tempuri.org/IUserService/AddUserActionResponse")]
        System.Collections.Generic.List<MoviesRememberClient.UserService.UserAction> AddUserAction(MoviesRememberClient.UserService.UserAction action);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUsersActions", ReplyAction="http://tempuri.org/IUserService/GetUsersActionsResponse")]
        System.Collections.Generic.List<MoviesRememberClient.UserService.UserAction> GetUsersActions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddNewMember", ReplyAction="http://tempuri.org/IUserService/AddNewMemberResponse")]
        bool AddNewMember(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : MoviesRememberClient.UserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<MoviesRememberClient.UserService.IUserService>, MoviesRememberClient.UserService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddMovie(System.Guid userId, string userName, MoviesRememberClient.UserService.Movie movie) {
            base.Channel.AddMovie(userId, userName, movie);
        }
        
        public void DeleteMovie(string userName, MoviesRememberClient.UserService.UserMovie movie) {
            base.Channel.DeleteMovie(userName, movie);
        }
        
        public void UpdateMovie(MoviesRememberClient.UserService.UserMovie movie) {
            base.Channel.UpdateMovie(movie);
        }
        
        public MoviesRememberClient.UserService.TinyUserMovieList GetUserMovieList(System.Guid userId, int numPage) {
            return base.Channel.GetUserMovieList(userId, numPage);
        }
        
        public System.Collections.Generic.List<MoviesRememberClient.UserService.UserAction> AddUserAction(MoviesRememberClient.UserService.UserAction action) {
            return base.Channel.AddUserAction(action);
        }
        
        public System.Collections.Generic.List<MoviesRememberClient.UserService.UserAction> GetUsersActions() {
            return base.Channel.GetUsersActions();
        }
        
        public bool AddNewMember(string email) {
            return base.Channel.AddNewMember(email);
        }
    }
}
