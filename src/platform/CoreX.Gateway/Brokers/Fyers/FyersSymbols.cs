using CoreX.Gateway.Contracts.Mappers;

namespace CoreX.Gateway.Brokers;

internal class FyersSymbols : ISymbolMapper
{
    private static BiDictionary<int, string> _symbols = new();

    public bool TryGetSymbol(int symbolId, out string? symbol)
    {
        bool exists = _symbols.TryGetValue(symbolId, out symbol);
        return exists;
    }

    public bool TryGetId(string symbolString, out int symbolId)
    {
        bool exists = _symbols.TryGetKey(symbolString, out symbolId);
        return exists;
    }

    public void Replace(int symbolId, in string symbol) =>
        _symbols.Replace(symbolId, symbol);

    public void Remove(int symbolId)=>
        _symbols.Remove(symbolId);

    public void Clear() =>
        _symbols.Clear();
}