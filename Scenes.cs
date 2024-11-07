using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

using static StorybrewCommon.Presets;

namespace StorybrewScripts
{
    public class Scenes : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var scenes = GetLayer("Scenes");

            var logo = scenes.CreateSprite("sb/logo.jpg", OsbOrigin.Centre);
            var telescope = scenes.CreateSprite("sb/bg/telescope.jpg", OsbOrigin.Centre);
            var timemachine1 = scenes.CreateSprite("sb/bg/timemachine1.jpg", OsbOrigin.Centre);
            var timemachine2 = scenes.CreateSprite("sb/bg/timemachine2.jpg", OsbOrigin.Centre);
            var tenbridge = scenes.CreateSprite("sb/bg/tenbridge.jpg", OsbOrigin.Centre);

            var appletree1 = scenes.CreateSprite("sb/bg/appletree.jpg", OsbOrigin.Centre);
            var appletree2 = scenes.CreateSprite("sb/bg/burntappletree.jpg", OsbOrigin.Centre);
            var alice1 = scenes.CreateSprite("sb/cg/alice1.jpg", OsbOrigin.Centre);

            var yotsuko1 = scenes.CreateSprite("sb/cg/yotsuko1.jpg", OsbOrigin.Centre);
            var yotsuko2 = scenes.CreateSprite("sb/cg/yotsuko2.jpg", OsbOrigin.Centre);
            var lavi1 = scenes.CreateSprite("sb/cg/lavi1.jpg", OsbOrigin.Centre);
            var lavi2 = scenes.CreateSprite("sb/cg/lavi2.jpg", OsbOrigin.Centre);

            var lavilab = scenes.CreateSprite("sb/bg/laviboratory.jpg", OsbOrigin.Centre);
            var research = scenes.CreateSprite("sb/bg/research.jpg", OsbOrigin.Centre);

            var prechorus6 = scenes.CreateSprite("sb/cg/prechorus6.jpg", OsbOrigin.Centre);
            var prechorus1 = scenes.CreateSprite("sb/cg/prechorus1.jpg", OsbOrigin.Centre);
            var prechorus2 = scenes.CreateSprite("sb/cg/prechorus2.jpg", OsbOrigin.Centre);
            var prechorus3 = scenes.CreateSprite("sb/cg/prechorus3.jpg", OsbOrigin.Centre);
            var prechorus4 = scenes.CreateSprite("sb/cg/prechorus4.jpg", OsbOrigin.Centre);
            var prechorus5 = scenes.CreateSprite("sb/cg/prechorus5.jpg", OsbOrigin.Centre);

            var yotsuko3 = scenes.CreateSprite("sb/cg/yotsuko3.jpg", OsbOrigin.Centre);
            var yotsuko4 = scenes.CreateSprite("sb/cg/yotsuko4.jpg", OsbOrigin.Centre);
            var lavi3 = scenes.CreateSprite("sb/cg/lavi3.jpg", OsbOrigin.Centre);
            var lavi4 = scenes.CreateSprite("sb/cg/lavi4.jpg", OsbOrigin.Centre);

            var balcony = scenes.CreateSprite("sb/bg/balcony.jpg", OsbOrigin.Centre);
            var dorm = scenes.CreateSprite("sb/bg/dorm.jpg", OsbOrigin.Centre);

            var haru1 = scenes.CreateSprite("sb/cg/haru1.jpg", OsbOrigin.Centre);
            var haru2 = scenes.CreateSprite("sb/cg/haru2.jpg", OsbOrigin.Centre);
            var emmy1 = scenes.CreateSprite("sb/cg/emmy1.jpg", OsbOrigin.Centre);
            var emmy2 = scenes.CreateSprite("sb/cg/emmy2.jpg", OsbOrigin.Centre);

            var port = scenes.CreateSprite("sb/bg/port.jpg", OsbOrigin.Centre);
            var dorm2 = scenes.CreateSprite("sb/bg/dorm2.jpg", OsbOrigin.Centre);

            var prechorus7 = scenes.CreateSprite("sb/cg/prechorus7.jpg", OsbOrigin.Centre);
            var prechorus8 = scenes.CreateSprite("sb/cg/prechorus8.jpg", OsbOrigin.Centre);
            var prechorus9 = scenes.CreateSprite("sb/cg/prechorus9.jpg", OsbOrigin.Centre);
            var prechorus10 = scenes.CreateSprite("sb/cg/prechorus10.jpg", OsbOrigin.Centre);
            var prechorus11 = scenes.CreateSprite("sb/cg/prechorus11.jpg", OsbOrigin.Centre);
            var prechorus12 = scenes.CreateSprite("sb/cg/prechorus12.jpg", OsbOrigin.Centre);

            var haru3 = scenes.CreateSprite("sb/cg/haru3.jpg", OsbOrigin.Centre);
            var haru4 = scenes.CreateSprite("sb/cg/haru4.jpg", OsbOrigin.Centre);
            var emmy3 = scenes.CreateSprite("sb/cg/emmy3.jpg", OsbOrigin.Centre);
            var emmy4 = scenes.CreateSprite("sb/cg/emmy4.jpg", OsbOrigin.Centre);

            var all = scenes.CreateSprite("sb/cg/all.jpg", OsbOrigin.Centre);
            var alice6 = scenes.CreateSprite("sb/cg/alice6.jpg", OsbOrigin.Centre);
            var alice7 = scenes.CreateSprite("sb/cg/alice7.jpg", OsbOrigin.Centre);
            var alice8 = scenes.CreateSprite("sb/cg/alice8.jpg", OsbOrigin.Centre);

            var alice2 = scenes.CreateSprite("sb/cg/alice2.jpg", OsbOrigin.Centre);
            var alice3 = scenes.CreateSprite("sb/cg/alice3.jpg", OsbOrigin.Centre);
            var alice4 = scenes.CreateSprite("sb/cg/alice4.jpg", OsbOrigin.Centre);
            var alice5 = scenes.CreateSprite("sb/cg/alice5.jpg", OsbOrigin.Centre);

            var shed = scenes.CreateSprite("sb/bg/shed.jpg", OsbOrigin.Centre);
            var library = scenes.CreateSprite("sb/bg/library.jpg", OsbOrigin.Centre);

            var newton = scenes.CreateSprite("sb/cg/newton.jpg", OsbOrigin.Centre);

            //epic stuff
            LogoSlide(logo, 2164, 8163);
            SlideRL2(shed, telescope, 8163, 11763, 11763, 15663);

            SlideScale2(timemachine1, timemachine2, 15663, 21663, 21663, 22864);
            SlideDU(tenbridge, 22864, 37263);

            SlideLR2(appletree1, appletree2, 37263, 40863, 40863, 44313);
            SlideSU(alice1, 44313, 51664);

            SlideRLInsta(yotsuko1, yotsuko2, 51664, 54964, 54964, 58863);
            SlideLR2(lavi1, lavi2, 58863, 62164, 62164, 65763);

            SlideRLInsta(lavilab, research, 66064, 72363, 72363, 76564);

            Slide(prechorus6, 76564, 76863);
            Slide(prechorus1, 76863, 77164);
            Slide(prechorus2, 77164, 77463);
            Slide(prechorus3, 77463, 77763);
            Slide(prechorus4, 77763, 78064);
            Slide(prechorus5, 78064, 78363);

            SlideRLInsta(yotsuko3, yotsuko4, 80463, 92763, 92763, 94863);
            SlideLRInsta(lavi3, lavi4, 94863, 101763, 101763, 108963);

            SlideLRInsta(balcony, dorm, 109263, 114963, 114963, 123664);

            SlideRLInsta(haru1, haru2, 123664, 126963, 126963, 130863);
            SlideLR2(emmy1, emmy2, 130863, 134164, 134164, 137764);

            SlideLRInsta(port, dorm2, 138063, 144363, 144363, 148563);

            Slide(prechorus7, 148563, 148863);
            Slide(prechorus8, 148863, 149164);
            Slide(prechorus9, 149164, 149464);
            Slide(prechorus10, 149464, 149764);
            Slide(prechorus11, 149764, 150063);
            Slide(prechorus12, 150063, 150363);

            SlideRLInsta(haru3, haru4, 152464, 159363, 159363, 166863);
            SlideLRInsta(emmy3, emmy4, 166863, 174664, 174664, 180964);

            SlideLR2(all, alice6, 181264, 188164, 188164, 195363);
            SlideRL2(alice7, alice8, 195363, 202563, 202563, 213363);

            SlideLRInsta(alice2, alice3, 213664, 224164, 224164, 227764);
            SlideRLInsta(alice4, alice5, 228063, 234964, 234964, 242164);

            SlideLRInsta(shed, library, 242164, 245764, 245764, 249363);
            SlideSU(newton, 249363, 260326);
        }
    }
}
