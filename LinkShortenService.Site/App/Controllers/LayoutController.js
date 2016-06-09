(function () {
    angular
        .module('app.linkshortener.controllers')
        .controller('LayoutController', [
            '$scope',
            '$routeParams',
            '$routeSegment',
            '$location',
            controller
        ]);

    function controller($scope, $routeParams, $routeSegment, $location) {
        $scope.item = 1;
    };
})();