using Task_Management.Model;

namespace Task_Management
{
    public interface ITask
    {
        public Tasks Create(Tasks tasks);
        public Tasks Get(int id);
        public List<Tasks> GetAll();
        public Tasks Update(Tasks task);
        public bool Delete(int id);
    }
}
