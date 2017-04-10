﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bundler.Extensions {

    /// <summary>
    /// Provides extension methods to the <see cref="System.IO.DirectoryInfo"/> type.
    /// </summary>
    public static class DirectoryInfoExtensions {

        /// <summary>
        /// Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.
        /// Will return an empty enumerable on exception. Quick and dirty but does what I need just now.
        /// </summary>
        /// <param name="directoryInfo">
        /// The <see cref="System.IO.DirectoryInfo"/> that this method extends.
        /// </param>
        /// <param name="searchPattern">
        /// The search string to match against the names of directories. This parameter can contain a combination of valid literal path 
        /// and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.
        /// </param>
        /// <param name="searchOption">
        /// One of the enumeration values that specifies whether the search operation should include only 
        /// the current directory or all subdirectories. The default value is TopDirectoryOnly.
        /// </param>
        /// <returns>
        /// An enumerable collection of file info that matches searchPattern and searchOption.
        /// </returns>
        public async static Task<IEnumerable<FileInfo>> EnumerateFilesAsync(this DirectoryInfo directoryInfo, string searchPattern = "*",  SearchOption searchOption = SearchOption.TopDirectoryOnly) {
            return await Task.Run(() => directoryInfo.EnumerateFiles(searchPattern, searchOption)).ConfigureAwait(false);
        }
    }
}
