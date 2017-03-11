using System.Data.SqlClient;

namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AbsExerciseEquipmentPopulate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Abs SET ExerciseEquipment='pullupbar' WHERE ExerciseName='Windshield wipers'");
        }
        
        public override void Down()
        {
        }
    }
}
