// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Diagnostics.CodeAnalysis;
using Content.Client.Guidebook.Richtext;
using Robust.Client.Console;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Administration.UI.CustomControls
{
    [Virtual]
    public class CommandButton : Button, IDocumentTag
    {
        public string? Command { get; set; }

        public CommandButton()
        {
            OnPressed += Execute;
        }

        protected virtual bool CanPress()
        {
            return string.IsNullOrEmpty(Command) ||
                   IoCManager.Resolve<IClientConGroupController>().CanCommand(Command.Split(' ')[0]);
        }

        protected override void EnteredTree()
        {
            if (!CanPress())
            {
                Visible = false;
            }
        }

        protected virtual void Execute(ButtonEventArgs obj)
        {
            // Default is to execute command
            if (!string.IsNullOrEmpty(Command))
                IoCManager.Resolve<IClientConsoleHost>().ExecuteCommand(Command);
        }

        public bool TryParseTag(Dictionary<string, string> args, [NotNullWhen(true)] out Control? control)
        {
            if (args.Count != 2 || !args.TryGetValue("Text", out var text) || !args.TryGetValue("Command", out var command))
            {
                Logger.Error($"Invalid arguments passed to {nameof(CommandButton)}");
                control = null;
                return false;
            }

            Command = command;
            Text = Loc.GetString(text);
            control = this;
            return true;
        }
    }
}
