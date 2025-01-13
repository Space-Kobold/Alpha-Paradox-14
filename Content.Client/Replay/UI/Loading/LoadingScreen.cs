// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.ResourceManagement;
using Robust.Client.State;
using Robust.Client.UserInterface;
using Robust.Shared.CPUJob.JobQueues;
using Robust.Shared.Timing;

namespace Content.Client.Replay.UI.Loading;

[Virtual]
public class LoadingScreen<TResult> : State
{
    [Dependency] private readonly IResourceCache _resourceCache = default!;
    [Dependency] private readonly IUserInterfaceManager _userInterfaceManager = default!;

    public event Action<TResult?, Exception?>? OnJobFinished;
    private LoadingScreenControl _screen = default!;
    public Job<TResult>? Job;

    public override void FrameUpdate(FrameEventArgs e)
    {
        base.FrameUpdate(e);
        if (Job == null)
            return;

        Job.Run();
        if (Job.Status != JobStatus.Finished)
            return;

        OnJobFinished?.Invoke(Job.Result, Job.Exception);
        Job = null;
    }

    protected override void Startup()
    {
        _screen = new(_resourceCache);
        _userInterfaceManager.StateRoot.AddChild(_screen);
    }

    protected override void Shutdown()
    {
        _screen.Dispose();
    }

    public void UpdateProgress(float value, float maxValue, string header, string subtext = "")
    {
        _screen.Bar.Value = value;
        _screen.Bar.MaxValue = maxValue;
        _screen.Header.Text = header;
        _screen.Subtext.Text = subtext;
    }
}
