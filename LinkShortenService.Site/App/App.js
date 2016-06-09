(function () {
    angular
        .module('app', [
            /*
             * Angular modules
             */
			'ngRoute',
			'ngAnimate',
			'ngResource',
            'view-segment',
			'route-segment',

             /*
              * Utility modules
              */
            'app.resources',

            /*
             * Application modules
             */
			'app.linkshortener',
        ])
		.config([
			'$locationProvider',
			'$routeProvider',
			'$routeSegmentProvider',
            config
		])
		.run([
            run
		]);

    function config($locationProvider, $routeProvider, $routeSegmentProvider) {
        $locationProvider.html5Mode(false);
        $routeSegmentProvider.options.autoLoadTemplates = true;
        $routeProvider.otherwise({
            redirectTo: '/'
        });
    }

    function run() {
    }
})();