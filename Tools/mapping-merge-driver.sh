#!/bin/sh

# SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
#
# SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

# Add this to .git/config:
# [merge "mapping-merge-driver"]
#         name = Merge driver for maps
#         driver = Tools/mapping-merge-driver.sh %A %O %B

dotnet run --project ./Content.Tools "$@"

