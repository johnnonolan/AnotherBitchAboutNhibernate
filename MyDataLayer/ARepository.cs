namespace MyDataLayer
{
    public class ARepository
    {
        readonly IUnitOfWork _unitOfWork;


        public ARepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MyEntity Get(int Id)
        {
            var session =  _unitOfWork.CurrentSession;
            using (var transaction = session.BeginTransaction())
            {
                var entity = session.Get<MyEntity>(Id);
                transaction.Commit();
                return entity;
            }

        }
    }
}
