﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Collectors_Corner_Backend.Models
{
	public class JwtSettings
	{
		public string? Issuer {get;set;}
		public string? Audience { get; set; }
		public string? Key { get; set; }
		public SymmetricSecurityKey GetSymmetricSecurityKey() =>
			new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
	}
}
