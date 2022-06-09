namespace ProyectoCliente
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public string Surname2 { get; set; }

        public Customer()
            :this("Anonimo", "", "", 170, 80)
        {
            
        }

        public Customer(string name, string surname1, string surname2, int height, decimal weight)
        {
            Name = name;
            Surname1 = surname1;
            Surname2 = surname2;
            Height = height;
            Weight = weight;
        }


        public string CompleteName
        {
            get
            {

                return Name + " " + Surname1 + " " + Surname2;

            }
            set
            {
                Name = "";
                Surname1 = "";
                Surname2 = "";

                string[] subs = value.Split(' ');
                if(subs.Length > 0)
                {
                    Name = subs[0];
                }

                if (subs.Length >= 1)
                {
                    Surname1 = subs[1];
                }

                if (subs.Length == 3)
                {
                    Surname2 = subs[2];
                }

                if (subs.Length > 3)
                {
                    for (int i = 2; i < subs.Length; i++)
                    {
                        Surname2 = Surname2 + subs[i] + " ";
                    }
                }
            }
        }

       public decimal CalculateIMC
        {
           get
            {
                decimal height = Convert.ToDecimal(Height);
                decimal heightMeters = height / 100;
                return Math.Round(Weight / (heightMeters * heightMeters), 1);
            }         
        }

        public string Level
        {
            get
            {
                string level = "Error";

                if(CalculateIMC >=  30)
                {
                    level = "Obesidad";
                }else if(CalculateIMC >= (decimal) 25.0 && CalculateIMC <= (decimal) 29.9)
                {
                    level = "Sobrepeso";
                }else if(CalculateIMC >= (decimal)18.5 && CalculateIMC <= (decimal)24.9)
                {
                    level = "Normal";
                }else if(CalculateIMC < (decimal)18.5)
                {
                    level = "Bajo peso";
                }
                return level;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {Name} Apellidos: {Surname1} {Surname2} Altura: {Height} Peso: {Weight}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer && customer.CalculateIMC == CalculateIMC;
        }

        public static bool operator ==(Customer Left, Customer Right) => Left.Equals(Right); 
        public static bool operator !=(Customer Left, Customer Right) => !Left.Equals(Right); 

        public static bool operator ==(Customer Left, float Right) => Left.CalculateIMC == (decimal)Right;
        public static bool operator !=(Customer Left, float Right) => Left.CalculateIMC != (decimal)Right;

        public static bool operator ==(float Left, Customer Right) => (decimal)Left == Right.CalculateIMC;
        public static bool operator !=(float Left, Customer Right) => (decimal)Left != Right.CalculateIMC;

    }
}