using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace StorybrewScripts
{
    public class Lyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public string FontName = "assetlibrary/NotoSansMonoCJKjp-VF.otf";

        [Configurable]
        public int FontSize = 30;

        [Configurable]
        public float FontScale = 0.5f;

        [Configurable]
        public Color4 GlowColor = Color4.Black;

        [Configurable]
        public Color4 OutlineColor = Color4.AliceBlue;

        [Configurable]
        public float SubtitleY = 400f;

        public override void Generate()
        {
            var font = LoadFont("sb/lyrics", new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = Color4.AliceBlue,
                FontStyle = FontStyle.Bold,
                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false,
            },

            new FontGlow()
            {
                Radius = 5,
                Color = GlowColor,
            },

            new FontOutline()
            {
                Thickness = 1,
                Color = OutlineColor,
            });

            var main = LoadSubtitles("subtitles/lyrics.ass");

            GenerateLyrics(font, main, "Lyrics");
        }

        public void GenerateLyrics(FontGenerator font, SubtitleSet subtitles, string layerName)
        {
            var layer = GetLayer(layerName);
            var particleLayer = GetLayer(layerName + "_particles"); // Separate layer for particles
            _ = new Random();

            foreach (var subtitleLine in subtitles.Lines)
            {
                float letterY = SubtitleY;
                float whiteSpace = 3f;

                // Process each line of the subtitle
                foreach (var line in subtitleLine.Text.Split('\n'))
                {
                    var lineWidth = 0f;
                    var lineHeight = 0f;
                    var textures = new List<OsbSprite>();

                    // Calculate the total line width and max line height
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());
                        lineWidth += texture.BaseWidth * FontScale + whiteSpace;
                        lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
                    }

                    // Calculate the starting X position to center the line
                    var letterX = 320 - lineWidth * 0.5f;
                    var relativeTime = subtitleLine.StartTime;

                    // Create sprites for each letter but store their positions
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());

                        if (!texture.IsEmpty)
                        {
                            var position = new Vector2(letterX, letterY)
                                + texture.OffsetFor(OsbOrigin.Centre) * FontScale;

                            var sprite = layer.CreateSprite(texture.Path, OsbOrigin.Centre, position);
                            sprite.Scale(relativeTime, FontScale);
                            textures.Add(sprite);  // Store the sprites in a list
                        }

                        letterX += texture.BaseWidth * FontScale + whiteSpace;
                    }

                    // Animate the entire line as a whole (apply to all sprites at once)
                    foreach (var sprite in textures)
                    {
                        // Fade in the entire line together
                        sprite.Fade(relativeTime - 300, relativeTime + 400, 0, 1);  // Fade-in effect

                        // Move and scale the entire line, and fade out
                        sprite.Move(subtitleLine.EndTime, subtitleLine.EndTime + 220, sprite.PositionAt(subtitleLine.StartTime), Vector2.Add(sprite.PositionAt(subtitleLine.StartTime), new Vector2(Random(-5, 5), Random(-20, 20))));
                        sprite.Scale(subtitleLine.EndTime, subtitleLine.EndTime + 220, FontScale, 0);
                        sprite.Fade(subtitleLine.EndTime, subtitleLine.EndTime + 500, 1, 0);  // Fade-out effect

                        // Create particles around the lyrics
                        CreateParticles(particleLayer, subtitleLine, sprite.PositionAt(subtitleLine.StartTime), relativeTime, subtitleLine.EndTime);
                    }

                    // Move to the next line of subtitles
                    letterY += lineHeight;
                }
            }
        }

        // Method to create floating particles around a position
        public static void CreateParticles(StoryboardLayer particleLayer, SubtitleLine subtitleLine, Vector2 basePosition, double startTime, double endTime)
        {
            Random random = new();

            // Generate a random number of particles per line
            int particleCount = random.Next(2, 3);

            for (int i = 0; i < particleCount; i++)
            {
                // Randomize the position around the base position
                float randomOffsetX = (float)(random.NextDouble() * 100 - 50);  // Offset between -50 and 50 on the X-axis
                float randomOffsetY = (float)(random.NextDouble() * 50 - 25);   // Offset between -25 and 25 on the Y-axis
                var particlePosition = new Vector2(basePosition.X + randomOffsetX, basePosition.Y + randomOffsetY);

                // Create the particle sprite
                var particle = particleLayer.CreateSprite("sb/particle.png", OsbOrigin.Centre, particlePosition);

                // Randomize particle properties
                double particleStart = startTime;  // Particle start time with random delay
                double particleEnd = endTime;      // Particle end time with random delay
                float particleScale = (float)(random.NextDouble() * 1 + 0.1);  // Random scale between 0.1 and 0.3
                float randomMoveX = (float)(random.NextDouble() * 100 - 50);     // Random movement on X
                float randomMoveY = (float)(random.NextDouble() * 50 - 25);      // Random movement on Y

                // Animate particle
                particle.Scale(particleStart, particleScale);  // Set particle scale
                particle.Fade(particleStart - 300, particleStart + 400, 0, 0.4f);  // Fade in
                particle.Fade(particleEnd, particleEnd + 250, 0.4f, 0);  // Fade out
                particle.Move(particleStart - 300, particleEnd + 500, particlePosition, new Vector2(particlePosition.X + randomMoveX, particlePosition.Y + randomMoveY));  // Random float movement
            }
        }
    }
}