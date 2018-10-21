namespace MiniORMProject.Attributes
{
    using System;

    public class EntityAttribute : Attribute
    {
        public string TableName { get; set; }  
    }
}
