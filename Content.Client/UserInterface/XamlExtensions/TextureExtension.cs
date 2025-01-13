// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Resources;
using JetBrains.Annotations;
using Robust.Client.ResourceManagement;

namespace Content.Client.UserInterface.XamlExtensions;


[PublicAPI]
public sealed class TexExtension
{
    private IResourceCache _resourceCache;
    public string Path { get; }

    public TexExtension(string path)
    {
        _resourceCache = IoCManager.Resolve<IResourceCache>();
        Path = path;
    }

    public object ProvideValue()
    {
        return _resourceCache.GetTexture(Path);
    }
}
