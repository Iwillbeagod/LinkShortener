(function () {
    var module = angular
        .module('app.linkshortener', [
            'app.linkshortener.controllers'
        ]);

    module.config([
        '$routeSegmentProvider',
        moduleConfig
    ]);

    function moduleConfig($routeSegmentProvider) {
        $routeSegmentProvider
            .when('/', 'parent.create')
            .when('/attendance', 'parent.list')
            .segment('parent', {
                templateUrl: '/views/shared/layout',
                controller: 'LayoutController'
            })
            .within()
            .segment('create', {
                templateUrl: '/views/links/create/',
                controller: 'LinkCreateController',
                title: 'Create'
            })
            .segment('students', {
                templateUrl: '/views/links/list/',
                controller: 'LinkListController',
                title: 'List'
            })
    }

    angular.module('app.linkshortener.controllers', []);
})();