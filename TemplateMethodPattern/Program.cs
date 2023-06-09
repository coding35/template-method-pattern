﻿using System.Diagnostics;
using TemplateMethodPattern.Abstract;
using TemplateMethodPattern.Concrete;

Logger logger = new FileLogger();

for (int i = 0; i < 25; i++)
{
    logger.Log(new LoggerMessage("Main", $"Iteration {i}", null, TraceLevel.Info));
}

logger = new UDPLogger();

logger.ToggleConsoleToTerminal(true);

for (int i = 0; i < 25; i++)
{
    logger.Log(new LoggerMessage("Main", $"Iteration {i}", null, TraceLevel.Info));
}

logger.ToggleConsoleToTerminal(false);

for (int i = 0; i < 25; i++)
{
    logger.Log(new LoggerMessage("Main", $"Iteration {i}", null, TraceLevel.Info));
}
