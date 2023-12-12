﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWithLinq2.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MVCDB")]
	public partial class MVCDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MVCDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MVCDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MVCDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MVCDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Student_Update")]
		public int Student_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sid", DbType="Int")] System.Nullable<int> sid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Class", DbType="Int")] System.Nullable<int> @class, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fees", DbType="Money")] System.Nullable<decimal> fees, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Photo", DbType="VarChar(100)")] string photo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sid, name, @class, fees, photo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Student_Select")]
		public ISingleResult<Student_SelectResult> Student_Select([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sid", DbType="Int")] System.Nullable<int> sid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Status", DbType="Bit")] System.Nullable<bool> status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sid, status);
			return ((ISingleResult<Student_SelectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Student_Insert")]
		public int Student_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sid", DbType="Int")] System.Nullable<int> sid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Class", DbType="Int")] System.Nullable<int> @class, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fees", DbType="Money")] System.Nullable<decimal> fees, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Photo", DbType="VarChar(100)")] string photo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sid, name, @class, fees, photo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Student_Delete")]
		public int Student_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sid", DbType="Int")] System.Nullable<int> sid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sid);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class Student_SelectResult
	{
		
		private int _Sid;
		
		private string _Name;
		
		private System.Nullable<int> _Class;
		
		private System.Nullable<decimal> _Fees;
		
		private string _Photo;
		
		public Student_SelectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sid", DbType="Int NOT NULL")]
		public int Sid
		{
			get
			{
				return this._Sid;
			}
			set
			{
				if ((this._Sid != value))
				{
					this._Sid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="Int")]
		public System.Nullable<int> Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this._Class = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fees", DbType="Money")]
		public System.Nullable<decimal> Fees
		{
			get
			{
				return this._Fees;
			}
			set
			{
				if ((this._Fees != value))
				{
					this._Fees = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="VarChar(100)")]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this._Photo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
