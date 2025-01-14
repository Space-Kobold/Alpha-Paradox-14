// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.MoMMI
{
    public interface IMoMMILink
    {
        void SendOOCMessage(string sender, string message);
    }
}
