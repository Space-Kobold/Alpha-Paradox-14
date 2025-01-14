// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Chat.TypingIndicator;

/// <summary>
///     Prototype to store chat typing indicator visuals.
/// </summary>
[Prototype("typingIndicator")]
public sealed partial class TypingIndicatorPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("spritePath")]
    public ResPath SpritePath = new("/Textures/Effects/speech.rsi");

    [DataField("typingState", required: true)]
    public string TypingState = default!;

    [DataField("offset")]
    public Vector2 Offset = new(0, 0);

    [DataField("shader")]
    public string Shader = "shaded";

}
