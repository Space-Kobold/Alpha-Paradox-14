<!--
    SPDX-License-Identifier: CC-BY-SA-4.0

    SPDX-FileCopyrightText: Space Kobold Games and Contributors <https://github.com/space-kobold/alpha-paradox>
-->

# LEGAL.md

## Disclaimer

**The information presented here is for informational purposes only and does not constitute legal advice, nor is it a replacement for reading license or agreement texts.**

**If there is a conflict between this text and any of the attached licenses/agreements, or other agreements with Space Kobold those agreements take precedence.**

## Contributor License Agreement

**In order to contibute, you (or your legal guardian or your employer) must agree to the [Space Kobold Games Contributor Agreement](https://gist.github.com/SpaceKoboldGames/a8f6b7a7d272cf949c60e0822cdf226e)**

The verification process is automated, as you will be prompted by a bot to agree to the CLA when you open your first PR.

This may also be done by sending an email with the subject "\<yourname\> CLA Agreement," with an attached signed version of the agreement.

**THIS "SUMMARY" IS NEITHER LEGAL ADVISE NOR AN AGREEMENT, AND THIS IS NOT A SUBSTITUTE/REPLACEMENT FOR THE ACTUAL CLA TEXT:**

Non-legalese summary of the terms of this agreement (This is not a replacement for reading the agreement):
- __*You keep your copyright for <u>your contribution*__, and **Non-exclusively** grant us *the same rights to use your contribution*. Please note this does not grant you any rights to *the project as a whole* outside of those specified in the project license.
- The CA only applies to *your original contributions*, not works submitted under an approved license or other negotiated license.
- You have a legal right to attribution (moral rights) in the credits of the project, please tell us if you wish to opt out of being displayed in the credits or wish to use an alternative name.
- If you patent or have patented any parts of your contribution, you give us the right to those use those patents in respect to the project.
- As much as possible, you are protected from legal liability for contributing (This does not protect you against copyright infringement liability).
- Any legal proceedings related to the CLA will be governed by Canadian law.
- The CLA may be amended with 30 days of notice by email. *If you do not agree to the new CLA your contributions will be kept under the old version.*

##  Licensing/Attribution:

Attributions are a good-faith attempt by contributors to properly credit the copyright holders of the assets held in
this repository. An attribution is not a warranty against possible damages, and the attributors/Space Kobold is not
responsible for any damages resulting from their use.

**ATTRIBUTIONS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE ATTRIBUTIONS OR THE USE OR OTHER DEALINGS IN THE ATTRIBUTIONS.**

**We are in the process of cleaning up attributions and removing content that uses disapproved licenses, so take the
current attributions with a large grain of salt.**

### Attribution/Sourcing Requirements

Space Kobold has a strict policy of only accepting **appropriately licensed and attributed** contributions.

If you make PRs that misrepresent the attribution or license, you will be removed from the project.

All files should either have a REUSE header or should be licensed inside of a `REUSE.toml` file found in the same
directory.

For code files, we generally attribute copyright to "Space Kobold Games and Contributors", as we handle attributions
separately though parsing the Git history.

Proper attribution includes: (based on CC's [Recommended Practices for Attribution](https://wiki.creativecommons.org/wiki/Recommended_practices_for_attribution))
- Title of original work
- Link to original work (preferably not a link to Alpha Paradox's GitHub if possible)
- Author's name (Legal prefered, pseudonyms are accepted). If the author requests for their name to be changed/removed,
  it must be changed/removed.
- Author's contact (email address prefered, other online services such as SoundCloud/GitHub/FreeSounds/Same website as
  sourse. Discord is not acceptable for contact).
- The correct license that the author has set it to.
- Minor modifications listed at the end, and major modifications also crediting the contributor.

You should never delete an attribution. They must always be preserved, even if you are contributing to a non-Alpha
Paradox codebase.

### Miscellaneous Licensing Reminders

If a Creative Commons license does not list the version, it is not a valid license.

You may see "`LicenseRef-MIT-_`" licenses, and these are there because the projects modified the license to add their
own copyright information to it. Keeping the original license verbatim is part of the license terms, so we need to work around
the problem by keeping it the same. Only use the regular `MIT` license for Alpha Paradox contributions.

You cannot relicense MPLv2 No Copyleft Exception code as GPL, so you cannot use it in a GPL codebase. This is to stop
possible fragmentation as we'd prefer if we could upstream any downstream's code instead of fragmenting into MIT and GPL
communities.

YouTube is not a source for sound effect licensing.

Additionally, even though CC0 does not require attribution, we still require attribution. This is just a policy that we
hold.

Also, we do not take "Public Domain" licenses outside of CC0 as the Public Domain is not consistant across borders and jurisdictions.
Use CC0 instead, as it was created to resolve these exact problems.

When contributing MPLv2 changes to an MIT file, make sure that you use the "AND" to list both the MIT and MPLv2 license.
The MIT license requires that the MIT attribution is kept even if the new contributions are under MPLv2.

**"AND" licenses does not mean you can pick which one you want, it means you have to comply with BOTH.**

### Approved Licenses

The following licenses are approved and highly recommended to be used:

- `CC-BY-SA-4.0`
- `MPL-2.0-no-copyleft-exception` (or regular `MPL-2.0`)
- `MIT`
- `CC-BY-4.0`
- `CC0`

### Acceptable Licenses

If it is not possible to request the author to transition to a newer CC license, these are acceptable:

- `CC-BY-ND-4.0`
- `CC-BY-ND-3.0`
- `CC-BY-3.0`
- `CC-BY-SA-3.0`

### Disapproved Licenses

These licenses should not be merged into the codebase, and usually only exist as a legacy holdover.

Just because a license isn't explicitly on this list, if it isn't approved/acceptable, we will not accept a contribution
under it.

- Unlicensed / All Rights Reserved
- Non-Commerical Licenses
- "Strong" copyleft (GPL, AGPL, etc)
- "Public Domain"

#### Example Header

```csharp
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception AND LicenseRef-MIT-SpaceWizards
//
// SPDX-FileCopyrightText: Space Kobold Games and Contributors <https://github.com/space-kobold/alpha-paradox>
// SPDX-FileCopyrightText: Space Wizards and Contributors <https://github.com/space-wizards/space-station-14>
```

#### Example REUSE.toml

```
version = 1

[[annotations]]
path = [
    "base.png",
]
SPDX-FileCopyrightText = [
    "(c) 2011 Farart",
]
SPDX-FileContributor = [
    "Created by Farart",
    "Added to /tg/station by Rastaf0 <rastaf.zero@gmail.com>",
    "Ported to space-station-14 and converted to RSI by Vera Aguilera Puerto <gradientvera@outlook.com>",
]
SPDX-License-Identifier = "CC-BY-SA-3.0"
SPDX-FileNotice = "All modifications must maintain original attribution and be released under the CC-BY-SA-3.0 license."
SPDX-FileAttributionText = """
"hydrotray3" (https://github.com/tgstation/tgstation/blob/84d92a111e7717a3aa689ce255c373af8735d7be/icons/obj/hydroponics.dmi) by Farart for /tg/station is licensed under CC BY-SA 3.0 / Converted DMI to RSI.
"""
SPDX-LicenseComments = """
License Determination:
1. Explicit Assertions:
   - tgstation uses CC-BY-SA-3.0 for content attributions.

2. Implicit Evidence:
   - Consistent history of sprite contributions credited to Farart from 2010-2012.
   - No competing license claims

3. Verification:
   - Unable to contact Farart due to trouble finding an associated contact address.
"""
```
