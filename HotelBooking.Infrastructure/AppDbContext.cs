using HotelBooking.Entity.Base;
using HotelBooking.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Infrastructure
{
    /// <summary>
    /// Applicaation database context.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the bookings.
        /// </summary>
        /// <value>
        /// The bookings.
        /// </value>
        public DbSet<Booking> Bookings { get; set; }

        /// <summary>
        /// Gets or sets the booking statuses.
        /// </summary>
        /// <value>
        /// The booking statuses.
        /// </value>
        public DbSet<BookingStatus> BookingStatuses { get; set; }

        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        /// <value>
        /// The cities.
        /// </value>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// Gets or sets the countries.
        /// </summary>
        /// <value>
        /// The countries.
        /// </value>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// Gets or sets the facilities.
        /// </summary>
        /// <value>
        /// The facilities.
        /// </value>
        public DbSet<Facility> Facilities { get; set; }

        /// <summary>
        /// Gets or sets the hotels.
        /// </summary>
        /// <value>
        /// The hotels.
        /// </value>
        public DbSet<Hotel> Hotels { get; set; }

        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        /// <value>
        /// The reviews.
        /// </value>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Gets or sets the rooms.
        /// </summary>
        /// <value>
        /// The rooms.
        /// </value>
        public DbSet<Room> Rooms { get; set; }

        /// <summary>
        /// Gets or sets the room types.
        /// </summary>
        /// <value>
        /// The room types.
        /// </value>
        public DbSet<RoomType> RoomTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppDbContext" /> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// <para>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run. However, it will still run when creating a compiled model.
        /// </para>
        /// <para>
        /// See <see href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</see> for more information and
        /// examples.
        /// </para>
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// Set created date and last updated date upon saving.
        /// </summary>
        /// <returns>
        /// The number of state entries written to the database.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This method will automatically call <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.DetectChanges" />
        /// to discover any changes to entity instances before saving to the underlying database. This can be disabled via
        /// <see cref="P:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AutoDetectChangesEnabled" />.
        /// </para>
        /// <para>
        /// Entity Framework Core does not support multiple parallel operations being run on the same DbContext instance. This
        /// includes both parallel execution of async queries and any explicit concurrent use from multiple threads.
        /// Therefore, always await async calls immediately, or use separate DbContext instances for operations that execute
        /// in parallel. See <see href="https://aka.ms/efcore-docs-threading">Avoiding DbContext threading issues</see> for more information
        /// and examples.
        /// </para>
        /// <para>
        /// See <see href="https://aka.ms/efcore-docs-saving-data">Saving data in EF Core</see> for more information and examples.
        /// </para>
        /// </remarks>
        public override int SaveChanges()
        {
            var entries = from e in ChangeTracker.Entries()
                          where e.Entity is EntityBase &&
                                (e.State == EntityState.Added ||
                                e.State == EntityState.Modified)
                          select e;

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((EntityBase)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
