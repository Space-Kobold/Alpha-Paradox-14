#!/usr/bin/env python3

# SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
#
# SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

# Import future so people on py2 still get the clear error that they need to upgrade.
from __future__ import print_function
import sys
import subprocess

version = sys.version_info
if version.major < 3 or (version.major == 3 and version.minor < 5):
    print("ERROR: You need at least Python 3.5 to build SS14.")
    sys.exit(1)

subprocess.run([sys.executable, "git_helper.py"], cwd="BuildChecker")
