using Godot;
using System;
using System.Collections.Generic;

namespace Scripts.Units
{
    public partial class Unit : CharacterBody2D
    {
        public string UnitName { get; set; }
        public float Health { get; set; }
        public float Stamina { get; set; }
        public float Attack { get; set; }
        public float Defense { get; set; }
        public float Resistance { get; set; }
        public float Magic { get; set; }
        public float MovementSpeed { get; set; }
        public List<Ability> Abilities { get; set; }
        public UnitAllegiance Allegiance { get; set; }
    }

    public enum UnitAllegiance
    {
        Ally,
        Enemy
    }
}
