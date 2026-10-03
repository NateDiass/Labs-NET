using System;

namespace MusicInstrumentsApp
{
    public abstract class MusicalInstrument
    {
        protected string name;
        protected string characteristics;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Characteristics
        {
            get { return characteristics; }
            set { characteristics = value; }
        }


        protected MusicalInstrument()
        {
            name = "Невідомий інструмент";
            characteristics = "Відсутні характеристики";
        }

        protected MusicalInstrument(string name)
        {
            this.name = name;
            characteristics = "Стандартні характеристики";
        }


        protected MusicalInstrument(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }


        protected MusicalInstrument(MusicalInstrument other)
        {
            name = other.name;
            characteristics = other.characteristics;
        }


        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

        public virtual void ShowInfo()
        {
            Console.WriteLine("Назва: " + name);
            Console.WriteLine("Характеристики: " + characteristics);
        }
    }

    public class Violin : MusicalInstrument
    {
        private string woodType;

        public string WoodType
        {
            get { return woodType; }
            set { woodType = value; }
        }

        public Violin() : base() { woodType = "Клен/Ялина"; }
        public Violin(string name, string characteristics) : base(name, characteristics) { woodType = "Клен"; }
        public Violin(string name, string characteristics, string woodType) : base(name, characteristics) { this.woodType = woodType; }
        public Violin(Violin other) : base(other) { woodType = other.woodType; }

        public override void Sound() { Console.WriteLine("Скрипка співає високим, мелодійним звуком."); }
        public override void Show() { Console.WriteLine("Музичний інструмент: " + Name); }
        public override void Desc() { Console.WriteLine("Скрипка — смичковий струнний музичний інструмент високого регістру."); }
        public override void History() { Console.WriteLine("Скрипка з'явилася в Італії на початку XVI століття."); }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Тип деревини: " + woodType);
        }
    }

    public class Trombone : MusicalInstrument
    {
        private string bellSize;

        public string BellSize
        {
            get { return bellSize; }
            set { bellSize = value; }
        }

        public Trombone() : base("Тромбон", "Мідний духовий") { bellSize = "Стандартний (203 мм)"; }
        public Trombone(string name, string characteristics) : base(name, characteristics) { bellSize = "Великий"; }
        public Trombone(string name, string characteristics, string bellSize) : base(name, characteristics) { this.bellSize = bellSize; }
        public Trombone(Trombone other) : base(other) { bellSize = other.bellSize; }

        public override void Sound() { Console.WriteLine("Тромбон видає потужний, насичений трубний звук з глісандо."); }
        public override void Show() { Console.WriteLine("Музичний інструмент: " + Name); }
        public override void Desc() { Console.WriteLine("Тромбон — мідний духовий музичний інструмент із кулісою."); }
        public override void History() { Console.WriteLine("Тромбон походить від сакбута і сформувався у XV столітті."); }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Розмір розтруба: " + bellSize);
        }
    }

    public class Ukulele : MusicalInstrument
    {
        private string sizeType;

        public string SizeType
        {
            get { return sizeType; }
            set { sizeType = value; }
        }

        public Ukulele() : base("Укулеле", "Чотириструнна міні-гітара") { sizeType = "Сопрано"; }
        public Ukulele(string name, string characteristics) : base(name, characteristics) { sizeType = "Концертне"; }
        public Ukulele(string name, string characteristics, string sizeType) : base(name, characteristics) { this.sizeType = sizeType; }
        public Ukulele(Ukulele other) : base(other) { sizeType = other.sizeType; }

        public override void Sound() { Console.WriteLine("Укулеле видає легкий, дзвінкий і теплий гавайський звук."); }
        public override void Show() { Console.WriteLine("Музичний інструмент: " + Name); }
        public override void Desc() { Console.WriteLine("Укулеле — різновид гітари з чотирма струнами."); }
        public override void History() { Console.WriteLine("Укулеле створена в кінці XIX століття на Гаваях."); }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Тип розміру: " + sizeType);
        }
    }

    public class Cello : MusicalInstrument
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Cello() : base("Віолончель", "Смичковий струнний") { height = 120.0; }
        public Cello(string name, string characteristics) : base(name, characteristics) { height = 120.0; }
        public Cello(string name, string characteristics, double height) : base(name, characteristics) { this.height = height; }
        public Cello(Cello other) : base(other) { height = other.height; }

        public override void Sound() { Console.WriteLine("Віолончель звучить глибоко, оксамитово, нагадуючи людський голос."); }
        public override void Show() { Console.WriteLine("Музичний інструмент: " + Name); }
        public override void Desc() { Console.WriteLine("Віолончель — смичковий музичний інструмент басового регістру."); }
        public override void History() { Console.WriteLine("Віолончель з'явилася на початку XVI століття."); }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Висота корпусу: " + height + " см");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin("Скрипка Страдіварі", "Професійна, 4 струни", "Цінні породи дерева"),
                new Trombone("Тенор-тромбон", "Мідний духовий з кулісою", "215 мм"),
                new Ukulele("Укулеле Концерт", "Нейлонові струни", "Концерт"),
                new Cello("Акустична віолончель", "Великий смичковий інструмент", 125.5)
            };

            Console.WriteLine("=== ДЕМОНСТРАЦІЯ ПОЛІМОРФІЗМУ ===\n");

            for (int i = 0; i < instruments.Length; i++)
            {
                Console.WriteLine("--- Інструмент №" + (i + 1) + " ---");
                instruments[i].Show();
                instruments[i].Desc();
                instruments[i].History();
                instruments[i].Sound();
                instruments[i].ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=== ТЕСТУВАННЯ КОНСТРУКТОРА КОПІЮВАННЯ ===");
            Violin original = new Violin("Скрипка Академічна", "Студентська", "Ялина");
            Violin clone = new Violin(original);
            clone.Name = "Скрипка (Копія)";

            Console.WriteLine("Оригінал:");
            original.ShowInfo();
            Console.WriteLine("\nКопія:");
            clone.ShowInfo();

            Console.ReadKey();
        }
    }
}