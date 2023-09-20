using System;

namespace MyCSharpApp.Desktop.Components
{
    public class People
    {
        private string name;
        private int age;
        private DateTime birthdate;

        public string Name
        { 
            get => this.name;
            set
            {
                this.name = value;
                this.OnPropChanged(this, new PeoplePropChangedEventArgs("Name", value, value.GetType()));
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                this.age = value;
                this.OnPropChanged(this, new PeoplePropChangedEventArgs("Age", value, value.GetType()));
            }
        }

        public DateTime Birthdate
        {
            get => this.birthdate;
            set
            {
                this.birthdate = value;
                this.OnPropChanged(this, new PeoplePropChangedEventArgs("Birthdate", value, value.GetType()));
            }
        }

        public People(string Name, int Age, DateTime Birthdate)
        {
            this.Name = Name;
            this.Age = Age;
            this.Birthdate = Birthdate;
        }

        public event PeoplePropChangedEventHandler PropChanged;
        //{
        //    add
        //    {
        //        PropChanged += value;
        //    }

        //    remove
        //    {
        //        PropChanged -= value;
        //    }
        //}

        protected virtual void OnPropChanged(object sender, PeoplePropChangedEventArgs e)
        {
            PropChanged?.Invoke(sender, e);
        }
    }

    public delegate void PeoplePropChangedEventHandler(object sender, PeoplePropChangedEventArgs e);
}
