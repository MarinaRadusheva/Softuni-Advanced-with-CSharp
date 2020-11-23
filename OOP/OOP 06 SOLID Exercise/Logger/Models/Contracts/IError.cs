namespace Logger.Models.Contracts
{
    using global::Logger.Models.Enumerations;
    using System;
    public interface IError
    {
        public DateTime Date { get; }
        public string Message { get; }
        public Level Level { get; }
    }
}