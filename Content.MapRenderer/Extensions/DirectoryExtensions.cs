// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.IO;
using System.Reflection;

namespace Content.MapRenderer.Extensions
{
    public static class DirectoryExtensions
    {
        public static DirectoryInfo RepositoryRoot()
        {
            // space-station-14/bin/Content.MapRenderer/Content.MapRenderer.dll
            var currentLocation = Assembly.GetExecutingAssembly().Location;

            // space-station-14
            return Directory.GetParent(currentLocation)!.Parent!.Parent!;
        }

        public static DirectoryInfo Resources()
        {
            return new DirectoryInfo($"{RepositoryRoot()}{Path.DirectorySeparatorChar}Resources");
        }

        public static DirectoryInfo Maps()
        {
            return new DirectoryInfo($"{Resources()}{Path.DirectorySeparatorChar}Maps");
        }

        public static DirectoryInfo MapImages()
        {
            return new DirectoryInfo($"{Resources()}{Path.DirectorySeparatorChar}MapImages");
        }
    }
}
