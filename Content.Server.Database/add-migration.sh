#!/usr/bin/env bash

# SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
#
# SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

if [ -z "$1" ] ; then
    echo "Must specify migration name"
    exit 1
fi

dotnet ef migrations add --context SqliteServerDbContext -o Migrations/Sqlite "$1"
dotnet ef migrations add --context PostgresServerDbContext -o Migrations/Postgres "$1"
