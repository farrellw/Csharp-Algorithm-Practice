
namespace Practice
{
    public class Person
    {
        public string name = "unknown";
        public int age;
        public Person(string inputName) 
        {
            name = inputName;
            age = 0;
        }

        public void ager(int years)
        {
           for (int a = 0; a < years; a = a + 1)
           {
               ageOneYear();
           }
        }

        private void ageOneYear()
        {
            age = age + 1;
        }
    }
}