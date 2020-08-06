collegeApp.service('serviceController', function ($http) {

    this.read = function (controller, id) {
        var request = $http({
            method: 'get',
            url: `/${controller}/Read`,
            data: id
        });
    }

    this.readAll = function (controller) {
        return $http.get(`/${controller}/ReadAll`);
    }

    this.create = function (controller, course) {
        var request = $http({
            method: 'post',
            url: `/${controller}/Create`,
            data: course
        });

        return request;
    }

    this.getTotal = function (controller) {
        return $http.get(`/${controller}/GetTotal`);
    }


});