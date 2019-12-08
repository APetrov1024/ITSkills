﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITSkills
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ITSkillsDB")]
	public partial class ITSkillsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertEmployees(Employees instance);
    partial void UpdateEmployees(Employees instance);
    partial void DeleteEmployees(Employees instance);
    partial void InsertSkills(Skills instance);
    partial void UpdateSkills(Skills instance);
    partial void DeleteSkills(Skills instance);
    partial void InsertProfessions(Professions instance);
    partial void UpdateProfessions(Professions instance);
    partial void DeleteProfessions(Professions instance);
    #endregion
		
		public ITSkillsDataContext() : 
				base(global::ITSkills.Properties.Settings.Default.ITSkillsDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ITSkillsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITSkillsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITSkillsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITSkillsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employees> Employees
		{
			get
			{
				return this.GetTable<Employees>();
			}
		}
		
		public System.Data.Linq.Table<Skills> Skills
		{
			get
			{
				return this.GetTable<Skills>();
			}
		}
		
		public System.Data.Linq.Table<EmployeesSkills> EmployeesSkills
		{
			get
			{
				return this.GetTable<EmployeesSkills>();
			}
		}
		
		public System.Data.Linq.Table<Professions> Professions
		{
			get
			{
				return this.GetTable<Professions>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employees : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _LastName;
		
		private string _Patronymic;
		
		private System.DateTime _DateOfBirth;
		
		private int _ProfessionID;
		
		private EntityRef<Professions> _Professions;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPatronymicChanging(string value);
    partial void OnPatronymicChanged();
    partial void OnDateOfBirthChanging(System.DateTime value);
    partial void OnDateOfBirthChanged();
    partial void OnProfessionIDChanging(int value);
    partial void OnProfessionIDChanged();
    #endregion
		
		public Employees()
		{
			this._Professions = default(EntityRef<Professions>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Patronymic", DbType="NVarChar(50)")]
		public string Patronymic
		{
			get
			{
				return this._Patronymic;
			}
			set
			{
				if ((this._Patronymic != value))
				{
					this.OnPatronymicChanging(value);
					this.SendPropertyChanging();
					this._Patronymic = value;
					this.SendPropertyChanged("Patronymic");
					this.OnPatronymicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date NOT NULL")]
		public System.DateTime DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfessionID", DbType="Int NOT NULL")]
		public int ProfessionID
		{
			get
			{
				return this._ProfessionID;
			}
			set
			{
				if ((this._ProfessionID != value))
				{
					if (this._Professions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProfessionIDChanging(value);
					this.SendPropertyChanging();
					this._ProfessionID = value;
					this.SendPropertyChanged("ProfessionID");
					this.OnProfessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professions_Employees", Storage="_Professions", ThisKey="ProfessionID", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Professions Professions
		{
			get
			{
				return this._Professions.Entity;
			}
			set
			{
				Professions previousValue = this._Professions.Entity;
				if (((previousValue != value) 
							|| (this._Professions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Professions.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Professions.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._ProfessionID = value.Id;
					}
					else
					{
						this._ProfessionID = default(int);
					}
					this.SendPropertyChanged("Professions");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Skills")]
	public partial class Skills : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Skill;
		
		private int _ProfessionID;
		
		private EntityRef<Professions> _Professions;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSkillChanging(string value);
    partial void OnSkillChanged();
    partial void OnProfessionIDChanging(int value);
    partial void OnProfessionIDChanged();
    #endregion
		
		public Skills()
		{
			this._Professions = default(EntityRef<Professions>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Skill", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Skill
		{
			get
			{
				return this._Skill;
			}
			set
			{
				if ((this._Skill != value))
				{
					this.OnSkillChanging(value);
					this.SendPropertyChanging();
					this._Skill = value;
					this.SendPropertyChanged("Skill");
					this.OnSkillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfessionID", DbType="Int NOT NULL")]
		public int ProfessionID
		{
			get
			{
				return this._ProfessionID;
			}
			set
			{
				if ((this._ProfessionID != value))
				{
					if (this._Professions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProfessionIDChanging(value);
					this.SendPropertyChanging();
					this._ProfessionID = value;
					this.SendPropertyChanged("ProfessionID");
					this.OnProfessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professions_Skills", Storage="_Professions", ThisKey="ProfessionID", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Professions Professions
		{
			get
			{
				return this._Professions.Entity;
			}
			set
			{
				Professions previousValue = this._Professions.Entity;
				if (((previousValue != value) 
							|| (this._Professions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Professions.Entity = null;
						previousValue.Skills.Remove(this);
					}
					this._Professions.Entity = value;
					if ((value != null))
					{
						value.Skills.Add(this);
						this._ProfessionID = value.Id;
					}
					else
					{
						this._ProfessionID = default(int);
					}
					this.SendPropertyChanged("Professions");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeesSkills")]
	public partial class EmployeesSkills
	{
		
		private int _EmployeeID;
		
		private System.Nullable<int> _SkillID;
		
		public EmployeesSkills()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this._EmployeeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SkillID", DbType="Int")]
		public System.Nullable<int> SkillID
		{
			get
			{
				return this._SkillID;
			}
			set
			{
				if ((this._SkillID != value))
				{
					this._SkillID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Professions")]
	public partial class Professions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Profession;
		
		private EntitySet<Employees> _Employees;
		
		private EntitySet<Skills> _Skills;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProfessionChanging(string value);
    partial void OnProfessionChanged();
    #endregion
		
		public Professions()
		{
			this._Employees = new EntitySet<Employees>(new Action<Employees>(this.attach_Employees), new Action<Employees>(this.detach_Employees));
			this._Skills = new EntitySet<Skills>(new Action<Skills>(this.attach_Skills), new Action<Skills>(this.detach_Skills));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profession", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Profession
		{
			get
			{
				return this._Profession;
			}
			set
			{
				if ((this._Profession != value))
				{
					this.OnProfessionChanging(value);
					this.SendPropertyChanging();
					this._Profession = value;
					this.SendPropertyChanged("Profession");
					this.OnProfessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professions_Employees", Storage="_Employees", ThisKey="Id", OtherKey="ProfessionID")]
		public EntitySet<Employees> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professions_Skills", Storage="_Skills", ThisKey="Id", OtherKey="ProfessionID")]
		public EntitySet<Skills> Skills
		{
			get
			{
				return this._Skills;
			}
			set
			{
				this._Skills.Assign(value);
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
		
		private void attach_Employees(Employees entity)
		{
			this.SendPropertyChanging();
			entity.Professions = this;
		}
		
		private void detach_Employees(Employees entity)
		{
			this.SendPropertyChanging();
			entity.Professions = null;
		}
		
		private void attach_Skills(Skills entity)
		{
			this.SendPropertyChanging();
			entity.Professions = this;
		}
		
		private void detach_Skills(Skills entity)
		{
			this.SendPropertyChanging();
			entity.Professions = null;
		}
	}
}
#pragma warning restore 1591
