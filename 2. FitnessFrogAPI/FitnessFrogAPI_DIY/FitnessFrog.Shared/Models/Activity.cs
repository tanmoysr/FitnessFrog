﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace FitnessFrog.Shared.Models
{
    /// <summary>
    /// Represents a physical activity.
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Constructor for creating activities.
        /// </summary>
        public Activity()
        {
            Entries = new List<Entry>();
        }

        /// <summary>
        /// The ID of the activity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The entries associated with this activity.
        /// </summary>
        [JsonIgnore]
        public IList<Entry> Entries { get; set; }
    }
}