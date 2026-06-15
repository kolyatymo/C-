using System;
using System.Formats.Asn1;


namespace _06_intro_class
{
    // public - відкритий для інших збірок 
    // internal - закритий для інших збірок (видимий лише для цієї збірки)
    public class Character // успадковується від супертипу - Object
    {
        // private - закритий доступ до полів, доступ лише в межах класу
        // public - відкритий доступ
        // protected - відкритий лише для цього класу і класах наслідниках
        // internal - дані доступні тільки в методах поточної збірки
        // protected internal
        private string name = "Unknown";
        private uint hp = 100; // hp_

        public Character(string name, uint hp, uint damage)
        {
            Name = name;
            this.hp = hp;
            Damage = damage;
            /* hp_ = hp;*/ // краще через this
        }
        public Character(string name) : this(name, 100, 1) // каскадний викликається к-р цьогож класу
        {
            
        }
        public Character() {  }
        public override string ToString()
        {
            return $"Name : {name, -10} HP : {hp,-10} Damage : {Damage, -10}";
        }

        public void Print()
        {
            Console.WriteLine($"Character name   --> {name}");
            Console.WriteLine($"Character hp     --> {hp}");
            Console.WriteLine($"Character damage --> {Damage}");
        }

        public uint Damage { get; set; } // авто-властивість, компілятор створить поле типу unit та для нього get, set

        public string Name // props
        {
            get
            {
                return name;
            }
            set // value - ключове слово для set = значення яке хочемо встановити
            {
                /*if(value.Length != 0) 
                    name = value;*/
                if(!String.IsNullOrWhiteSpace(value))
                    name = value; 
            }
        }

        /*public uint KPD { get { return Damage * hp;  } }*/
        public uint KPD { get => Damage * hp; } // property - тільки для читання
    }
}   