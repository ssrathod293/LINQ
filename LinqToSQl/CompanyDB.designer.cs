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

namespace LinqToSQl
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompanyDB")]
	public partial class CompanyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertEmploye(Employe instance);
    partial void UpdateEmploye(Employe instance);
    partial void DeleteEmploye(Employe instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    #endregion
		
		public CompanyDBDataContext() : 
				base(global::LinqToSQl.Properties.Settings.Default.CompanyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Employe> Employes
		{
			get
			{
				return this.GetTable<Employe>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Employee_select")]
		public ISingleResult<Employee_selectResult> Employee_select([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Dname", DbType="VarChar(50)")] string dname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dname);
			return ((ISingleResult<Employee_selectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Employee_Insert")]
		public int Employee_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ename", DbType="VarChar(50)")] string ename, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job", DbType="VarChar(50)")] string job, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Money")] System.Nullable<decimal> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Dname", DbType="VarChar(50)")] string dname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Eno", DbType="Int")] ref System.Nullable<int> eno)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ename, job, salary, dname, eno);
			eno = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Eno;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<decimal> _Salary;
		
		private string _Dname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEnoChanging(int value);
    partial void OnEnoChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnJobChanging(string value);
    partial void OnJobChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Eno
		{
			get
			{
				return this._Eno;
			}
			set
			{
				if ((this._Eno != value))
				{
					this.OnEnoChanging(value);
					this.SendPropertyChanging();
					this._Eno = value;
					this.SendPropertyChanged("Eno");
					this.OnEnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this.OnJobChanging(value);
					this.SendPropertyChanging();
					this._Job = value;
					this.SendPropertyChanged("Job");
					this.OnJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employe")]
	public partial class Employe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpNo;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<int> _Mang;
		
		private System.Nullable<System.DateTime> _Hiredate;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<int> _EDept;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpNoChanging(int value);
    partial void OnEmpNoChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnJobChanging(string value);
    partial void OnJobChanged();
    partial void OnMangChanging(System.Nullable<int> value);
    partial void OnMangChanged();
    partial void OnHiredateChanging(System.Nullable<System.DateTime> value);
    partial void OnHiredateChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnEDeptChanging(System.Nullable<int> value);
    partial void OnEDeptChanged();
    #endregion
		
		public Employe()
		{
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EmpNo
		{
			get
			{
				return this._EmpNo;
			}
			set
			{
				if ((this._EmpNo != value))
				{
					this.OnEmpNoChanging(value);
					this.SendPropertyChanging();
					this._EmpNo = value;
					this.SendPropertyChanged("EmpNo");
					this.OnEmpNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(30)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(20)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this.OnJobChanging(value);
					this.SendPropertyChanging();
					this._Job = value;
					this.SendPropertyChanged("Job");
					this.OnJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mang", DbType="Int")]
		public System.Nullable<int> Mang
		{
			get
			{
				return this._Mang;
			}
			set
			{
				if ((this._Mang != value))
				{
					this.OnMangChanging(value);
					this.SendPropertyChanging();
					this._Mang = value;
					this.SendPropertyChanged("Mang");
					this.OnMangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hiredate", DbType="Date")]
		public System.Nullable<System.DateTime> Hiredate
		{
			get
			{
				return this._Hiredate;
			}
			set
			{
				if ((this._Hiredate != value))
				{
					this.OnHiredateChanging(value);
					this.SendPropertyChanging();
					this._Hiredate = value;
					this.SendPropertyChanged("Hiredate");
					this.OnHiredateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDept", DbType="Int")]
		public System.Nullable<int> EDept
		{
			get
			{
				return this._EDept;
			}
			set
			{
				if ((this._EDept != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEDeptChanging(value);
					this.SendPropertyChanging();
					this._EDept = value;
					this.SendPropertyChanged("EDept");
					this.OnEDeptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employe", Storage="_Department", ThisKey="EDept", OtherKey="DeptNo", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employes.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employes.Add(this);
						this._EDept = value.DeptNo;
					}
					else
					{
						this._EDept = default(Nullable<int>);
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptNo;
		
		private string _Dname;
		
		private string _Loc;
		
		private EntitySet<Employe> _Employes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptNoChanging(int value);
    partial void OnDeptNoChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    partial void OnLocChanging(string value);
    partial void OnLocChanged();
    #endregion
		
		public Department()
		{
			this._Employes = new EntitySet<Employe>(new Action<Employe>(this.attach_Employes), new Action<Employe>(this.detach_Employes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DeptNo
		{
			get
			{
				return this._DeptNo;
			}
			set
			{
				if ((this._DeptNo != value))
				{
					this.OnDeptNoChanging(value);
					this.SendPropertyChanging();
					this._DeptNo = value;
					this.SendPropertyChanged("DeptNo");
					this.OnDeptNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(30)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loc", DbType="VarChar(30)")]
		public string Loc
		{
			get
			{
				return this._Loc;
			}
			set
			{
				if ((this._Loc != value))
				{
					this.OnLocChanging(value);
					this.SendPropertyChanging();
					this._Loc = value;
					this.SendPropertyChanged("Loc");
					this.OnLocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employe", Storage="_Employes", ThisKey="DeptNo", OtherKey="EDept")]
		public EntitySet<Employe> Employes
		{
			get
			{
				return this._Employes;
			}
			set
			{
				this._Employes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employes(Employe entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employes(Employe entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	public partial class Employee_selectResult
	{
		
		private int _Eno;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<decimal> _Salary;
		
		private string _Dname;
		
		public Employee_selectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eno", DbType="Int NOT NULL")]
		public int Eno
		{
			get
			{
				return this._Eno;
			}
			set
			{
				if ((this._Eno != value))
				{
					this._Eno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this._Ename = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this._Job = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this._Dname = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
