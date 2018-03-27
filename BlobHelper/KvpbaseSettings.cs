﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobHelper
{
    /// <summary>
    /// Settings when using kvpbase for storage.
    /// </summary>
    public class KvpbaseSettings
    {
        /// <summary>
        /// Kvpbase endpoint URL, of the form http://[hostname]:[port]/.
        /// </summary>
        public string Endpoint { get; private set; }

        /// <summary>
        /// Kvpbase user GUID.
        /// </summary>
        public string UserGuid { get; private set; }

        /// <summary>
        /// Kvpbase container.
        /// </summary>
        public string Container { get; private set; }

        /// <summary>
        /// Kvpbase API key.
        /// </summary>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Initialize the object.
        /// </summary>
        /// <param name="endpoint">Kvpbase endpoint, i.e. http://localhost:8000/</param>
        /// <param name="userGuid">GUID of the user.</param>
        /// <param name="container">Container in which BLOBs should be stored.</param>
        /// <param name="apiKey">API key with read, write, and delete permissions.</param>
        public KvpbaseSettings(string endpoint, string userGuid, string container, string apiKey)
        {
            if (String.IsNullOrEmpty(endpoint)) throw new ArgumentNullException(nameof(endpoint));
            if (String.IsNullOrEmpty(userGuid)) throw new ArgumentNullException(nameof(userGuid));
            if (String.IsNullOrEmpty(apiKey)) throw new ArgumentNullException(nameof(apiKey));
            Endpoint = endpoint;
            UserGuid = userGuid;
            Container = container;
            ApiKey = apiKey;
        }
    }
}
