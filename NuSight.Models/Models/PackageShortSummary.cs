﻿using System;
using System.Text.RegularExpressions;

namespace NuSight.Models.Models
{
    public class PackageShortSummary
    {
        public string PackageApiUrl { get; set; }

        public string NugetPackageId { get; set; }

        public string IconUrl { get; set; }

        public string Description { get; set; }

        public string ProjectUrl { get; set; }

        public string LatestVersion { get; set; }

        public string LatestReleaseVersion { get; set; }

        public int BehindCount { get; set; }

        public bool IsUnpublished { get; set; }
    }
}
