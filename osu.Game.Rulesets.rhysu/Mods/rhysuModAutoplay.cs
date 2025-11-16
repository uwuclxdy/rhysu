// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.rhysu.Replays;

namespace osu.Game.Rulesets.rhysu.Mods
{
	public class rhysuModAutoplay : ModAutoplay
	{
		public override ModReplayData CreateReplayData(IBeatmap beatmap, IReadOnlyList<Mod> mods)
			=> new ModReplayData(new rhysuAutoGenerator(beatmap).Generate(),
				new ModCreatedUser { Username = "sample" });
	}
}