/*
 * 
 * Copyright � 2006-2017 TenaCareeHMIS  software, by The Administrators of the Tulane Educational Fund, 
 * dba Tulane University, Center for Global Health Equity is distributed under the GNU General Public License(GPL).
 * All rights reserved.

 * This file is part of TenaCareeHMIS
 * TenaCareeHMIS is free software: 
 * 
 * you can redistribute it and/or modify it under the terms of the 
 * GNU General Public License as published by the Free Software Foundation, 
 * version 3 of the License, or any later version.
 * TenaCareeHMIS is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
 * FITNESS FOR A PARTICULAR PURPOSE.See the GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License along with TenaCareeHMIS.  
 * If not, see http://www.gnu.org/licenses/.    
 * 
 * 
*/

using System;
using System.Collections.Generic;


namespace Admin.Security.Model
{
	[Serializable]
	public class UserRole: IEquatable<UserRole>
	{

		#region Private Members

		private int _userroleid; 
		private string _userid; 
		private int _roleid; 
		private bool _isactive; 		
		#endregion

		#region Constructor

		public UserRole()
		{
			_userroleid = 0;
            _userid = "";
            _roleid = 0;
			_isactive = false; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		#region Required Fields Only Constructor
		/// <summary>
		/// required (not null) fields only constructor
		/// </summary>
		public UserRole(
			int userroleid, 
			string userid, 
			int roleid, 
			bool isactive)
			: this()
		{
			_userroleid = userroleid;
			_userid = userid;
			_roleid = roleid;
			_isactive = isactive;
		}
		#endregion // End Constructor

		#region Public Properties
			
		public virtual int UserRoleId
		{
			get
			{ 
				return _userroleid;
			}
			set
			{
				_userroleid = value;
			}

		}
			
		public virtual string UserId
		{
			get
			{ 
				return _userid;
			}
			set
			{
				if( value == null )
					throw new ArgumentOutOfRangeException("Null value not allowed for UserId", value, "null");

				_userid = value;
			}

		}
			
		public virtual int RoleId
		{
			get
			{ 
				return _roleid;
			}
			set
			{
				if( value == null )
					throw new ArgumentOutOfRangeException("Null value not allowed for RoleId", value, "null");

				_roleid = value;
			}

		}
			
		public virtual bool IsActive
		{
			get
			{ 
				return _isactive;
			}
			set
			{
				_isactive = value;
			}

		}
			
				
		#endregion 

		#region Public Functions

		#endregion //Public Functions

		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			UserRole castObj = (UserRole)obj; 
			return ( castObj != null ) &&
				( this._userroleid == castObj.UserRoleId );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 ^ hash ^ _userroleid.GetHashCode();
			return hash; 
		}
		#endregion
		
		#region IEquatable members

		public bool Equals(UserRole other)
		{
			if (other == this)
				return true;
		
			return ( other != null ) &&
				( this._userroleid == other.UserRoleId );
				   
		}

		#endregion
		
	}
}
