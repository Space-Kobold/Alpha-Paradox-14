// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;
using Content.Shared.MassMedia.Systems;

namespace Content.Shared.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class NewsReaderBoundUserInterfaceState : BoundUserInterfaceState
{
    public NewsArticle Article;
    public int TargetNum;
    public int TotalNum;
    public bool NotificationOn;

    public NewsReaderBoundUserInterfaceState(NewsArticle article, int targetNum, int totalNum, bool notificationOn)
    {
        Article = article;
        TargetNum = targetNum;
        TotalNum = totalNum;
        NotificationOn = notificationOn;
    }
}

[Serializable, NetSerializable]
public sealed class NewsReaderEmptyBoundUserInterfaceState : BoundUserInterfaceState
{
    public bool NotificationOn;

    public NewsReaderEmptyBoundUserInterfaceState(bool notificationOn)
    {
        NotificationOn = notificationOn;
    }
}
