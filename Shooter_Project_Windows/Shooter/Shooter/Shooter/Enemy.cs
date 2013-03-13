﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Enemy
    {
        // Animation representing the enemy
        public Animation EnemyAnimation;

        // The position of the enemy ship relative to the top left corner of the screen
        public Vector2 Position;

        // The state of the Enemy Ship
        public bool Active;

        // The hit points of teh enemy, if this goes to zero the enemy dies
        public int Health;

        // The amount of damage the enemy inflicts on teh player ship
        public int Damage;

        // The amount of score the enemy will give to the player
        public int Value;

        // Get the width of the enemy ship
        public int Width
        {
            get { return EnemyAnimation.FrameWidth; }
        }

        // Get teh height of teh enemy ship
        public int Height
        {
            get { return EnemyAnimation.FrameHeight; } 
        }

        float enemyMoveSpeed;

        public void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            EnemyAnimation = animation;

            // Set the position of the enemy
            Position = position;

            // We initialize the enemy to be active so it will be update in the game
            Active = true;


            // Set the health of the enemy
            Health = 10;

            // Set the amount of damage the enemy can do
            Damage = 10;

            // Set how fast the enemy moves
            enemyMoveSpeed = 6f;


            // Set the score value of the enemy
            Value = 100;
        }

        public void Update()
        {
        }

        public void Draw()
        {
        }
    }
}
