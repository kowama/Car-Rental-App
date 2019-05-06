using System;
using System.Data.Entity.Validation;
using System.Text;
using CarRentalApp.Core;
using CarRentalApp.Core.Repositories;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence.Repositories;

namespace CarRentalApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public static UnitOfWork Instance { get; } = new UnitOfWork();

        private readonly CarRentalAppContext _context;

        private UnitOfWork()
        {
            _context = new CarRentalAppContext();

            Bills = new BillRepository(_context);
            Cars = new CarRepository(_context);
            Clients = new ClientRepository(_context);
            Classifications = new ClassificationRepository(_context);
            Rents = new RentRepository(_context);
            Roles = new RoleRepository(_context);
            Users = new UserRepository(_context);
            _context.Database.Log =  AppLogger.LogSqlInFile;


        }

        public IBillRepository Bills { get; private set; }

        public ICarRepository Cars { get; private set; }

        public IClassificationRepository Classifications { get; private set; }

        public IClientRepository Clients { get; private set; }

        public IRentRepository Rents { get; }

        public IRoleRepository Roles { get; private set; }

        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

    public class FormattedDbEntityValidationException : Exception
    {
        public FormattedDbEntityValidationException(Exception innerException) :
            base(null, innerException)
        {
        }

        public override string Message
        {
            get
            {
                if (!(InnerException is DbEntityValidationException innerException)) return base.Message;
                var sb = new StringBuilder();

                sb.AppendLine();
                sb.AppendLine();
                foreach (var eve in innerException.EntityValidationErrors)
                {
                    sb.AppendLine(
                        $"- Entity of type \"{eve.Entry.Entity.GetType().FullName}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine(
                            $"-- Property: \"{ve.PropertyName}\", Value: \"{eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
                sb.AppendLine();
                return sb.ToString();

            }
        }
    }
}