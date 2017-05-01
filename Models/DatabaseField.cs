using System;

namespace Voltron.Client.Models
{
    public enum EmpowerDatabaseType : int {
        DbString = 1,
        DbInteger = 2,
        DbDouble = 3,
        DbBoolean = 4,
        DbDate = 5,
        DbDateTime = 6,
        DbMemo = 7,
        DbTime = 8,
        DbCurrency = 9,
        DbPercent = 10,
        DbBlob = 11,
        DbXml = 12,
        DbOther = 13
    }
    public class DatabaseField
    {
        public 
        public string ColumnName { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public char AuditFlag { get; set; }
        public EmpowerDatabaseType DatabaseType  { get; set; }
        public int? StringSize { get; set; }
        public DateTime LastModified { get; set; }
        public string Picture { get; set; }
        public int PictureType { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public string Notes { get; set; }
        public string XmlTag { get; set; }

        public DatabaseField()
        {

        }

        public DatabaseField(string column, string table, string description, char auditFlag, 
                             EmpowerDatabaseType databaseType, int? stringSize)
        {
            this.ColumnName = column;
            this.TableName = table;
            this.Description = description;
            this.AuditFlag = String.IsNullOrEmpty(auditFlag.ToString()) ? 'N' : auditFlag;
            this.DatabaseType = databaseType;
            this.StringSize = ValidateStringSize(databaseType, stringSize);
        }

        private int? ValidateStringSize(EmpowerDatabaseType type, int? size)
        {
            if(type == EmpowerDatabaseType.DbString && (!size.HasValue || size.Value < 1))
            {
                throw new Exception("You must provide a string size when selecting a String database type");
            }
            return size;
        }

        public override string ToString()
        {
            return $"ColumnName: {ColumnName}{Environment.NewLine}"
            + $"TableName: {TableName}{Environment.NewLine}"
            + $"Description: {Description}{Environment.NewLine}"
            + $"AudtiFlag: {AuditFlag}{Environment.NewLine}"
            + $"DatabaseType: {DatabaseType}{Environment.NewLine}"
            + $"StringSize: {StringSize?.ToString() ?? "N/A"}{Environment.NewLine}";
        }
    }
}
