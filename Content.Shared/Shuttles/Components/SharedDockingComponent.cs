// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Shuttles.Components
{
    public abstract partial class SharedDockingComponent : Component
    {
        // Yes I left this in for now because there's no overhead and we'll need a client one later anyway
        // and I was too lazy to delete it.

        public abstract bool Docked { get; }
    }
}
