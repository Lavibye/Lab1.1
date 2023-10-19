using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Tree
    {
        private string name;
        private double height;
        private int age;

        public Tree(string name, double height, int age)
        {
            Name = name;
            Height = height;
            Age = age;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Назва дерева не може бути пустою.");
                name = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Висота дерева має бути більше 0.");
                height = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Вік дерева має бути більше 0.");
                age = value;
            }
        }

        public double AverageGrowthPerYear()
        {
            return height / age;
        }
    }
}
