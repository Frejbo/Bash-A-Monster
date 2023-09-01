namespace BashMonster;
using System.Numerics;
using Raylib_cs;


class Player {
    Vector2 pos = new Vector2(Raylib.GetScreenWidth()/2, Raylib.GetScreenHeight()/2);
    Vector2 width = new Vector2(50, 50);
    int movementSpeed = 3;
    public Player() {
        MainLoop();
    }

    void MainLoop() {
        while (!Raylib.WindowShouldClose()) {
            pos += InputVector() * movementSpeed;
            Draw();
        }
    }

    Vector2 InputVector() {
        Vector2 inputAxis = new Vector2(0, 0);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
            inputAxis.Y--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
            inputAxis.Y++;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) {
            inputAxis.X--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) {
            inputAxis.X++;
        }
        inputAxis = Vector2.Normalize(inputAxis);
        return (inputAxis);
    }
    void Draw() {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawRectangle((int)pos.X - (int)width.X/2, (int)pos.Y - (int)width.Y/2, (int)width.X, (int)width.Y, Color.WHITE);
        Raylib.EndDrawing();
    }

    // public void hej() {
    //     System.Console.WriteLine("HAHA");
    // }

}