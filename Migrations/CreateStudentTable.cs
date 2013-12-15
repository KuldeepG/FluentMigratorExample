using FluentMigrator;

namespace Migrations
{
    [Migration(2)]
    public class CreateStudentTable : Migration
    {
        public override void Up()
        {
            Create.Table("Student")
                .WithColumn("Id").AsInt16().PrimaryKey()
                .WithColumn("FirstName").AsFixedLengthString(25)
                .WithColumn("LastName").AsFixedLengthString(25);
        }

        public override void Down()
        {
            Delete.Table("Student");
        }
    }
}
