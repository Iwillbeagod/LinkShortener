(function () {
    angular
        .module('app.linkshortener.controllers')
        .controller('LinkListController', [
            '$scope',
            '$location',
            '$http',
            '$routeParams',
            '$routeSegment',
            '$linkResource',
            controller
        ]);

    function controller($scope, $location, $http, $routeParams, $routeSegment, $linkResource) {

        $scope.page = 1;
        $scope.pageSize = 20;

        $scope.getLinks = function () {
            $linkResource.get({ page: $scope.page, pageSize : $scope.pageSize }).$promise.then(function (response) {
                if (response.status == 200) {
                    $scope.links = response.data;
                }
            }, function (response) {
                //fail logic goes here
            });
        }

        $scope.getLinks();
    };
})();