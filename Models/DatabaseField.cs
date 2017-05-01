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
        public int DbFieldNumber { get; set; }
        public string ColumnName { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public char AuditFlag { get; set; }
        public EmpowerDatabaseType DatabaseType  { get; set; }
        public int? StringSize { get; set; }
        public DateTime LastModified { get; set; }
        public string Picture { get; set; }
        public int? PictureType { get; set; }
        public float? MinValue { get; set; }
        public float? MaxValue { get; set; }
        public string Notes { get; set; }
        public string XmlTag { get; set; }

        public DatabaseField() {}

        public DatabaseField(string column, string table, string description, char auditFlag, 
                             EmpowerDatabaseType databaseType, int? stringSize) 
                        : this(-1, column, table, description, 
                                auditFlag, databaseType, stringSize, null, null, null, null, null, 
                                DateTime.Now, $"{table}.{column}") {}

        public DatabaseField(int dbNumber, string column, string table, string description, char auditFlag, 
                             EmpowerDatabaseType databaseType, int? stringSize, string notes, float? minValue, 
                             float? maxValue, string picture, int? pictureType, DateTime lastModified, string xmlTag)
        {
            DbFieldNumber = dbNumber;
            ColumnName = column;
            TableName = table;
            Description = description;
            AuditFlag = String.IsNullOrEmpty(auditFlag.ToString()) ? 'N' : auditFlag;
            DatabaseType = databaseType;
            StringSize = ValidateStringSize(databaseType, stringSize);
            Notes = notes;
            MinValue = minValue;
            MaxValue = maxValue;
            Picture = picture;
            PictureType = pictureType;
            LastModified = lastModified;
            XmlTag = string.IsNullOrEmpty(xmlTag) ? $"{table}.{column}" : xmlTag;
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
            return $"DBFieldNumber: {DbFieldNumber}{Environment.NewLine}"
            + $"ColumnName: {ColumnName}{Environment.NewLine}"
            + $"TableName: {TableName}{Environment.NewLine}"
            + $"Description: {Description}{Environment.NewLine}"
            + $"AudtiFlag: {AuditFlag}{Environment.NewLine}"
            + $"DatabaseType: {DatabaseType}{Environment.NewLine}"
            + $"StringSize: {StringSize}{Environment.NewLine}"            
            + $"Notes: {Notes}{Environment.NewLine}"
            + $"MinValue: {MinValue}{Environment.NewLine}"
            + $"MaxValue: {MaxValue}{Environment.NewLine}"
            + $"Picture: {Picture}{Environment.NewLine}"
            + $"PictureType: {PictureType}{Environment.NewLine}"
            + $"XmlTag: {XmlTag}{Environment.NewLine}"
            + $"LastModified: {LastModified}{Environment.NewLine}";
        }
    }
}
