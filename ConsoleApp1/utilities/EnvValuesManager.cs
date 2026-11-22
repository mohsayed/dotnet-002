using System;

namespace ConsoleApp1.utilities;

public static class EnvValuesManager
{
    public static string? GetEnv(string key)
    {
        var KeyValue = Environment.GetEnvironmentVariable(key,EnvironmentVariableTarget.Machine);
        
        //Environment.GetEnvironmentVariable(key,EnvironmentVariableTarget.User);
        //Environment.GetEnvironmentVariable(key,EnvironmentVariableTarget.Process);
        
        return KeyValue;   
    }
}
