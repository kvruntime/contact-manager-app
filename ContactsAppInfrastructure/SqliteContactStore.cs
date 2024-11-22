using System;
using ContactsAppDomain.Entities;
using ContactsAppDomain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContactsAppInfrastructure;

public class SqliteContactStore : IContactRepository
{
  private readonly DbContext _dbContext;
  private readonly DbSet<ContactEntity> _contactSet;

  public SqliteContactStore(DbContext dbContext)
  {
    this._dbContext = dbContext;
    _contactSet = dbContext.Set<ContactEntity>();
    _dbContext.Database.EnsureCreated();

  }

  public async Task Add(ContactEntity entity)
  {
    await _contactSet.AddAsync(entity);
  }

  public async Task<ContactEntity>? Get(Guid id)
  {
    return await _contactSet.FirstOrDefaultAsync(i => i.Id == id);
  }

  public async Task<List<ContactEntity>> GetAll()
  {
    return await _contactSet.ToListAsync();
  }

  public Task Remove(ContactEntity entity)
  {
    _contactSet.Remove(entity);
    return Task.CompletedTask;
  }

  public async Task Save()
  {
    await _dbContext.SaveChangesAsync();
  }

  public Task Update(Guid id, ContactEntity entity)
  {
    _contactSet.Update(entity);
    return Task.CompletedTask;
  }
}
