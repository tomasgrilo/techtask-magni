collegeApp.service('serviceController', function ($http) {

    
    this.read = function (controller, key) {
        var request = $http({
            method: 'get',
            url: `/${controller}/Read`,
            data: key
        });

        return request;
    }

    this.readAll = function (controller) {
        return $http.get(`/${controller}/ReadAll`);
    }

    this.getTotal = function (controller) {
        return $http.get(`/${controller}/GetTotal`);
    }

    this.create = function (controller, model) {
        var request = $http({
            method: 'post',
            url: `/${controller}/Create`,
            data: model
        });

        return request;
    }


    this.delete = function (controller, key) {
        var request = $http({
            method: 'post',
            url: `/${controller}/Delete`,
            data: { key }
        });

        return request;
    }

    this.update = function (controller, model, key) {
        var request = $http({
            method: 'post',
            url: `/${controller}/Update`,
            data: { model, key }
        });

        return request;
    }


    this.getAverageGrade = function () {
        var request = $http.get('/Grade/GetAverageGrade');
        request.then(function () {
            $scope.averageGrade = output.data;
        }, function () {
            alert("There was an adding the course");
        });
        return request;
    }


});