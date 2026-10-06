using MudBlazor;

namespace afya_admin.Components;

public static class Ui
{
    public static string FundoSuave(Color cor) => cor switch
    {
        Color.Primary => "bg-primary-lighten-5",
        Color.Secondary => "bg-secondary-lighten-5",
        Color.Info => "bg-info-lighten-5",
        Color.Success => "bg-success-lighten-5",
        Color.Warning => "bg-warning-lighten-5",
        Color.Error => "bg-error-lighten-5",
        _ => "bg-grey-lighten-4"
    };
}