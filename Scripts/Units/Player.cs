using Godot;
using System;
using System.Collections.Generic;

namespace Scripts.Units
{
    public partial class Player : Unit
    {
        public override void _PhysicsProcess(double delta)
        {
            Vector2 direction = Input.GetVector("MoveLeft", "MoveRight", "MoveUp", "MoveDown");
            Velocity = direction * 100;
            MoveAndSlide();
        }
    }
    
}
