// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.GameStates;

namespace Content.Shared.Species.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ReformComponent : Component
{
    /// <summary>
    /// The action to use.
    /// </summary>
    [DataField(required: true)]
    public EntProtoId ActionPrototype = default!;

    [DataField, AutoNetworkedField] 
    public EntityUid? ActionEntity;

    /// <summary>
    /// How long it will take to reform
    /// </summary>
    [DataField(required: true)]
    public float ReformTime = 0;

    /// <summary>
    /// Whether or not the entity should start with a cooldown
    /// </summary>
    [DataField]
    public bool StartDelayed = true;

    /// <summary>
    /// Whether or not the entity should be stunned when reforming at all
    /// </summary>
    [DataField]
    public bool ShouldStun = true;

    /// <summary>
    /// The text that appears when attempting to reform
    /// </summary>
    [DataField(required: true)]
    public string PopupText;

    /// <summary>
    /// The mob that our entity will reform into
    /// </summary>
    [DataField(required: true)]
    public EntProtoId ReformPrototype { get; private set; }
}
