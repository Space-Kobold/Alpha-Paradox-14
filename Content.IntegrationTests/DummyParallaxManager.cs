// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Content.Client.Parallax.Managers;
using Content.Client.Parallax;
using Robust.Shared.Maths;

namespace Content.IntegrationTests
{
    public sealed class DummyParallaxManager : IParallaxManager
    {
        public Vector2 ParallaxAnchor { get; set; }
        public bool IsLoaded(string name)
        {
            return true;
        }

        public ParallaxLayerPrepared[] GetParallaxLayers(string name)
        {
            return Array.Empty<ParallaxLayerPrepared>();
        }

        public void LoadDefaultParallax()
        {
            return;
        }

        public Task LoadParallaxByName(string name)
        {
            return Task.CompletedTask;
        }

        public void UnloadParallax(string name)
        {
            return;
        }
    }
}
