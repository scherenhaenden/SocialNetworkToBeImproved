using DataAccess.DataBase.Core.Configuration.EntityFramework;
using DataAccess.DataBase.Core.UnitiesOfWork;
using DataAccess.DataBase.Persistance.UnitiesOfWork;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataBase.Test.FirstTest;

public class Test1
{
    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<EFContext>();
        options.UseSqlServer($"Server=localhost, 1433;Database=p2029;User ID=sa;Password=p6jl95#S;Trusted_Connection=False;MultipleActiveResultSets=true");
        //options.UseSqlServer( "ID=sa;Password=p6jl95#S;Trusted_Connection=false;database=p2029;server=(local);MultipleActiveResultSets=true");
            
        EFContext tourManagerContext = new EFContext(options.Options);
        //tourManagerContext.Database.EnsureDeleted();
        //tourManagerContext.Database.EnsureCreated();
        /*var values = tourManagerContext.Database.GenerateCreateScript();
        tourManagerContext.Database.ExecuteSqlRaw(values);*/
        //tourManagerContext.Database.Migrate();
        _unitOfWorkV2Ef = new UnitOfWorkV2EntityFramework(tourManagerContext);
    }

    private IUnitOfWorkV2 _unitOfWorkV2Ef;
    
    /*[Test]
    public void Test1_Method1()
    {

        var ghhgh = _unitOfWorkV2Ef.Gender.GetAll().ToList();
        var g = new Gender()
        {
            GenderType = 'M'
        };
        
        var g2 = new Gender()
        {
            GenderType = 'F'
        };
        var g3 = new Gender()
        {
            GenderType = 'O'
        };
        
        _unitOfWorkV2Ef.Gender.Add(g);
        _unitOfWorkV2Ef.Gender.Add(g2);
        _unitOfWorkV2Ef.Gender.Add(g3);
        var result = _unitOfWorkV2Ef.Complete();
        Assert.NotNull(ghhgh);


    }
    
    [Test]
    public void Test1_Method2()
    {

        var ghhgh = _unitOfWorkV2Ef.Gender.GetAll().ToList();
        Assert.NotNull(ghhgh);
        Assert.AreEqual(ghhgh.Count, 3);


    }*/
    
      
    /*[Test]
    public void Test1_Method3()
    {

        var role = new Roles();
        role.Name = "Administrator";
        role.NormalizedName = "Admin";
        
        var role2 = new Roles();
        role2.Name = "AspNetUser";
        role2.NormalizedName = "AspNetUser";
        
        _unitOfWorkV2Ef.Roles.Add(role);
        _unitOfWorkV2Ef.Roles.Add(role2);
        
        var result = _unitOfWorkV2Ef.Complete();
            
        var ghhgh = _unitOfWorkV2Ef.Roles.GetAll().ToList();
        Assert.NotNull(ghhgh);
        Assert.AreEqual(ghhgh.Count, 2);


    }*/
    
    public void Test1_Method4()
    {

        var myUser = _unitOfWorkV2Ef.Users.GetAll()
            .Single(x => x.UserName.ToLower() == "edward_sergio_flores@hotmail.com".ToLower());
        
        
        
        
        
        var role = new Roles();
        role.Name = "Administrator";
        role.NormalizedName = "Admin";
        
        var role2 = new Roles();
        role2.Name = "AspNetUser";
        role2.NormalizedName = "AspNetUser";
        
        _unitOfWorkV2Ef.Roles.Add(role);
        _unitOfWorkV2Ef.Roles.Add(role2);
        
        var result = _unitOfWorkV2Ef.Complete();
            
        var ghhgh = _unitOfWorkV2Ef.Roles.GetAll().ToList();
        Assert.NotNull(ghhgh);
        Assert.AreEqual(ghhgh.Count, 2);


    }
    


    
}