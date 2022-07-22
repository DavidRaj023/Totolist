public class ToDoService
{
    public static void Add(List<ToDo> list)
    {
        try
        {
            ToDo toDo = new ToDo();

            toDo.Id = list.Count() + 1;

            Console.Write("\nEnter the title: ");
            toDo.Title = Console.ReadLine();

            Console.Write("Enter the description: ");
            toDo.Description = Console.ReadLine();
            toDo.IsCompleted = false;
            toDo.CreatedAt = DateTime.Now;
            toDo.UpdatedAt = DateTime.Now;

            list.Add(toDo);

            Console.WriteLine("\nNew Task Added Successfully....\n");
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static void Update(List<ToDo> list)
    {
        try
        {
            Console.WriteLine("\t{0} \t{1} \t{2} \t\t{3} \t\t{4} \t\t{5}", "Id", "Title", "Description", "Completed", "CreatedAt", "UpdatedAt");
            foreach (ToDo task in list)
            {
                Console.WriteLine("\t{0} \t{1} \t{2} \t\t{3} \t\t{4} \t\t{5}", task.Id, task.Title, task.Description, task.IsCompleted, task.CreatedAt, task.UpdatedAt);
            }

            Console.Write("Enter the task id to update: ");
            int taskId = Convert.ToInt32(Console.ReadLine());

            var taskInfo = list.Where(task => task.Id == taskId).FirstOrDefault();
            if (taskInfo != null)
            {
                Console.WriteLine("Press 1 to change the status");
                Console.WriteLine("Press 2 to edit the task");

                Console.Write("Enter your choice: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        ChangeStatus(list, taskId);
                        break;
                    case 2:
                        EditTask(list, taskId);
                        break;
                    default:
                        Console.WriteLine("Please enter the valid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unable to find the given task...., Please try again");
            }
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private static void EditTask(List<ToDo> list, int taskId)
    {
        try
        {
            ToDo taskUpdate = new ToDo();

            Console.Write("Enter the title: ");
            taskUpdate.Title = Console.ReadLine();

            Console.Write("Enter the description: ");
            taskUpdate.Description = Console.ReadLine();

            taskUpdate.UpdatedAt = DateTime.Now;

            list.Where(task => task.Id == taskId).FirstOrDefault().Title = taskUpdate.Title;
            list.Where(task => task.Id == taskId).FirstOrDefault().Description = taskUpdate.Description;
            list.Where(task => task.Id == taskId).FirstOrDefault().UpdatedAt = taskUpdate.UpdatedAt;

            Console.WriteLine("Task updated");
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private static void ChangeStatus(List<ToDo> list, int taskId)
    {
        try
        {
            Console.Write("Enter Yes/No." +
            "\nIs Completed: ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput.Equals("yes")) { list.Where(task => task.Id == taskId).FirstOrDefault().IsCompleted = true; return; }
            if (userInput.Equals("no")) { list.Where(task => task.Id == taskId).FirstOrDefault().IsCompleted = false; return; }
            Console.WriteLine("Please enter the valid input..");
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}