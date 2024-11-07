using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

using static StorybrewCommon.Presets;

namespace StorybrewScripts
{
    public class Flash : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            FlashEffect(22563);
            FlashEffect(51363);
            FlashEffect(65763);

            SmallFlashEffect(76564);
            SmallFlashEffect(76863);
            SmallFlashEffect(77164);
            SmallFlashEffect(77463);
            SmallFlashEffect(77763);
            SmallFlashEffect(78064);
            SmallFlashEffect(78363);

            FlashEffect(80164);
            FlashEffect(94564);
            FlashEffect(108963);
            FlashEffect(137764);
            FlashEffect(123363);

            SmallFlashEffect(148563);
            SmallFlashEffect(148863);
            SmallFlashEffect(149164);
            SmallFlashEffect(149464);
            SmallFlashEffect(149764);
            SmallFlashEffect(150063);
            SmallFlashEffect(150363);

            FlashEffect(152164);
            FlashEffect(166563);

            FlashEffect(213363);
            FlashEffect(227764);

            FlashEffect(242164);
        }

        private void FlashEffect(double startTime)
        {
            var sprite = GetLayer("Flash").CreateSprite("sb/pixel.png", OsbOrigin.Centre);
            sprite.ScaleVec(startTime, 854, 480);
            sprite.Fade(OsbEasing.InExpo, startTime - BEAT_DURATION / 2, startTime, 0, 0.3);
            sprite.Fade(OsbEasing.Out, startTime, startTime + BEAT_DURATION * 2, 0.9, 0);
        }

        private void SmallFlashEffect(double startTime)
        {
            var sprite = GetLayer("Flash").CreateSprite("sb/pixel.png", OsbOrigin.Centre);
            sprite.ScaleVec(startTime, 854, 480);
            sprite.Fade(OsbEasing.Out, startTime, startTime + BEAT_DURATION / 2, 0.4, 0);
        }
    }
}