namespace CoreX.Gateway.Contracts.Mappers;

internal interface ISymbolMapper
{
    bool TryGetSymbol(int symbolId, out string? symbol);
    bool TryGetId(string symbolString, out int symbolId);

    void Replace(int symbolId, in string symbolString);
    void Remove(int symbolId);
    void Clear();
}