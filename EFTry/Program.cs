using EFDemo.Context;

using var context = new AppDbContext();

// Ensure database is created
await context.Database.EnsureCreatedAsync();

Console.WriteLine("Database created successfully!");