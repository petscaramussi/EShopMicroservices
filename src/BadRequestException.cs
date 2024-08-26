﻿namespace BuildingBlocks.Exception;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, string details) : base(message)
    {
    }

    public string? Details { get; }
}