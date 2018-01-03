var App;
(function (App) {
    var UserInfo = /** @class */ (function () {
        function UserInfo() {
        }
        return UserInfo;
    }());
    App.UserInfo = UserInfo;
    var RegisterRequest = /** @class */ (function () {
        function RegisterRequest() {
        }
        return RegisterRequest;
    }());
    App.RegisterRequest = RegisterRequest;
    var AccountService = /** @class */ (function () {
        function AccountService(baseRepository, q, storageService) {
            this.baseRepository = baseRepository;
            this.q = q;
            this.strorageService = storageService;
        }
        AccountService.prototype.signin = function (username, password) {
            var self = this;
            var deferred = self.q.defer();
            var successCallback = function (response) {
                console.log('AccountService successCallback');
                var info = new UserInfo();
                info.landingRoute = response.data.landingRoute;
                info.userName = response.data.userName;
                self.strorageService.save(App.LocalStorageKeys.UserInfo, info);
                deferred.resolve(response.data);
            };
            var errorCallback = function (response) {
                deferred.reject(response);
            };
            var data = "username=" + username + "&password=" + password + "&grant_type=password";
            console.log('AccountService signin');
            self.baseRepository.postUrlencodedForm("http://localhost:11620/", data).then(successCallback, errorCallback);
            return deferred.promise;
        };
        AccountService.$inject = ["WebService", "$q", "LocalStorageService"];
        return AccountService;
    }());
    App.AccountService = AccountService;
    angular.module('app').service("AccountService", AccountService);
})(App || (App = {}));
//# sourceMappingURL=AccountService.js.map