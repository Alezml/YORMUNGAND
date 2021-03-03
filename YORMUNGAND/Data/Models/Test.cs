using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ITimer
{
    string Time { get; }
}
public class Timer : ITimer
{
    public Timer()
    {
        Time = System.DateTime.Now.ToString("hh:mm:ss");
    }
    public string Time { get; }
}
public class TimeService
{
    private ITimer _timer;
    public TimeService(ITimer timer)
    {
        _timer = timer;
    }
    public string GetTime()
    {
        return _timer.Time;
    }
}
public class TimerMiddleware
{
    private readonly RequestDelegate _next;
    TimeService _timeService;
    public TimerMiddleware(RequestDelegate next, TimeService timeService)
    {
        _next = next;
        _timeService = timeService;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.WriteAsync($"Текущее время: {_timeService?.GetTime()}");
    }
}
