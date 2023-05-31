using Microsoft.EntityFrameworkCore.Storage;

using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public readonly IDeviceActionsRepository DeviceActionsRepository;
        public readonly IDevicesRepository DevicesRepository;
        public readonly IDeviceTypesRepository DeviceTypesRepository;
        public readonly IHomesRepository HomesRepository;
        public readonly IRoomsRepository RoomsRepository;
        public readonly IUsersRepository UsersRepository;

        public UnitOfWork(
            DatabaseContext databaseContext,

            IUsersRepository usersRepository,
            IDeviceActionsRepository deviceActionsRepository,
            IDevicesRepository devicesRepository,
            IDeviceTypesRepository deviceTypesRepository,
            IHomesRepository homesRepository,
            IRoomsRepository roomsRepository)
        {
            _databaseContext = databaseContext;

            UsersRepository = usersRepository;
            DeviceActionsRepository = deviceActionsRepository;
            DevicesRepository = devicesRepository;
            DeviceTypesRepository = deviceTypesRepository;
            HomesRepository = homesRepository;
            RoomsRepository = roomsRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.SaveChangesAsync(cancellationToken);
        }
    }
}
