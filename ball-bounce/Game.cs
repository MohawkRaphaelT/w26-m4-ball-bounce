// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    Ball[] balls = new Ball[100];
    int count = 0;

    public void Setup()
    {
        Window.SetTitle("Ball Bounce");
        Window.SetSize(400, 800);
        Window.TargetFPS = 60;

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball();
        }
    }

    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        if (Input.IsKeyboardKeyPressed(KeyboardInput.A))
        {
            count++;
            if (count > 100)
                count = 100;
        }

        for (int i = 0; i < count; i++)
        {
            // Pull one item out of array
            Ball ball = balls[i];
            ball.TryAddRandomForceToBall();
            ball.MoveBall();
            ball.DrawBall();
        }

        Text.Draw($"Count: {count}", 10, 10);
    }
}
