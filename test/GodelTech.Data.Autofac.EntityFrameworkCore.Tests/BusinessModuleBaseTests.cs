using Microsoft.EntityFrameworkCore;
using Xunit;

namespace GodelTech.Data.Autofac.EntityFrameworkCore.Tests
{
    public class BusinessModuleBaseTests
    {
        private const string SchemaName = "dbo";
        private readonly DbContextOptionsBuilder<DbContext> _dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

        private readonly BusinessModuleBase _businessModuleBase;

        public BusinessModuleBaseTests()
        {
            _businessModuleBase = new BusinessModuleBase(_dbContextOptionsBuilder.Options, SchemaName);
        }

        [Fact]
        public void Inherit_Module()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<global::Autofac.Module>(_businessModuleBase);
        }

        [Fact]
        public void DbContextOptionsParameter_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("dbContextOptions", BusinessModuleBase.DbContextOptionsParameter);
        }

        [Fact]
        public void SchemaNameParameter_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("schemaName", BusinessModuleBase.SchemaNameParameter);
        }

        [Fact]
        public void DbContextOptions_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(_dbContextOptionsBuilder.Options, _businessModuleBase.DbContextOptions);
        }

        [Fact]
        public void SchemaName_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(SchemaName, _businessModuleBase.SchemaName);
        }
    }
}