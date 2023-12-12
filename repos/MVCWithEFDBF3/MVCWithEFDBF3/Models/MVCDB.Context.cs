﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWithEFDBF3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MVCDBEntities : DbContext
    {
        public MVCDBEntities()
            : base("name=MVCDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int Student_Delete(Nullable<int> sid)
        {
            var sidParameter = sid.HasValue ?
                new ObjectParameter("Sid", sid) :
                new ObjectParameter("Sid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Delete", sidParameter);
        }
    
        public virtual int Student_Insert(Nullable<int> sid, string name, Nullable<int> @class, Nullable<decimal> fees, string photo)
        {
            var sidParameter = sid.HasValue ?
                new ObjectParameter("Sid", sid) :
                new ObjectParameter("Sid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var classParameter = @class.HasValue ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(int));
    
            var feesParameter = fees.HasValue ?
                new ObjectParameter("Fees", fees) :
                new ObjectParameter("Fees", typeof(decimal));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Insert", sidParameter, nameParameter, classParameter, feesParameter, photoParameter);
        }
    
        public virtual ObjectResult<Student_Select_Result> Student_Select(Nullable<int> sid, Nullable<bool> status)
        {
            var sidParameter = sid.HasValue ?
                new ObjectParameter("Sid", sid) :
                new ObjectParameter("Sid", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student_Select_Result>("Student_Select", sidParameter, statusParameter);
        }
    
        public virtual int Student_Update(Nullable<int> sid, string name, Nullable<int> @class, Nullable<decimal> fees, string photo)
        {
            var sidParameter = sid.HasValue ?
                new ObjectParameter("Sid", sid) :
                new ObjectParameter("Sid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var classParameter = @class.HasValue ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(int));
    
            var feesParameter = fees.HasValue ?
                new ObjectParameter("Fees", fees) :
                new ObjectParameter("Fees", typeof(decimal));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Update", sidParameter, nameParameter, classParameter, feesParameter, photoParameter);
        }
    }
}
