using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RogueLiteProject.Objects
{
    class Player
    {
        public Vector2 Position;
        public Texture2D Texture;
        public Color Color;
        public float Speed;

        public Player(Texture2D texture)
        {
            Position = Vector2.Zero;
            Texture = texture;
            Color = Color.White;
            Speed = 150;
        }

        public Player(Vector2 position, Texture2D texture, Color color, float speed)
        {
            Position = position;
            Texture = texture;
            Color = color;
            Speed = speed;
        }
    }
}
