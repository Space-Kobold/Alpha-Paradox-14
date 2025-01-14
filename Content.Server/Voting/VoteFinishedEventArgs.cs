// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections.Immutable;


namespace Content.Server.Voting
{
    public sealed class VoteFinishedEventArgs : EventArgs
    {
        /// <summary>
        ///     Null if stalemate.
        /// </summary>
        public readonly object? Winner;

        /// <summary>
        ///     Winners. More than one if there was a stalemate.
        /// </summary>
        public readonly ImmutableArray<object> Winners;

        /// <summary>
        ///     Stores all the votes in a string, for webhooks. 
        /// </summary>
        public readonly List<int> Votes;

        public VoteFinishedEventArgs(object? winner, ImmutableArray<object> winners, List<int> votes)
        {
            Winner = winner;
            Winners = winners;
            Votes = votes;
        }
    }
}
