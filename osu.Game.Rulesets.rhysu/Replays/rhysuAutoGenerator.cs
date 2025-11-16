// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.rhysu.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.rhysu.Replays
{
	public class rhysuAutoGenerator : AutoGenerator<rhysuReplayFrame>
	{
		public new Beatmap<rhysuHitObject> Beatmap => (Beatmap<rhysuHitObject>)base.Beatmap;

		public rhysuAutoGenerator(IBeatmap beatmap)
			: base(beatmap) { }

		protected override void GenerateFrames()
		{
			Frames.Add(new rhysuReplayFrame());

			foreach (rhysuHitObject hitObject in Beatmap.HitObjects)
			{
				Frames.Add(new rhysuReplayFrame
				{
					Time = hitObject.StartTime,
					Position = hitObject.Position,
					// todo: add required inputs and extra frames.
				});
			}
		}
	}
}