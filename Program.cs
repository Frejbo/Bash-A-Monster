using Raylib_cs;
using BashMonster;

Raylib.InitWindow(1280, 720, "Bash-A-Monster");
Raylib.SetTargetFPS(60);

Player player = new Player();
Enemy enemy = new Enemy();
enemy.speed = 3; // läs Enemy.cs


while (!Raylib.WindowShouldClose()) {
    player.UpdatePos(); // Är detta verkligen bästa sättet? Känns väldigt dumt.
    // enemy.MainLoop();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    player.Draw();
    enemy.Draw();

    Raylib.EndDrawing();
}