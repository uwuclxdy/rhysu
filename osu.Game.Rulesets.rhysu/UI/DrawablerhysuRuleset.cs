// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.rhysu.Objects;
using osu.Game.Rulesets.rhysu.Objects.Drawables;
using osu.Game.Rulesets.rhysu.Replays;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.rhysu.UI
{
	[Cached]
	public partial class DrawablerhysuRuleset : DrawableRuleset<rhysuHitObject>
	{
		public DrawablerhysuRuleset(rhysuRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
			: base(ruleset, beatmap, mods) { }

		protected override Playfield CreatePlayfield() => new rhysuPlayfield();

		protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) =>
			new rhysuFramedReplayInputHandler(replay);

		public override DrawableHitObject<rhysuHitObject> CreateDrawableRepresentation(rhysuHitObject h) =>
			new DrawablerhysuHitObject(h);

		protected override PassThroughInputManager CreateInputManager() =>
			new rhysuInputManager(Ruleset?.RulesetInfo);
	}
}