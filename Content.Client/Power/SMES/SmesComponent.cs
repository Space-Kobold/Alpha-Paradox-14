// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Power.SMES;

[RegisterComponent]
public sealed partial class SmesComponent : Component
{
    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the charge level of the SMES.
    /// </summary>
    [DataField("chargeOverlayPrefix")]
    [ViewVariables(VVAccess.ReadWrite)]
    public string ChargeOverlayPrefix = "smes-og";

    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the input state of the SMES.
    /// Actually bundled together with the output indicator light.
    /// </summary>
    [DataField("inputOverlayPrefix")]
    [ViewVariables(VVAccess.ReadWrite)]
    public string InputOverlayPrefix = "smes-oc";

    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the output state of the SMES.
    /// Actually bundled together with the input indicator light.
    /// </summary>
    [DataField("outputOverlayPrefix")]
    [ViewVariables(VVAccess.ReadWrite)]
    public string OutputOverlayPrefix = "smes-op";
}
