using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Platformer2D;

namespace ShardLands.Game
{
    class Hitbox
    {
        Vector2 hitLocation;
        bool hit;

        public Hitbox(Player player)
        {
            hitLocation = player.Position;
            hit = false;
        }
        
        void runHit()
        {
            
        }

        void checkHit(Enemy enemy)
        {
            if (hitLocation.X == enemy.Position.X)
            {
                hit = true;
                
            }
        }
    }
}
