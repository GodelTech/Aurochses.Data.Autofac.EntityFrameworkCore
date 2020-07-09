using Microsoft.EntityFrameworkCore;
using Xunit;

namespace GodelTech.Data.Autofac.EntityFrameworkCore.Tests
{
    public class ModuleBaseTests
    {
        private const string SchemaName = "dbo";
        private readonly DbContextOptionsBuilder<DbContext> _dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

        private readonly ModuleBase _moduleBase;

        public ModuleBaseTests()
        {
            _moduleBase = new ModuleBase(_dbContextOptionsBuilder.Options, SchemaName);
        }

        [Fact]
        public void Inherit_Module()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<global::Autofac.Module>(_moduleBase);
        }

        [Fact]
        public void DbContextOptions_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(_dbContextOptionsBuilder.Options, _moduleBase.DbContextOptions);
        }

        [Fact]
        public void SchemaName_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(SchemaName, _moduleBase.SchemaName);
        }
    }
}