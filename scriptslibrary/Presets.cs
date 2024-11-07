using StorybrewCommon.Storyboarding;

namespace StorybrewCommon
{
    public class Presets
    {
        public static double BEAT_DURATION = 301;
        public static double SCALE = 480.0 / 1080;

        public static void Slide(OsbSprite Sprite, double StartTime, double EndTime)
        {
            Sprite.Scale(StartTime, SCALE);
            Sprite.Fade(StartTime, 1);
            Sprite.Fade(EndTime, 0);
        }

        public static void LogoSlide(OsbSprite Sprite, double StartTime, double EndTime)
        {
            Sprite.Scale(StartTime, SCALE);
            Sprite.Fade(StartTime - BEAT_DURATION, StartTime, 0, 1);
            Sprite.Fade(EndTime, EndTime + BEAT_DURATION, 1, 0);
        }

        public static void SlideScale2(OsbSprite Sprite1, OsbSprite Sprite2, double StartTime1, double EndTime1, double StartTime2, double EndTime2)
        {
            Sprite1.Scale(StartTime1, EndTime2, SCALE, SCALE * 1.02);
            Sprite2.Scale(StartTime1, EndTime2, SCALE, SCALE * 1.02);

            Sprite1.Fade(StartTime1 - BEAT_DURATION, StartTime1, 0, 1);
            Sprite1.Fade(EndTime1, EndTime1 + BEAT_DURATION, 1, 0);
            Sprite2.Fade(StartTime2 - BEAT_DURATION, StartTime2, 0, 1);
            Sprite2.Fade(EndTime2, EndTime2 + BEAT_DURATION, 1, 0);
        }

        public static void SlideSU(OsbSprite Sprite, double StartTime, double EndTime)
        {
            Sprite.Scale(StartTime - BEAT_DURATION, EndTime + BEAT_DURATION, SCALE * 1.05, SCALE * 1.1);

            Sprite.Fade(StartTime - BEAT_DURATION, StartTime, 0, 1);
            Sprite.Fade(EndTime, EndTime + BEAT_DURATION, 1, 0);

            Sprite.Rotate(OsbEasing.OutSine, StartTime - BEAT_DURATION, EndTime + BEAT_DURATION, 0.015, -0.015);
        }

        public static void SlideRL2(OsbSprite Sprite1, OsbSprite Sprite2, double StartTime1, double EndTime1, double StartTime2, double EndTime2)
        {
            Sprite1.Scale(StartTime1, SCALE * 1.1);
            Sprite2.Scale(StartTime2, SCALE * 1.1);

            Sprite1.Fade(StartTime1 - BEAT_DURATION, StartTime1, 0, 1);
            Sprite1.Fade(EndTime1, EndTime1 + BEAT_DURATION, 1, 0);
            Sprite2.Fade(StartTime2 - BEAT_DURATION, StartTime2, 0, 1);
            Sprite2.Fade(EndTime2, EndTime2 + BEAT_DURATION, 1, 0);

            Sprite1.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 330, 310);
            Sprite2.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 330, 310);
        }

        public static void SlideLR2(OsbSprite Sprite1, OsbSprite Sprite2, double StartTime1, double EndTime1, double StartTime2, double EndTime2)
        {
            Sprite1.Scale(StartTime1, SCALE * 1.1);
            Sprite2.Scale(StartTime2, SCALE * 1.1);

            Sprite1.Fade(StartTime1 - BEAT_DURATION, StartTime1, 0, 1);
            Sprite1.Fade(EndTime1, EndTime1 + BEAT_DURATION, 1, 0);
            Sprite2.Fade(StartTime2 - BEAT_DURATION, StartTime2, 0, 1);
            Sprite2.Fade(EndTime2, EndTime2 + BEAT_DURATION, 1, 0);

            Sprite1.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 310, 330);
            Sprite2.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 310, 330);
        }

        public static void SlideRLInsta(OsbSprite Sprite1, OsbSprite Sprite2, double StartTime1, double EndTime1, double StartTime2, double EndTime2)
        {
            Sprite1.Scale(StartTime1, SCALE * 1.1);
            Sprite2.Scale(StartTime2, SCALE * 1.1);

            Sprite1.Fade(StartTime1, 1);
            Sprite1.Fade(EndTime1, EndTime1 + BEAT_DURATION, 1, 0);
            Sprite2.Fade(StartTime2 - BEAT_DURATION, StartTime2, 0, 1);
            Sprite2.Fade(EndTime2, EndTime2 + BEAT_DURATION, 1, 0);

            Sprite1.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 330, 310);
            Sprite2.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 330, 310);
        }

        public static void SlideLRInsta(OsbSprite Sprite1, OsbSprite Sprite2, double StartTime1, double EndTime1, double StartTime2, double EndTime2)
        {
            Sprite1.Scale(StartTime1, SCALE * 1.1);
            Sprite2.Scale(StartTime2, SCALE * 1.1);

            Sprite1.Fade(StartTime1, 1);
            Sprite1.Fade(EndTime1, EndTime1 + BEAT_DURATION, 1, 0);
            Sprite2.Fade(StartTime2 - BEAT_DURATION, StartTime2, 0, 1);
            Sprite2.Fade(EndTime2, EndTime2 + BEAT_DURATION, 1, 0);

            Sprite1.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 310, 330);
            Sprite2.MoveX(StartTime1 - BEAT_DURATION, EndTime2 + BEAT_DURATION, 310, 330);
        }

        public static void SlideDU(OsbSprite Sprite, double StartTime, double EndTime)
        {
            Sprite.Scale(StartTime, SCALE);
            Sprite.Fade(StartTime - BEAT_DURATION, 1);
            Sprite.Fade(EndTime, EndTime + BEAT_DURATION, 1, 0);
            Sprite.MoveY(OsbEasing.Out, StartTime - BEAT_DURATION, EndTime + BEAT_DURATION, 150, 350);
        }
    }
}