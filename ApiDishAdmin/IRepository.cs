namespace ApiDishAdmin
{
    
    public interface IRepository
    {
        string Add(NewDish dish);
        IEnumerable<Dish> GetAll();
        void Delete(string id);    
    }
}
