using Task_Management.Model;

namespace Task_Management.Services
{
    
    public class Task : ITask
    {
        private List<Tasks> TaskCollection = new();
        public Tasks Create(Tasks task)
        {
           TaskCollection.Add(task);
            return task;
        }

        public bool Delete(int id)
        {
            var task = TaskCollection.FirstOrDefault(x => x.Id == id);
           if(!TaskCollection.Remove(task))
                return false;
            return true;
        }

        public Tasks Get(int id)
        {
            var task = TaskCollection.FirstOrDefault( i => i.Id == id);
            return task;
        }

        public List<Tasks> GetAll()
        {
           return TaskCollection;
        }

       public Tasks Update(Tasks task)
        {
           var OldTask = TaskCollection.Find(i => i.Id == task.Id);
            if (OldTask != null)
            {
                TaskCollection.Remove(OldTask);
                TaskCollection.Add(task);
            }
            return task;
        }

    }
}
