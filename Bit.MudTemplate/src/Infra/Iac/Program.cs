using Pulumi;
using MudTemplate.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
