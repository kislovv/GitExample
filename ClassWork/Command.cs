using System;

namespace ClassWork;

public abstract record Command;

public record CreateTask(string Title, int Priority) : Command;
public record CompletedTask(Guid TaskId) : Command;
public record DeleteTask(Guid TaskId, bool Force) : Command;