using OBS.Data;

using var _dbContext = new BookStoreDbContext();
BookStoreDbInitializer.Initialize(_dbContext);