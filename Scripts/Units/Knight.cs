using Godot;
using System;

namespace Scripts.Units
{
    public partial class Knight : Player
    {
        public AnimatedSprite2D KnightAnimation;
        public override void _Ready()
        {
            KnightAnimation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        }

        public override void _PhysicsProcess(double delta)
        {
            base._PhysicsProcess(delta);

            if (Velocity.Length() > 0)
            {
                KnightAnimation.Play("Run");
                if (Velocity.X < 0)
                {
                    KnightAnimation.FlipH = true;
                }
                else if (Velocity.X > 0)
                {
                    KnightAnimation.FlipH = false;
                }
            }
            else
            {
                KnightAnimation.Play("Idle");
            }
        }
    }
}