// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        float angle = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            //{
            //    angle += 1;
            //}
            angle = Time.SecondsElapsed * MathF.Tau / 5;

            // Screen centre
            Vector2 centre = Window.Size / 2;
            // Calculate point on circle, then draw something there
            Vector2 offset = new Vector2(
                MathF.Cos(angle) * 150,  // X
                MathF.Sin(angle) *  50); // Y
            Vector2 position = centre + offset;

            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Circle(centre, 3);
            Draw.FillColor = Color.Green;
            Draw.Circle(position, 25);

            Text.Draw($"Angle: {angle}", 10, 10);
        }
    }

}
