namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkoutTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        WorkoutId = c.Int(nullable: false, identity: true),
                        ExerciseId = c.Int(nullable: false),
                        WorkoutDate = c.DateTime(nullable: false),
                        FirstSet = c.Byte(nullable: false),
                        SecondSet = c.Byte(nullable: true),
                        ThirdSet = c.Byte(nullable: true),
                        FourthSet = c.Byte(nullable: true),
                        FifthSet = c.Byte(nullable: true),
                    })
                .PrimaryKey(t => t.WorkoutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workouts");
        }
    }
}
