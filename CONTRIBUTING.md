<!--
SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors <https://github.com/space-kobold/alpha-paradox>

SPDX-License-Identifier: CC-BY-SA-4.0
-->

# CONTRIBUTING

## Notice

This document isn't always kept up to date, and we would highly recommend you read the [Development
Wiki](https://devwiki.alpha-paradox.com).

The purpose of this is to condense down the bare minimum required to _build_ and contribute the game, not to set up a nice development
environment.

## Dependencies

Required to build: (Non-Exhaustive)

- dotnet SDK 8.0 (soon to be 9.0)
- Git
- Python (for build scripts)

Optional:

- Fluidsynth & Soundfront-Fluid (MIDI)
- reuse-tool (Attribution/Copyright, required to lint and provides useful interface for adding headers)

## Building

1. Clone this repository locally.
2. Run `RUN_THIS.py` in the root of the project, which should update the submodules and set up Git hooks.
3. Build the solution using `dotnet build`.
4. Run the game:
    - `dotnet run --project Content.Server`
    - `dotnet run --project Content.Client`

## Contribution Policies

Be respectful, and read the [Contribution Guidelines](https://devwiki.alpha-paradox.com/index.php/Guide:Contribution_Guidelines).

### Contributor License Agreement

Read the `Contributor License Agreement` section of [LEGAL.md](./LEGAL.md).

### Attribution/Sourcing

Read the `Attribution/Sourcing` section of [LEGAL.md](./LEGAL.md) and the [Contribution Guidelines](https://devwiki.alpha-paradox.com/index.php/Guide:Contribution_Guidelines).
