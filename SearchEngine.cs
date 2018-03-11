using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NendoroidAccessorySearchEngine.Core.Model;
using Nendoroido.Core.Import;

namespace NendoroidAccessorySearchEngine.Core
{
    /// <summary>
    /// search engine
    /// </summary>
    public class SearchEngine
    {
        /// <summary>
        /// Importer
        /// </summary>
        public BaseInporter Importer { get; set; }



        /// <summary>
        /// call import,
        /// will import the source file to SearchEngine for analyze
        /// </summary>
        public void Import()
        {

        }

        //throw the image into here, and get the result
        public Task<List<SearchResult>> Search()
        {
            return null;
        }
    }
}
