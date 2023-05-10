using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity
{
    // Create the PaginatedList class
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        // The CreateAsync method is used to create the PaginatedList<T>.
        // A constructor can't create the PaginatedList<T> object; constructors can't run asynchronous code.
        public static async Task<PaginatedList<T>> CreateAsync
            (IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToListAsync();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);

        }
    }
}
