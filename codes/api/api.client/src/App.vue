<script>
  import axios from 'axios';

  var api = "/api/books";

  export default {
    data() {
      return {
        books: []
      }
    },
    methods: {
      async fetchBooks() {
        const response = await axios.get(api);
        this.books = response.data;
        console.log(this.books);
      },
      async deleteBook(id) {
        if (confirm('Are you sure you want to delete this book?')) {
          await axios.delete(`${api}/${id}`);
          this.fetchBooks();
        }
      }
    },
    created() {
      this.fetchBooks();
    }
  }
</script>

<template>
  <div class="container text-center mt-5">
    <table class="table table-hover table-primary">
      <thead class="thead-dark">
        <tr>
          <th colspan="6" class="text-danger text-uppercase">
            <h3>Book List</h3>
          </th>
        </tr>
        <tr>
          <th class="text text-success">Id</th>
          <th class="text text-success">Title</th>
          <th class="text text-success">Price</th>
          <th class="text text-success">Quantity</th>
          <th class="text text-success">Cover</th>
          <th class="text text-success">Menu</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="book in books" :key="book.bookId">
          <th>{{ book.bookId }}</th>
          <td>{{ book.bookTitle }}</td>
          <td>${{ book.bookPrice }}</td>
          <td>{{ book.bookQuantity }}</td>
          <td>
            <img :src="book.bookCover" width="150" height="200" />
          </td>
          <td>
            <button @click="deleteBook(book.bookId)"
                    class="btn btn-danger">
              Delete
            </button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<style>
  .table th, .table td {
    vertical-align: middle;
  }

  .table img {
    border-radius: 5px;
  }
</style>
