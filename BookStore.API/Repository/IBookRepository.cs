﻿using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetAllBooksByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
    }
}
