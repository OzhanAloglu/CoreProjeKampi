﻿namespace Asp.Net.Kamp.Models
{
	public class AddProfileImage
	{

		public int WriterID { get; set; }
		public string? WriterName { get; set; }
		public string? WriterAbout { get; set; }
		public IFormFile WriterImage { get; set; }
		public string? WriterMail { get; set; }
		public string? WriterPassword { get; set; }

		public string? WriterPassword2 { get; set; }
		public bool? WriterStatus { get; set; }




	}
}
