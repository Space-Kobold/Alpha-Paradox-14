// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Threading;
using System.Threading.Tasks;
using Content.Packaging;
using Robust.Packaging;
using Robust.Packaging.AssetProcessing;
using Robust.Server.ServerStatus;

namespace Content.Server.Acz;

public sealed class ContentMagicAczProvider : IMagicAczProvider
{
    private readonly IDependencyCollection _deps;

    public ContentMagicAczProvider(IDependencyCollection deps)
    {
        _deps = deps;
    }

    public async Task Package(AssetPass pass, IPackageLogger logger, CancellationToken cancel)
    {
        var contentDir = DefaultMagicAczProvider.FindContentRootPath(_deps);

        await ClientPackaging.WriteResources(contentDir, pass, logger, cancel);
    }
}
