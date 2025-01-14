// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Radio.Components;

/// <summary>
///     This component allows an entity to directly translate radio messages into chat messages. Note that this does not
///     automatically add an <see cref="ActiveRadioComponent"/>, which is required to receive radio messages on specific
///     channels.
/// </summary>
[RegisterComponent]
public sealed partial class IntrinsicRadioReceiverComponent : Component
{
}
