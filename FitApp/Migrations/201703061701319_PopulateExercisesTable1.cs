namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateExercisesTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Squat')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Lunge')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Push-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Pull-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('One handed push-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('One handed pull-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Clapping push-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Superman push-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Typewriter pull-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Muscle up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Dips')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Bench dips')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Pistol squat')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Handstand push-up')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Pike pushup')");
            Sql("INSERT INTO Exercises(ExerciseName) VALUES ('Calf raise')");
        }
        
        public override void Down()
        {
        }
    }
}
