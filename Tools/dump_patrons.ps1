#!/usr/bin/env pwsh

# SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
#
# SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

param([string]$csvPath)

# Dumps Patreon's CSV download into a YAML file the game reads.

# Have to trim patron names because apparently Patreon doesn't which is quite ridiculous.
Get-content $csvPath | ConvertFrom-Csv -Delimiter "," | select @{l="Name";e={$_.Name.Trim()}},Tier | where-object Tier -ne "" | ConvertTo-Yaml
