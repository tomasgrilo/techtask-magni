collegeApp.controller('courseController', function ($scope, serviceController) {

    $scope.addCourse = function () {
        var course = {
            name: course.name,
            maxStudents: course.maxStudents
        }

        var addCourse = serviceController.addCourse(course);
        addCourse.then(function () {
            alert("Added with success!");
            course.name = null;
            course.maxStudents = null;
        }, function () {
            alert("There was an adding the course");
        });

    }

});