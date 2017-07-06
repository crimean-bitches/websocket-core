namespace WebSocketCore.Net
{
    internal enum InputChunkState
    {
        None,
        Data,
        DataEnded,
        Trailer,
        End
    }
}