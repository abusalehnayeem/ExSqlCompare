namespace ExSqlCompare.CustomControl.Interfaces.DbConnectionBox;

//copy from: https://github.com/kjbartel/ConnectionDialog
public interface IExSqlCompareConnectionProperties
{
    bool IsComplete { get; }
    bool IsExtensible { get; }
    object this[string propertyName] { get; set; }
    void Add(string propertyName);
    bool Contains(string propertyName);
    void Parse(string s);
    event EventHandler PropertyChanged;
    void Remove(string propertyName);
    void Reset();
    void Reset(string propertyName);
    void Test();
    string ToDisplayString();
    string ToFullString();
}