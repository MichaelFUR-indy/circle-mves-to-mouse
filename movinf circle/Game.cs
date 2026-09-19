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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

    Window.SetTitle("moving circle test");
            Window.SetSize(400, 400);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // always make sure Color is capatlized
            Window.ClearBackground(Color.White);

            Draw.FillColor = Color.Green;
            Draw.LineSize = 2;
            Draw.LineColor = Color.Cyan;

            //x y radius(size), if space bar is down can see green circle
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {

                //when mouse left and space bar down at same time change color
                if (Input.IsMouseButtonDown(MouseButton.Left))
                {
                    Draw.FillColor = Color.Red;
                }

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);
            }

        }
    }

}
