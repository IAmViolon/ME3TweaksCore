﻿using System.Linq;
using System.Collections.Generic;
using System.Linq;
using LegendaryExplorerCore.Packages;

namespace ME3TweaksCore.NativeMods
{
    /// <summary>
    /// Represents a single group of ASI mods across versions. This is used to help prevent installation of duplicate ASIs even if the names differ
    /// </summary>
    public class ASIMod
    {
        /// <summary>
        /// Versions of this ASI
        /// </summary>
        public List<ASIModVersion> Versions { get; internal set; }
        /// <summary>
        /// The unique ID of the ASI
        /// </summary>
        public int UpdateGroupId { get; internal set; }
        /// <summary>
        /// The game this ASI is applicable to
        /// </summary>
        public MEGame Game { get; internal set; }
        /// <summary>
        /// If this ASI is not to be shown in a UI, but exists to help catalog and identify if it is installed
        /// </summary>
        public bool IsHidden { get; set; }
        /// <summary>
        /// Gets the latest version of the ASI
        /// </summary>
        /// <returns></returns>
        public ASIModVersion LatestVersion => Versions.Where(x=> ASIManager.UsingBeta || !x.IsBeta).MaxBy(x => x.Version);
        /// <summary>
        /// If any of the versions of this ASI match the given hash
        /// </summary>
        /// <param name="asiHash"></param>
        /// <returns></returns>
        public bool HasMatchingHash(string asiHash)
        {
            return Versions.FirstOrDefault(x => x.Hash == asiHash) != null;
        }
    }
}
