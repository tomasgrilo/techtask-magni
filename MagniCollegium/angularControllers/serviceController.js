collegeApp.service('serviceController', function ($http) {

    this.readAll = function (controller) {
        return $http.get(`/${controller}/ReadAll`);
    }

    this.insert = function (controller, course) {
        var request = $http({
            method: 'post',
            url: `/${controller}/Insert`,
            data: course
        });

        return request;
    }

    this.getTotal = function (controller) {
        return $http.get(`/${controller}/GetTotal`);
    }


});