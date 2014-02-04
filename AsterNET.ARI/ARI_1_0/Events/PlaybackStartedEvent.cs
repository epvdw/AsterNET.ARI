﻿using System;
using System.Collections.Generic;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Event showing the start of a media playback operation.
	/// </summary>
	public class PlaybackStartedEvent  : Event
	{
		/// <summary>
		/// Playback control object
		/// </summary>
		public Playback Playback { get; set; }

	}
}