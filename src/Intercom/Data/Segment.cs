﻿using System;
using Intercom.Core;
using Intercom.Data;


using Intercom.Clients;

using Intercom.Exceptions;


namespace Intercom.Data
{
	public class Segment : Model
	{
        public string name { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }

		public Segment ()
		{
		}
	}
}

