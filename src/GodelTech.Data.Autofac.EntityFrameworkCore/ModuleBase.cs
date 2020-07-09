using Autofac;
using Microsoft.EntityFrameworkCore;

namespace GodelTech.Data.Autofac.EntityFrameworkCore
{
    /// <summary>
    /// Autofac module.
    /// </summary>
    /// <seealso cref="Module" />
    public class ModuleBase : Module
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleBase"/> class.
        /// </summary>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public ModuleBase(DbContextOptions dbContextOptions, string schemaName)
        {
            DbContextOptions = dbContextOptions;
            SchemaName = schemaName;
        }

        /// <summary>
        /// Gets the database context options.
        /// </summary>
        /// <value>The database context options.</value>
        public DbContextOptions DbContextOptions
        {
            get;
        }

        /// <summary>
        /// Gets the database schema name.
        /// </summary>
        /// <value>The database schema name.</value>
        public string SchemaName
        {
            get;
        }
    }
}