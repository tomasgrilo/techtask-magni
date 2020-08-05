collegeApp.controller('mainController', function ($scope, serviceController) {

    var main = $scope;

    getCourses();


    function getCourses() {
        var courses = serviceController.getCourses();
        courses.then(function (output) {
            main.courses = output.data;
        }, function () {
            alert("There was an error listing the courses");
        });
    }


    main.addCourse = function () {
        var course = {
            name: main.name,
            maxStudents: main.maxStudents
        }

        var addCourse = serviceController.addCourse(course);
        addCourse.then(function () {
            getCourses();
            alert("Added with success!");
            main.name = null;
            main.maxStudents = null;
        }, function () {
             alert("There was an adding the course");
        });

    }

});