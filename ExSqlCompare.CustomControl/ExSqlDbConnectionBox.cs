using ExSqlCompare.CustomControl.Interfaces.DbConnectionBox;

namespace ExSqlCompare.CustomControl;

public partial class ExSqlDbConnectionBox : UserControl, IExSqlCompareConnectionUserControl
{
    public ExSqlDbConnectionBox()
    {
        InitializeComponent();
    }

    public void Initialize(IExSqlCompareConnectionProperties connectionProperties)
    {
        throw new NotImplementedException();
    }

    public void LoadProperties()
    {
        throw new NotImplementedException();
    }
}