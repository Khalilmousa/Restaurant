namespace Restaurant.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        //private ICustomerRepository _customerRepository;
        public IDishRepository DishRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IIngridientRepository IngridientRepository { get; set; }


    }
}
