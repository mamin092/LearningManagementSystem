var App;
(function (App) {
    var HomeController = /** @class */ (function () {
        function HomeController(stateService, scope, rootScope, storageService) {
            console.log('i am in home');
            var self = this;
            var userInfo = storageService.get(App.LocalStorageKeys.UserInfo);
            if (userInfo) {
                this.signedInSuccessfully();
            }
            else {
                this.signedOutSuccessfully();
            }
            rootScope.$on("signedOut", function () { self.signedOutSuccessfully(); });
        }
        HomeController.prototype.signedOutSuccessfully = function () {
            this.isSignIn = false;
            this.message = "";
        };
        HomeController.prototype.signedInSuccessfully = function () {
            var self = this;
            self.isSignIn = true;
            this.message = new Date().toDateString();
        };
        ;
        HomeController.$inject = ["$state", "$scope", "$rootScope", "LocalStorageService"];
        return HomeController;
    }());
    angular.module('app').controller("HomeController", HomeController);
})(App || (App = {}));
//# sourceMappingURL=HomeController.js.map