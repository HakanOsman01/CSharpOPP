﻿
namespace CommandPattern.Models
{
    using Core.Contracts;

    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
