
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using VillaMon_API.Data;
using VillaMon_API.Models;
using VillaMon_API.Models.Dto;
using VillaMon_API.Controllers;

[TestFixture]
public class VillaAPIControllerTests
{
    private Mock<ApplicationDbContext> _dbMock;
    private VillaAPIController _controller;

    [SetUp]
    public void Setup()
    {
        _dbMock = new Mock<ApplicationDbContext>();
        _controller = new VillaAPIController(_dbMock.Object);
    }

    [Test]
    public void GetVillas_ReturnsAllVillas()
    {
        // Arrange
        var villas = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Luxury Villa" },
            new VillaDTO { Id = 2, Name = "Beachfront Villa" }
        };
        _dbMock.Setup(db => db.Villas).Returns((Microsoft.EntityFrameworkCore.DbSet<Villa>)villas.AsQueryable());

        // Act
        var result = _controller.GetVillas();

        // Assert
        Assert.That(result, Is.InstanceOf<ActionResult<IEnumerable<VillaDTO>>>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult, Is.Not.Null);
        var returnedVillas = okResult?.Value as List<VillaDTO>;
        Assert.That(returnedVillas?.Count, Is.EqualTo(2));
    }

    [Test]
    public void GetVillas_ReturnsNotFoundWhenEmpty()
    {
        // Arrange
        _dbMock.Setup(db => db.Villas).Returns((Microsoft.EntityFrameworkCore.DbSet<Villa>)new List<VillaDTO>().AsQueryable());

        // Act
        var result = _controller.GetVillas();

        // Assert
        Assert.That(result, Is.InstanceOf<ActionResult<IEnumerable<VillaDTO>>>());
        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }

    [Test]
    public void GetVilla_ValidId_ReturnsVilla()
    {
        // Arrange
        var villa = new VillaDTO { Id = 1, Name = "Luxury Villa" };
        _dbMock.Setup(db => db.Villas).Returns((Microsoft.EntityFrameworkCore.DbSet<Villa>)new List<VillaDTO> { villa }.AsQueryable());

        // Act
        var result = _controller.GetVilla(1);

        // Assert
        Assert.That(result, Is.InstanceOf<ActionResult<VillaDTO>>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult, Is.Not.Null);
        var returnedVilla = okResult?.Value as VillaDTO;
        Assert.That(returnedVilla?.Name, Is.EqualTo("Luxury Villa"));
    }

    [Test]
    public void GetVilla_InvalidId_ReturnsNotFound()
    {
        // Arrange
        _dbMock.Setup(db => db.Villas).Returns((Microsoft.EntityFrameworkCore.DbSet<Villa>)new List<VillaDTO>().AsQueryable());

        // Act
        var result = _controller.GetVilla(99);

        // Assert
        Assert.That(result, Is.InstanceOf<ActionResult<VillaDTO>>());
        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }
}
