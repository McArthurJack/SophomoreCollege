using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge3
{
    class Student
    {

        public event EventHandler SleepsIn;

        private string name, major;
        private float grade;
        private bool hangry;
        private int sid, sadness, energy;

        public Student(string name, string major, float grade, bool hangry, int sid, int sadness, int energy)
        {
            this.name = name;
            this.major = major;
            this.grade = grade;
            this.hangry = hangry;
            this.sid = sid;
            this.sadness = sadness;
            this.energy = energy;
            this.SleepsIn += OnSleepIn;
            SleepIn();
        }

        public void OnTest(object sender, EventArgs e)
        {
            Console.WriteLine($"{name} starts to panic!");
        }

        public void SleepIn()
        {
            SleepsIn.Invoke(this, EventArgs.Empty);
        }

        public void OnSleepIn(object sender, EventArgs e)
        {
            Console.WriteLine($"{name} has slept in.");
        }

        public string Name { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public float Grade { get => grade; set => grade = value; }
        public bool Hangry { get => hangry; set => hangry = value; }
        public int Sid { get => sid; set => sid = value; }
        public int Sadness { get => sadness; set => sadness = value; }
        public int Energy { get => energy; set => energy = value; }
    }
}
