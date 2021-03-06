using System;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Hosting;

class Program
{
    static Task<int> Main(string[] args)
        => new HostBuilder()
        .RunCommandLineApplicationAsync<Program>(args);

    [Option]
    public int Port { get; } = 8080;

    private IHostEnvironment _env;

    public Program(IHostEnvironment env)
    {
        _env = env;
    }

    private void OnExecute()
    {
        Console.WriteLine($"Starting on port {Port}, env = {_env.EnvironmentName}");
    }
}
