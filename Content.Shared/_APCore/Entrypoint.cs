// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Core.EntPrototypes;
using Content.Shared.IoC;

namespace Content.Shared._APCore;

public sealed class Entrypoint
{
    public void PreInit()
    {
        APSharedContentIoC.Register();
        IoCManager.InjectDependencies(this);
    }
    public void Init()
    {
    }

    public void PostInit()
    {
        IoCManager.Resolve<EntProtoCache>().Initialize();
    }

    public void Shutdown()
    {
    }

}
