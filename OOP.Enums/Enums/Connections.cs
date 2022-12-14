using System.ComponentModel.DataAnnotations;
namespace OOP.Enums.Enums;

public enum Connections
{
    [Display(Name = "MsSql Connection String")]
    MsSql,

    [Display(Name = "MySql Connection String")]
    MySql,

    [Display(Name = "OracleSql Connection String")]
    Oracle
}
