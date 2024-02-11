using System;
using System.Collections.Generic;
using Godot;

namespace Scripts.Units
{
    public class Ability
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float AffectedNumber { get; set; }
        public int SpacesAffected { get; set; }
        public TargetShape Shape { get; set; }
        public AffectedStat AffectedStat { get; set; }
        public UnitAllegiance AffectedAllegiance { get; set; }

        public void AffectUnits(List<Unit> units)
        {
            units.ForEach(unit => {
                if (unit.Allegiance.Equals(AffectedAllegiance))
                {
                    switch (AffectedStat)
                    {
                        case AffectedStat.Health:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Health += AffectedNumber;
                            }
                            else
                            {
                                unit.Health -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.Stamina:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Stamina += AffectedNumber;
                            }
                            else
                            {
                                unit.Stamina -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.Attack:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Attack += AffectedNumber;
                            }
                            else
                            {
                                unit.Attack -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.Defense:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Defense += AffectedNumber;
                            }
                            else
                            {
                                unit.Defense -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.Resistance:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Resistance += AffectedNumber;
                            }
                            else
                            {
                                unit.Resistance -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.Magic:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.Magic += AffectedNumber;
                            }
                            else
                            {
                                unit.Magic -= AffectedNumber;
                            }
                            break;
                        case AffectedStat.MovementSpeed:
                            if (unit.Allegiance == UnitAllegiance.Ally)
                            {
                                unit.MovementSpeed += AffectedNumber;
                            }
                            else
                            {
                                unit.MovementSpeed -= AffectedNumber;
                            }
                            break;
                    }
                }
            });
        }
    }

    public enum TargetShape
    {
        Self,
        Line,
        PlusSign,
        Cone,
        Blast,
    }

    public enum AffectedStat
    {
        Health,
        Stamina,
        Attack,
        Defense,
        Resistance,
        Magic,
        MovementSpeed
    }
}