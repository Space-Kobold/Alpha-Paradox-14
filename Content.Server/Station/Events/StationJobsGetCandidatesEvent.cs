// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;
using Robust.Shared.Network;
using Robust.Shared.Prototypes;

namespace Content.Server.Station.Events;

[ByRefEvent]
public readonly record struct StationJobsGetCandidatesEvent(NetUserId Player, List<ProtoId<JobPrototype>> Jobs);
