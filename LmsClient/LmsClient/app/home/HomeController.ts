module App {

    class HomeController {
        static $inject = ["$state", "$scope", "$rootScope", "LocalStorageService"];
        stateService: angular.ui.IStateService;
        isSignIn: boolean;
        user: UserInfo;

        constructor(stateService: angular.ui.IStateService,

            scope: angular.IScope, rootScope: angular.IRootScopeService,
            storageService: LocalStorageService) {

            console.log('i am in home');
            var self = this;
            let userInfo = storageService.get(LocalStorageKeys.UserInfo) as UserInfo;
            if (userInfo) {
                this.signedInSuccessfully();
            } else {
                this.signedOutSuccessfully();

            }

            rootScope.$on("signedOut", () => { self.signedOutSuccessfully(); });
        }

        message: string;


        signedOutSuccessfully(): void {
            this.isSignIn = false;
            this.message = "";
        }


        signedInSuccessfully(): void {
            let self = this;
            self.isSignIn = true;
            this.message = new Date().toDateString();
        }
;
    }
    angular.module('app').controller("HomeController", HomeController as any);
}