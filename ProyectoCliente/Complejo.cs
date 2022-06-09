namespace ProyectoCliente
{
    public class Complejo
    {
        private float realNumber;
        private float imaginaryNumber;

        public Complejo()
            :this(0.0f, 0.0f)
        {
            
        }

        public float RealNumber
        {
            get
            {
                return realNumber;
            }
            set
            {
                realNumber = value;
            }
        }

        public float ImaginaryNumber
        {
            get
            {
                return imaginaryNumber;
            }
            set
            {
                imaginaryNumber = value;
            }
        }

        public Complejo(float realNumber, float imaginaryNumber)
        {
            RealNumber = realNumber;
            ImaginaryNumber = imaginaryNumber;
        }

        public void Addition(Complejo complexNumber)
        {
            this.realNumber += complexNumber.realNumber;
            this.imaginaryNumber += complexNumber.imaginaryNumber;
        }

        public void Multiplication(Complejo complexNumber)
        {
            Complejo temp = new Complejo(RealNumber, ImaginaryNumber);
            this.realNumber = (complexNumber.realNumber * temp.realNumber) - (complexNumber.imaginaryNumber * temp.imaginaryNumber);
            this.imaginaryNumber = (complexNumber.imaginaryNumber * temp.realNumber) + (complexNumber.realNumber * temp.imaginaryNumber) ;
        }

        public bool Igual(Complejo complexNumber)
        {
            if(this.realNumber ==complexNumber.realNumber && this.imaginaryNumber == complexNumber.imaginaryNumber)
            {
                return true;
            }
            return false;
        }

        public float Absolute
        {
            get
            {
                float result = (float)Math.Sqrt(((this.realNumber * this.realNumber) + (this.imaginaryNumber * this.imaginaryNumber)));
                return result;
            }
        }
    }
}