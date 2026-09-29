using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW_T04_28_09_2026;

public enum LogLevel
{
    Debug,
    Info,
    Warning,
    Error
}

internal class Logger
{
    private int recordsNumber = 0;

    public Logger()
    {

    }
    // Formats:
    // [DateTime] : [Thread ID] : [Process Id] : [Log levels] | [Functionality] : [Method] - "Some error"
    // 23.06.2025 19:14:53 : [UI] : [Debug]     | Music playback : StartPlayback(...) - Playback was started with no errors. 
    // 23.06.2025 19:14:58 : [UI] : [Warning]   | Music playback : GetNetxBufferPart(...) - Cannot load all the bytes data in time. Method completed with timout. 

    // 1. Playback was started with no errors. 
    // 2. Playback was started with no errors.

    public void LogData(LogLevel logLevel, string message)
    {
        string functionality = "functionality";
        string method = "method";
        string data = $"{DateTime.Now.ToString()} : [{logLevel}] | {functionality} : {method} - {message}";
        Debug.WriteLine(data);
        //File.WriteAllLines("Path", new string[] { message });

        recordsNumber++;
    }
}
