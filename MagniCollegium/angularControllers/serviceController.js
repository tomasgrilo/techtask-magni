collegeApp.service('serviceController', function ($http) {

    this.getCourses = function () {
        return $http.get("/Course/GetCourses");
    }

    this.addCourse = function (course) {
        var request = $http({
            method: 'post',
            url: '/Course/InsertCourse',
            data: course
        });

        return request;
    }
});