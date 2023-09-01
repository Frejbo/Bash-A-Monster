using System.Numerics;
using Raylib_cs;

namespace BashMonster;
public class Enemy
{
    public int speed; // sätter denna i Program.cs för jag är lat och orkar inte komma på nåt bättre att ändra just nu
    Vector2 pos = new Vector2(0, 0);
    Vector2 width = new Vector2(50, 50);

    public Enemy() { // Konstruktor
        
    }

    public void UpdatePos() {

    }

    public void Draw() {
        Raylib.DrawRectangle((int)pos.X, (int)pos.Y, (int)width.X, (int)width.Y, Color.RED);
    }
}
