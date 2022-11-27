using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
  public abstract class Animal
  {
    float weight;
    string color;

    public float Weight { get { return weight; } set { weight = value; } }
    public string Color { get { return color; } set { color = value; } }

    public Animal(float weight, string color)
    {
      this.weight = Weight;
      this.color = Color;
    }
    public abstract string MakeSound();
  }
  public abstract class AnimalWithTail : Animal
  {
    float tailLength;
    public float TailLength { get { return tailLength; } set { tailLength = value; } }
    public AnimalWithTail(float weight, string color, float tailleight) : base(weight, color)
    {
      this.Weight = weight;
      this.Color = color;
      this.TailLength = tailleight;
    }
    public class Cat : AnimalWithTail
    {
      public Cat(float weight, string color, float tailleight) : base(weight, color, tailleight)
      {
        this.Weight = weight;
        this.Color = color;
        this.TailLength = tailleight;
      }

      private string Purr()
      {
        return "purrrrrrrr ";
      }

      private string Meow()
      {
        return "Meow";
      }
      public override string MakeSound()
      {
        return Purr() + Meow();
      }
      public override string ToString()
      {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
      }
    }

    public class Dog : AnimalWithTail
    {
      public Dog(float weight, string color, float tailleight) : base(weight, color, tailleight)
      {
        this.Weight = weight;
        this.Color = color;
        this.TailLength = tailleight;
      }

      public override string MakeSound()
      {
        return "Woof";
      }

      public override string ToString()
      {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
      }
    }
  }
}

