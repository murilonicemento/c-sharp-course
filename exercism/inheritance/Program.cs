using System;

abstract class Character
{
  protected string character;

  protected Character(string characterType)
  {
    this.character = characterType;
  }

  public abstract int DamagePoints(Character target);

  public virtual bool Vulnerable() => false;

  public override string ToString() => $"Character is a {this.character}";
}

class Warrior : Character
{
  public Warrior() : base("Warrior")
  {
  }

  public override string ToString() => $"Character is a {base.character}";

  public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
  private bool spellIsPrepared = false;

  public Wizard() : base("Wizard")
  {
  }

  public void PrepareSpell()
  {
    this.spellIsPrepared = true;
  }

  public override bool Vulnerable() => !spellIsPrepared;

  public override int DamagePoints(Character target) => this.spellIsPrepared ? 12 : 3;


}
