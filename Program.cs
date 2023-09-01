using Raylib_cs;
using BashMonster;

Raylib.InitWindow(1280, 720, "Bash-A-Monster");
Raylib.SetTargetFPS(60);

Player player = new Player();
Enemy enemy = new Enemy();
