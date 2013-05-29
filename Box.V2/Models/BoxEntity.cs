﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2.Models
{
    public class BoxEntity
    {
        /// <summary>
        /// For file is 'file'
        /// For folders is ‘folder'
        /// For collaborations is 'collaboration'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// The folder’s ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}