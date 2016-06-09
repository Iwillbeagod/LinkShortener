(function () {
    angular
        .module('app.linkshortener.controllers')
        .controller('LinkCreateController', [
            '$scope',
            '$location',
            '$http',
            '$routeParams',
            '$routeSegment',
            '$linkResource',
            controller
        ]);

    function controller($scope, $location, $http, $routeParams, $routeSegment, $linkResource) {

        $scope.createLink = function () {
            $linkResource.post({ originUrl : $scope.originUrl }).$promise.then(function (response) {
                if (response.status == 200) {
                    $scope.shortUrl = response.data;
                }
            }, function (response) {
                //fail logic goes here
            });
        }

        $scope.getLinks();
    };
})();