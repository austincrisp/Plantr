namespace Plantr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCourseStructure : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            AddColumn("dbo.Courses", "Description", c => c.String());
            AddColumn("dbo.Courses", "Question", c => c.String());
            AddColumn("dbo.Courses", "AvgCompTime", c => c.String());
            DropColumn("dbo.Courses", "CourseOneSent");
            DropColumn("dbo.Courses", "CourseOneRec");
            DropColumn("dbo.Courses", "CourseTwoSent");
            DropColumn("dbo.Courses", "CourseTwoRec");
            DropColumn("dbo.Courses", "CourseThreeSent");
            DropColumn("dbo.Courses", "CourseThreeRec");
            DropColumn("dbo.Courses", "CourseFourSent");
            DropColumn("dbo.Courses", "CourseFourRec");
            DropColumn("dbo.Courses", "CourseFiveSent");
            DropColumn("dbo.Courses", "CourseFiveRec");
            DropColumn("dbo.Courses", "CourseSixSent");
            DropColumn("dbo.Courses", "CourseSixRec");
            DropColumn("dbo.Courses", "CourseSevenSent");
            DropColumn("dbo.Courses", "CourseSevenRec");
            DropColumn("dbo.Courses", "CourseEightSent");
            DropColumn("dbo.Courses", "CourseEightRec");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseEightRec", c => c.String());
            AddColumn("dbo.Courses", "CourseEightSent", c => c.String());
            AddColumn("dbo.Courses", "CourseSevenRec", c => c.String());
            AddColumn("dbo.Courses", "CourseSevenSent", c => c.String());
            AddColumn("dbo.Courses", "CourseSixRec", c => c.String());
            AddColumn("dbo.Courses", "CourseSixSent", c => c.String());
            AddColumn("dbo.Courses", "CourseFiveRec", c => c.String());
            AddColumn("dbo.Courses", "CourseFiveSent", c => c.String());
            AddColumn("dbo.Courses", "CourseFourRec", c => c.String());
            AddColumn("dbo.Courses", "CourseFourSent", c => c.String());
            AddColumn("dbo.Courses", "CourseThreeRec", c => c.String());
            AddColumn("dbo.Courses", "CourseThreeSent", c => c.String());
            AddColumn("dbo.Courses", "CourseTwoRec", c => c.String());
            AddColumn("dbo.Courses", "CourseTwoSent", c => c.String());
            AddColumn("dbo.Courses", "CourseOneRec", c => c.String());
            AddColumn("dbo.Courses", "CourseOneSent", c => c.String());
            DropColumn("dbo.Courses", "AvgCompTime");
            DropColumn("dbo.Courses", "Question");
            DropColumn("dbo.Courses", "Description");
            DropColumn("dbo.Courses", "Title");
        }
    }
}
