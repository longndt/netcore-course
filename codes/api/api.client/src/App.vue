<script>
    var api = "/api/books";

    export default {
        data() {
            return {
                books: []
            }
        },
        methods: {
            async fetchBooks() {
                const response = await fetch(api);
                this.books = await response.json();
                console.log(this.books);
            },
            async deleteBook(id) {
                await fetch(api + "/" + id, {
                    method: 'DELETE'
                });
                this.fetchBooks();
            }
        },
        created() {
            this.fetchBooks();
        }
    }
</script>

<template>
    <div class="container text-center">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th colspan="6"  class="text text-primary">
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
                                class="btn btn-danger"
                                onclick="return confirm('Are you sure to delete this book ?'">
                            Delete
                        </button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>