var App;
(function (App) {
    var CoursesController = /** @class */ (function () {
        function CoursesController() {
            console.log('hi. i am in CourseController');
            this.message = "hi.hi.hi";
        }
        return CoursesController;
    }());
    App.CoursesController = CoursesController;
    angular.module('app').controller("CoursesController", CoursesController);
})(App || (App = {}));
//# sourceMappingURL=CoursesController.js.map