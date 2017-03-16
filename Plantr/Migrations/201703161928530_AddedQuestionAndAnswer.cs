namespace Plantr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQuestionAndAnswer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionOne = c.String(),
                        QuestionTwo = c.String(),
                        QuestionThree = c.String(),
                        QuestionFour = c.String(),
                        QuestionFive = c.String(),
                        QuestionSix = c.String(),
                        QuestionSeven = c.String(),
                        QuestionEight = c.String(),
                        QuestionNine = c.String(),
                        QuestionTen = c.String(),
                        QuestionEleven = c.String(),
                        QuestionTweleve = c.String(),
                        QuestionThirteen = c.String(),
                        QuestionFourteen = c.String(),
                        QuestionFifteen = c.String(),
                        QuestionSixteen = c.String(),
                        QuestionSeventeen = c.String(),
                        QuestionEighteen = c.String(),
                        QuestionNineteen = c.String(),
                        QuestionTwenty = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnswerOne = c.String(),
                        AnswerTwo = c.String(),
                        AnswerThree = c.String(),
                        AnswerFour = c.String(),
                        AnswerFive = c.String(),
                        AnswerSix = c.String(),
                        AnswerSeven = c.String(),
                        AnswerEight = c.String(),
                        AnswerNine = c.String(),
                        AnswerTen = c.String(),
                        AnswerEleven = c.String(),
                        AnswerTwelve = c.String(),
                        AnswerThirteen = c.String(),
                        AnswerFourteen = c.String(),
                        AnswerFifteen = c.String(),
                        AnswerSixteen = c.String(),
                        AnswerSeventeen = c.String(),
                        AnswerEighteen = c.String(),
                        AnswerNineteen = c.String(),
                        AnswerTwenty = c.String(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropIndex("dbo.Questions", new[] { "Course_Id" });
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
        }
    }
}
