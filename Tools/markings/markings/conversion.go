// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

package markings

func accessories_to_markings(accessories []SpriteAccessoryPrototype) ([]MarkingPrototype, error) {
	res := make([]MarkingPrototype, 0)

	for _, v := range accessories {
		marking, err := v.toMarking()
		if err != nil {
			return nil, err
		}

		res = append(res, *marking)
	}

	return res, nil
}
