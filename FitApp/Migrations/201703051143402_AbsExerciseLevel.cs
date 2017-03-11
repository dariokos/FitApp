namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AbsExerciseLevel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Abs SET ExerciseLevel = 'beginner' WHERE ExerciseId=1");
        }
        
        public override void Down()
        {
        }
    }
}
