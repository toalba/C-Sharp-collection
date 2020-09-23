using System;

namespace Firsttime
{

    //es wird alles vererbt außer ctos
    class Employe : Person
    {
        private int _overtime;
        private decimal _overtimesalary;
        public int overtime {
            get {return this._overtime;}
            set {
                if (value>=0)
                {
                    this._overtime=value;
                }
            }
        }
        public decimal overtimesalary {
        get {return this._overtimesalary;}
        set {
            if (value>=0.0m)
            {
                this._overtimesalary=value;
            }
            }
        }
        public Employe() {}
        public Employe(string Firstname,string Lastname,DateTime Birthdate,decimal Basesalary,int overtime,decimal overtimesalary) :base(Firstname,Lastname,Birthdate,Basesalary) {
            this.overtime=overtime;
            this.overtimesalary=overtimesalary;
        }
        public override decimal Calculatesalary()
        {
            throw new NotImplementedException();
        }
        public override String ToString()
        {
            return base.ToString() + " "+Environment.NewLine+" "+this.overtime+" "+this.overtimesalary;
        }
        
        
    }
}