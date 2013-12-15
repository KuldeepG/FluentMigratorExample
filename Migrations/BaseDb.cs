using FluentMigrator;

namespace Migrations
{
    [Migration(1)]
    public class BaseDb : Migration
    {
        public override void Up()
        {
            Execute.Sql("CREATE TABLE subject (" +
                        "id MEDIUMINT NOT NULL AUTO_INCREMENT, " +
                        "name VARCHAR(20) NOT NULL, " +
                        "PRIMARY KEY (id));");    
        }

        public override void Down()
        {
            Execute.Sql("Drop table subject;");
        }
    }
}
