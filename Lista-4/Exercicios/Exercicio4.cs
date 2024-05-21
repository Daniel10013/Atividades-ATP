namespace Exercises
{
    public class Exercise4: BaseExercise
    {
        public void Run()
        {
            setTriangleType();
        }

        public void setTriangleType(){
            int side1, side2, side3;
            string triangleType;
   
            Console.WriteLine("Digite o valor do primeiro lado:");
            side1 = GetInput();
                
            Console.WriteLine("Digite o valor do segundo lado:");
            side2 = GetInput();
                
            Console.WriteLine("Digite o valor do terceiro terceiro:");
            side3 = GetInput();

            if(IsAnValidTriangle(side1, side2, side3) == false){
                Console.WriteLine("Os valores dos lados do triangulo são inválidos!");
                return;
            }

            triangleType = getTriangleType(side1, side2, side3);
            Console.WriteLine("O triangulo é do tipo: " + triangleType);
        }

        public static string getTriangleType(int side1, int side2, int side3){
            bool IsEquilateral = side1 == side2 && side2 == side3;
            if(IsEquilateral == true){
                return "Equilátero";
            }
            
            bool IsIsoceles = side1 == side2 || side2 == side3 || side1 == side3;            
            if(IsIsoceles == true){
                return "Isóceles";
            }
            
            bool IsScalene = side1 != side2 && side2 != side3 && side1 != side3;
            if(IsScalene == true){
                return "Escaleno";
            }

            return "Retangulo";
        }

        public static bool IsAnValidTriangle(int side1, int side2, int side3){
            if(side1 > side2 + side3){
                return false;
            }

            if(side2 > side3 + side1){
                return false;
            }

            if(side3 > side1 + side2){
                return false;
            }

            return true;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input < 0)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}