using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SpartanWarsTool.dbOperate
{
    public class DB_mysteryData
    {
        private DBOperator dbo;
        public DB_mysteryData()
        {
            dbo = new DBOperator();
        }


        private string difficulty;
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        private string level;
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public DataSet Select(DB_mysteryData entity)
        {
            StringBuilder sbSql = new StringBuilder();
            dbo.RemoveAllParameters();

            sbSql.Append(" select soldier_type,soldier_count from mysteryData ");
            sbSql.Append(" where 1 = 1 ");

            if (!string.IsNullOrEmpty(entity.difficulty))
            {
                sbSql.Append(" and difficulty = @difficulty ");
                dbo.AddParameter("@difficulty", entity.difficulty);
            }
            if (!string.IsNullOrEmpty(entity.level))
            {
                sbSql.Append(" and mystery_level = @level ");
                dbo.AddParameter("@level", entity.level);
            }
            if (!string.IsNullOrEmpty(entity.type))
            {
                sbSql.Append(" and soldier_type = @soldier_type ");
                dbo.AddParameter("@soldier_type", entity.type);
            }

            return dbo.Select(sbSql.ToString());
        }

    }
}
