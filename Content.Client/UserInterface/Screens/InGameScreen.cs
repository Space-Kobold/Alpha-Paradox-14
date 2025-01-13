// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Content.Client.UserInterface.Systems.Chat.Widgets;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.UserInterface.Screens;

/// <summary>
///     Screens that are considered to be 'in-game'.
/// </summary>
public abstract class InGameScreen : UIScreen
{
    public Action<Vector2>? OnChatResized;

    public abstract ChatBox ChatBox { get; }

    public abstract void SetChatSize(Vector2 size);
}
