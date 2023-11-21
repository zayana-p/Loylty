﻿using System;
namespace TGCLoyaltyApp.Entities
{
	public abstract class EntityBase
	{
		public EntityBase()
		{
		}
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedDate  { get; set; }
		public DateTime ModifiedDate { get; set; }

	}
}

