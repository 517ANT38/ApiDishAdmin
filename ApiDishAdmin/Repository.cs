namespace ApiDishAdmin
{
    public class Repository : IRepository
    {
        private IList<Dish> dishes=new List<Dish>();  
        public string Add(NewDish dish)
        {
            var d = new Dish()
            {
                Id = Guid.NewGuid().ToString(),
                Name = dish.Name,
                Calorific = dish.Calorific,
                Category = dish.Category,
                Catering = dish.Catering,
                Description = dish.Description,
                Price = dish.Price,
                Img = System.Text.Encoding.UTF8.GetBytes(dish.Img),
                Weight = dish.Weight
            };
            Console.WriteLine("!!!!!!");
            dishes.Add(d);
            //Console.WriteLine(dishes.Values.ElementAt(dishes.Count-1).Name);
           
            return d.Id;

        }

        public void Delete(string id)
        {
            //dishes.Remove(id);
        }

        public IEnumerable<Dish> GetAll()
        {
            

            return dishes;
        }
    }
}
