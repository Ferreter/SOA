
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using VillaMon_API.Data;
using VillaMon_API.Models;
using VillaMon_API.Models.Dto;
using VillaMon_API.Controllers;
using Microsoft.EntityFrameworkCore;

[TestFixture]
public class VillaAPIControllerTests
{
    private Mock<ApplicationDbContext> _dbMock;
    private VillaAPIController _controller;
    private Mock<DbSet<Villa>> _villaDbSetMock;

    [SetUp]
    public void Setup()
    {
        _dbMock = new Mock<ApplicationDbContext>();
        _villaDbSetMock = new Mock<DbSet<Villa>>();
        _controller = new VillaAPIController(_dbMock.Object);
    }

    [Test]
    public void GetVillas_ReturnsListOfVillas()
    {
        // Arrange
        var villas = new List<Villa>
        {
            new Villa { Id = 1, Name = "Villa 1", Rate = 100.0 },
            new Villa { Id = 2, Name = "Villa 2", Rate = 200.0 }
        }.AsQueryable();

        _villaDbSetMock.As<IQueryable<Villa>>().Setup(m => m.Provider).Returns(villas.Provider);
        _villaDbSetMock.As<IQueryable<Villa>>().Setup(m => m.Expression).Returns(villas.Expression);
        _villaDbSetMock.As<IQueryable<Villa>>().Setup(m => m.ElementType).Returns(villas.ElementType);
        _villaDbSetMock.As<IQueryable<Villa>>().Setup(m => m.GetEnumerator()).Returns(villas.GetEnumerator());

        _dbMock.Setup(db => db.Villas).Returns(_villaDbSetMock.Object);

        // Act
        var result = _controller.GetVillas();

        // Assert
        Assert.That(result.Value, Is.InstanceOf<IEnumerable<VillaDTO>>());
        var villaDTOs = result.Value as IEnumerable<VillaDTO>;
        Assert.That(villaDTOs?.Count(), Is.EqualTo(villas.Count()));
    }

    // Other tests remain unchanged
}
