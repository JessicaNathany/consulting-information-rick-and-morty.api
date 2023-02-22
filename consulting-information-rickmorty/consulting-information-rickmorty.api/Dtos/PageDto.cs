namespace consulting_information_rickmorty.api.Dtos
{
    internal class PageDto<T>
    {
        public PageInfoDto Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
