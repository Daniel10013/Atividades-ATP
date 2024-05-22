namespace Exercises
{
    public class Exercise10: BaseExercise
    {
        public void Run()
        {
            string category;
            category = GetCategory();   
            Console.WriteLine("Baseado na idade do atleta a categoria que ele se encaixa e: " + category);
        }

        public static string GetCategory(){
            int age;
            string category = "";
                
            Console.WriteLine("Digite a idade do nadador:");
            age = GetInput();
            if(age >= 5 && age <=7){
                category = "F";
            }

            if(age >= 8 && age <= 10){
                category = "E";
            }

            if(age >= 11 && age <= 13){
                category = "D";
            }

            if(age >= 14 && age <= 15){
                category = "C";
            }

            if(age >= 16 && age <= 17){
                category = "B";
            }

            if(age >= 18){
                category = "A";
            }      

            return category;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}