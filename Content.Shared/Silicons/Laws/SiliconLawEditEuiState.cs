// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared.Silicons.Laws;

[Serializable, NetSerializable]
public sealed class SiliconLawsEuiState : EuiStateBase
{
    public List<SiliconLaw> Laws { get; }
    public NetEntity Target { get; }
    public SiliconLawsEuiState(List<SiliconLaw> laws, NetEntity target)
    {
        Laws = laws;
        Target = target;
    }
}

[Serializable, NetSerializable]
public sealed class SiliconLawsSaveMessage : EuiMessageBase
{
    public List<SiliconLaw> Laws { get; }
    public NetEntity Target { get; }

    public SiliconLawsSaveMessage(List<SiliconLaw> laws, NetEntity target)
    {
        Laws = laws;
        Target = target;
    }
}
