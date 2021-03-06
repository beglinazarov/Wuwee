﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Wuwee.MvcWebUI.Auth
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public DateTime Birthdate { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public ICollection<IdentityUserClaim<string>> Claims { get; internal set; }

		//public Claim Claims { get; internal set; }
	}
}
