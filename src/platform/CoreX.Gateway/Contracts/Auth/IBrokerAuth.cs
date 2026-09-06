namespace CoreX.Gateway.Contracts.Auth;

internal enum Brokers : byte
{
    Zerodha,
    Upstox,
    AngelOne,
    Fyers
}

internal interface IBrokerAuthenticator
{
    string BrokerId { get; init; }
    bool IsAuthenticated { get; }

    Task AuthenticateUser();
    Task<bool> ValidateUser();
}