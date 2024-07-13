namespace BookStore.Data.dtos
{
    public class BookDto
    {
        public record NewBookDto(
            string Name,
            int Pages,
            decimal Price
            );
    }
}
