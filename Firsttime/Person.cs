using System;

namespace Firsttime
{
    abstract class Person
    {
        // Richtige Datentypen 
        //Double ... Kommazahlen
        //Integer... Ganzzahlen
        //String... Zeichenketten
        //bool ... true or false
        //char ... für einzlne Zeicen
        private decimal _Basesalary;
        private DateTime _Birthdate;

        //Property entspricht dem getter/setter
        public string Firstname {get;set;}
        public Gender Gender {get;set;}
        //ctors = konstructoren
        public Person() {}
        public Person(string Firstname,string Lastname,DateTime Birthdate,decimal Basesalary) {
            this.Birthdate=Birthdate;
            this.Firstname=Firstname;
            this.Lastname=Lastname;
            this.Basesalary=Basesalary;
        }

        //normales property

        public decimal Basesalary {
            get {return this._Basesalary;}
            set {
                if (value>=0.0m)
                {
                    this._Basesalary=value;
                }
            }
        }
        public string Lastname {get;set;}
        public DateTime Birthdate{
            get{return this._Birthdate;}
            set {
                if ((value<=DateTime.Now)&&(value.AddYears(120)>=DateTime.Now.AddYears(120)))
                {
                    this._Birthdate=value;
                }
                else
                {
                //     throw new ArgumentOutOfRangeException("Birthdate is not valid");
                }
            }
        }
        public override String ToString(){

            return this.Firstname+" "+this.Lastname;
        }
        abstract public decimal Calculatesalary();

        
    }
    enum Gender
    {
        male,female,notspecified
    }
    
}