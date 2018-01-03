module App {

    export 
        class UserInfo {
        token: string;
        userName: string;
        landingRoute: string;
        resource: string[];
        requestId: string;
    }


    export 
        class RegisterRequest {

        email: string;
        password: string;
        confirmPassword: string;
    }


    export class AccountService {

        baseRepository: WebService;
        q: angular.IQService;
        commandUrl: string;
        subUrl: string;
        strorageService: LocalStorageService;

        static $inject = ["WebService", "$q", "LocalStorageService"];
        constructor(baseRepository: WebService, q: angular.IQService, storageService: LocalStorageService) {

            this.baseRepository = baseRepository;
            this.q = q;
            this.strorageService = storageService;
        }


        signin(username: string, password: string): angular.IPromise<any> {

            var self = this;
            var deferred = self.q.defer();

            let successCallback = function (response) {

                console.log('AccountService successCallback');
                let info: UserInfo = new UserInfo();
                info.landingRoute = response.data.landingRoute;
                info.userName = response.data.userName;
                self.strorageService.save(LocalStorageKeys.UserInfo, info);
                deferred.resolve(response.data);


            };

            let errorCallback = function (response) {
                deferred.reject(response);
            };

            var data = `username=${username}&password=${password}&grant_type=password`;
            console.log('AccountService signin');
            self.baseRepository.postUrlencodedForm("http://localhost:11620/", data).then(successCallback, errorCallback);
            return deferred.promise;

        }
    }
    angular.module('app').service("AccountService", AccountService);
}