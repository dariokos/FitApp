namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AbsExerciseSeed : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (1, 'Crunch')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (2, 'Leg Lifts')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (3, 'Windshield wipers')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (4, 'Side Crunch')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (5, 'Russian Twists')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (6, 'StarFish Crunch')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (7, 'Plank Crunch')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (8, 'Toe Touches')");
            Sql("INSERT INTO Abs(ExerciseId, ExerciseName) VALUES (9, 'Knee Raises')");
        }
        
        public override void Down()
        {
        }
    }
}
