namespace consulting_information_rickmorty.api.Response
{
    internal class PageResponse<T>
    {
        public PageInfoResponse Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
