collegeApp.service('serviceController', function ($http) {

    this.getCourses = function () {
        return $http.get("/Course/ReadAll");
    }

    this.addCourse = function (course) {
        var request = $http({
            method: 'post',
            url: '/Course/Insert',
            data: course
        });

        return request;
    }
});