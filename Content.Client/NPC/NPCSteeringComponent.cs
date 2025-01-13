// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;

namespace Content.Client.NPC;

[RegisterComponent]
public sealed partial class NPCSteeringComponent : Component
{
    /* Not hooked up to the server component as it's used for debugging only.
     */

    public Vector2 Direction;

    public float[] DangerMap = Array.Empty<float>();
    public float[] InterestMap = Array.Empty<float>();
    public List<Vector2> DangerPoints = new();
}
