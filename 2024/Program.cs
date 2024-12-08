using System.Diagnostics;
using System.Text.RegularExpressions;
using _2024;
using Spectre.Console;

//Day03.Run();
//Day04.Run();
//Day05.Run();
//Day06.Run();
//Day07.Run();
Day06.Run();

// Create a canvas
//var canvas = new Canvas(16, 16);
//canvas.PixelWidth = 2;

//// Render the canvas
//await AnsiConsole.Live(canvas)
//    .StartAsync(async ctx =>
//    {
//        for (var i = 0; i < canvas.Width; i++)
//        {
//            await Task.Delay(250);
//            // Cross
//            canvas.SetPixel(i, i, Color.White);
//            canvas.SetPixel(canvas.Width - i - 1, i, Color.White);

//            // Border
//            canvas.SetPixel(i, 0, Color.Red);
//            canvas.SetPixel(0, i, Color.Green);
//            canvas.SetPixel(i, canvas.Height - 1, Color.Blue);
//            canvas.SetPixel(canvas.Width - 1, i, Color.Yellow);

//            ctx.Refresh();
//        }
//    });
