var App;
(function (App) {
    var RegistrationController = /** @class */ (function () {
        function RegistrationController() {
            console.log('i am in regsiter');
        }
        return RegistrationController;
    }());
    angular.module('app').controller('RegistrationController', RegistrationController);
    var SigninController = /** @class */ (function () {
        function SigninController() {
        }
        SigninController.$inject = ["$state", "$scope", "$rootScope", "LocalStorageService", "AccountService", "WebService"];
        return SigninController;
    }());
    App.SigninController = SigninController;
    var AccountController = /** @class */ (function () {
        function AccountController() {
        }
        return AccountController;
    }());
})(App || (App = {}));
//# sourceMappingURL=AccountControllers.js.map