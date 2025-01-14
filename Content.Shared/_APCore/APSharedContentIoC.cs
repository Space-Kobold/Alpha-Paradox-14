// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Core.EntPrototypes;
// ReSharper disable once CheckNamespace
namespace Content.Shared.IoC
{
    public static class APSharedContentIoC
    {
        public static void Register()
        {
            IoCManager.Register<EntProtoCache, EntProtoCache>();
        }
    }
}
