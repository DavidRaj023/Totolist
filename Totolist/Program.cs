class Program
{
    public static void Main(string[] args)
    {
        try
        {
            List<ToDo> toDoList = new List<ToDo>();

            int choice = 0;
            Console.WriteLine("Welcome to ToDo Application");
            while (true)
            {
                Console.WriteLine("Please Select an Option Below...\n\n");

                Console.WriteLine("1. Add New Task.");
                Console.WriteLine("2. Update Existing Task");

                Console.Write("\nEnter your choice: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ToDoService.Add(toDoList);
                            break;
                        case 2:
                            ToDoService.Update(toDoList);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter the valid option\n");
                }


            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}