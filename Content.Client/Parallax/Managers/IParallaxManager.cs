// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using System.Threading.Tasks;
using Robust.Shared.Maths;

namespace Content.Client.Parallax.Managers;

public interface IParallaxManager
{
    /// <summary>
    /// All WorldHomePosition values are offset by this.
    /// </summary>
    Vector2 ParallaxAnchor { get; set; }

    bool IsLoaded(string name);

    /// <summary>
    /// The layers of the selected parallax.
    /// </summary>
    ParallaxLayerPrepared[] GetParallaxLayers(string name);

    /// <summary>
    /// Loads in the default parallax to use.
    /// Do not call until prototype manager is available.
    /// </summary>
    void LoadDefaultParallax();

    Task LoadParallaxByName(string name);

    void UnloadParallax(string name);
}

