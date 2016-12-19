namespace WebApiPractice5.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
        public BOOK;
        public someBookId;
        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService) {

            $http.get("api/books").then((res) => {

                this.BOOK = res.data;
            });
        }
        //for the post
        public AddBook(somebook)
        {
            this.$http.post('api/books', somebook).then((res) => {
                this.$state.reload();
            });
            
        }
        //for the delete
        public deleteBook(someBookId)
        {
            this.$http.delete(`api/books/${someBookId}`).then((res) => {
                this.$state.reload();
            });
        }

    }


    export class EditController {
        public book;
        constructor(public $http: ng.IHttpService, public $stateParams: ng.ui.IStateParamsService, public $state: ng.ui.IStateService) {
            $http.get(`/api/books/${$stateParams['id']}`).then((res) => {
                this.book = res.data
            });
        }
        public editBook()
        {
            this.$http.put(`/api/books/${this.$stateParams["id"]}`, this.book).then((res) => {
                this.$state.go('home');
            });
        }

    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
