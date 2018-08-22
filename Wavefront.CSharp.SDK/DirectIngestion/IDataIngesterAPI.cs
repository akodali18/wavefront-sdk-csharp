﻿using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wavefront.CSharp.SDK.DirectIngestion
{
    /// <summary>
    /// The API for reporting points directly to a Wavefront server
    /// </summary>
    public interface IDataIngesterAPI
    {
        /// <summary>
        /// Report the specified stream in the specified format.
        /// </summary>
        /// <returns>The status code of the response from the Wavefront server.</returns>
        /// <param name="format">
        /// The format of the data. Valid formats are defined in <see cref="Wavefront.CSharp.SDK.Common.Constants"/>.
        /// </param>
        /// <param name="stream">The stream of data to be reported.</param>
        int Report(string format, Stream stream);
    }
}
