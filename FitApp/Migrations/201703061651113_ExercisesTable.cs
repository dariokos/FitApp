namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExercisesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ExerciseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exercises");
        }
    }
}
