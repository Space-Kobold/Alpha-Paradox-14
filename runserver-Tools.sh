#!/bin/sh

# SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
#
# SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

dotnet run --project Content.Server --configuration Tools
read -p "Press enter to continue"
