// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Linq;

namespace Content.Server.Atmos;

public readonly record struct GasMixtureStringRepresentation(float TotalMoles, float Temperature, float Pressure, Dictionary<string, float> MolesPerGas) : IFormattable
{
    public override string ToString()
    {
        return $"{Temperature}K {Pressure} kPa";
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return ToString();
    }

    public static implicit operator string(GasMixtureStringRepresentation rep) => rep.ToString();
}
