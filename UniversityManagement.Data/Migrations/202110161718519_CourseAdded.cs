﻿namespace UniversityManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Credit = c.Int(nullable: false),
                        Description = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        Semester = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.Courses");
        }
    }
}
