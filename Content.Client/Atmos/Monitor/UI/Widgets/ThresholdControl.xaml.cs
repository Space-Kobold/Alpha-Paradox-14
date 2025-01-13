// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Atmos;
using Content.Shared.Atmos.Monitor;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

// holy FUCK
// this technically works because some of this you can *not* do in XAML but holy FUCK

namespace Content.Client.Atmos.Monitor.UI.Widgets;

[GenerateTypedNameReferences]
public sealed partial class ThresholdControl : BoxContainer
{
    private AtmosAlarmThreshold _threshold;
    private AtmosMonitorThresholdType _type;
    private Gas? _gas;

    public event Action<AtmosMonitorThresholdType, AtmosAlarmThreshold, Gas?>? ThresholdDataChanged;

    private CollapsibleHeading _name => CName;
    private CheckBox _enabled => CEnabled;
    private BoxContainer _dangerBounds => CDangerBounds;
    private BoxContainer _warningBounds => CWarningBounds;
    private ThresholdBoundControl _upperBoundControl;
    private ThresholdBoundControl _lowerBoundControl;
    private ThresholdBoundControl _upperWarningBoundControl;
    private ThresholdBoundControl _lowerWarningBoundControl;

    // i have played myself by making threshold values nullable to
    // indicate validity/disabled status, with several layers of side effect
    // dependent on the other three values when you change one :HECK:
    public ThresholdControl(string name, AtmosAlarmThreshold threshold, AtmosMonitorThresholdType type, Gas? gas = null, float modifier = 1)
    {
        RobustXamlLoader.Load(this);

        _threshold = threshold;
        _type = type;
        _gas = gas;

        _name.Title = name;

        // i miss rust macros

        _upperBoundControl = new ThresholdBoundControl(LabelForBound("upper-bound"), _threshold.UpperBound.Value, modifier);
        _upperBoundControl.OnBoundChanged += (value) =>
        {
            _threshold.SetLimit(AtmosMonitorLimitType.UpperDanger, value);
        };
        _upperBoundControl.OnBoundEnabled += (isEnabled) =>
        {
            _threshold.SetEnabled(AtmosMonitorLimitType.UpperDanger, isEnabled);
        };
        _upperBoundControl.OnValidBoundChanged += () =>
        {
            ThresholdDataChanged!.Invoke(_type, _threshold, _gas);
        };
        _dangerBounds.AddChild(_upperBoundControl);

        _lowerBoundControl = new ThresholdBoundControl(LabelForBound("lower-bound"), _threshold.LowerBound.Value, modifier);
        _lowerBoundControl.OnBoundChanged += value =>
        {
            _threshold.SetLimit(AtmosMonitorLimitType.LowerDanger, value);
        };
        _lowerBoundControl.OnBoundEnabled += (isEnabled) =>
        {
            _threshold.SetEnabled(AtmosMonitorLimitType.LowerDanger, isEnabled);
        };
        _lowerBoundControl.OnValidBoundChanged += () =>
        {
            ThresholdDataChanged!.Invoke(_type, _threshold, _gas);
        };
        _dangerBounds.AddChild(_lowerBoundControl);

        _upperWarningBoundControl = new ThresholdBoundControl(LabelForBound("upper-warning-bound"), _threshold.UpperWarningBound.Value, modifier);
        _upperWarningBoundControl.OnBoundChanged += value =>
        {
            _threshold.SetLimit(AtmosMonitorLimitType.UpperWarning, value);
        };
        _upperWarningBoundControl.OnBoundEnabled += (isEnabled) =>
        {
            _threshold.SetEnabled(AtmosMonitorLimitType.UpperWarning, isEnabled);
        };
        _upperWarningBoundControl.OnValidBoundChanged += () =>
        {
            ThresholdDataChanged!.Invoke(_type, _threshold, _gas);
        };
        _warningBounds.AddChild(_upperWarningBoundControl);

        _lowerWarningBoundControl = new ThresholdBoundControl(LabelForBound("lower-warning-bound"), _threshold.LowerWarningBound.Value, modifier);
        _lowerWarningBoundControl.OnBoundChanged += value =>
        {
            _threshold.SetLimit(AtmosMonitorLimitType.LowerWarning, value);
        };
        _lowerWarningBoundControl.OnBoundEnabled += (isEnabled) =>
        {
            _threshold.SetEnabled(AtmosMonitorLimitType.LowerWarning, isEnabled);
        };
        _lowerWarningBoundControl.OnValidBoundChanged += () =>
        {
            ThresholdDataChanged!.Invoke(_type, _threshold, _gas);
        };

        _warningBounds.AddChild(_lowerWarningBoundControl);

        _enabled.OnToggled += args =>
        {
            _threshold.Ignore = !args.Pressed;
            ThresholdDataChanged!.Invoke(_type, _threshold, _gas);
        };
        _enabled.Pressed = !_threshold.Ignore;
    }

    private string LabelForBound(string boundType) //<todo.eoin Replace this with enums
    {
        return Loc.GetString($"air-alarm-ui-thresholds-{boundType}");
    }

    public void UpdateThresholdData(AtmosAlarmThreshold threshold, float currentAmount)
    {
        threshold.CheckThreshold(currentAmount, out var alarm, out var bound);

        var upperDangerState = AtmosAlarmType.Normal;
        var lowerDangerState = AtmosAlarmType.Normal;
        var upperWarningState = AtmosAlarmType.Normal;
        var lowerWarningState = AtmosAlarmType.Normal;

        switch (alarm)
        {
            case AtmosAlarmType.Danger:
            {
                if (bound == AtmosMonitorThresholdBound.Upper)
                    upperDangerState = alarm;
                else
                    lowerDangerState = alarm;
                break;
            }
            case AtmosAlarmType.Warning:
            {
                if (bound == AtmosMonitorThresholdBound.Upper)
                    upperWarningState = alarm;
                else
                    lowerWarningState = alarm;
                break;
            }
        }

        _upperBoundControl.SetValue(threshold.UpperBound.Value);
        _upperBoundControl.SetEnabled(threshold.UpperBound.Enabled);
        _upperBoundControl.SetWarningState(upperDangerState);

        _lowerBoundControl.SetValue(threshold.LowerBound.Value);
        _lowerBoundControl.SetEnabled(threshold.LowerBound.Enabled);
        _lowerBoundControl.SetWarningState(lowerDangerState);

        _upperWarningBoundControl.SetValue(threshold.UpperWarningBound.Value);
        _upperWarningBoundControl.SetEnabled(threshold.UpperWarningBound.Enabled);
        _upperWarningBoundControl.SetWarningState(upperWarningState);

        _lowerWarningBoundControl.SetValue(threshold.LowerWarningBound.Value);
        _lowerWarningBoundControl.SetEnabled(threshold.LowerWarningBound.Enabled);
        _lowerWarningBoundControl.SetWarningState(lowerWarningState);

        _enabled.Pressed = !threshold.Ignore;
    }
}
