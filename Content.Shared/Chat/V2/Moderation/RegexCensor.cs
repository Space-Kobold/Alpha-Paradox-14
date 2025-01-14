// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.RegularExpressions;

namespace Content.Shared.Chat.V2.Moderation;

public sealed class RegexCensor(Regex censorInstruction) : IChatCensor
{
    private readonly Regex _censorInstruction = censorInstruction;

    public bool Censor(string input, out string output, char replaceWith = '*')
    {
        output = _censorInstruction.Replace(input, replaceWith.ToString());

        return !string.Equals(input, output);
    }
}
