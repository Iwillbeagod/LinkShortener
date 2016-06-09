(function () {
    angular
		.module('app.resources')
		.factory('$linkResource', [
			'$resource',
			resource
		]);

    function resource($resource, data) {
        return $resource('/api/links', data, {
            'get': {
                url: '/api/links/?page=:page&pageSize=:pageSize',
                method: 'GET',
                isArray: true
            },
            'post': {
                url: '/api/links/?originUrl=:originUrl',
                method: 'POST'
            }
        });
    }
})();