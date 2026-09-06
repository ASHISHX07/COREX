namespace CoreX.Gateway.Brokers;

internal enum Brokers : byte
{
    Zerodha,
    Fyers,
    Groww,
    Upstox,
    AngelOne
}

internal interface IBrokerAdapter
{
    public Brokers? _brokerId { get; init; }
    public string? _accessToken { get; protected set; }
}