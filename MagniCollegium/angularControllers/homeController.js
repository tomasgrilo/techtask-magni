collegeApp.controller('homeController', function ($scope, serviceController) {

    var main = $scope;

    getCoursesCount();
    getStudentsCount();
    //function getCourses() {
    //    var courses = serviceController.getCourses();
    //    courses.then(function (output) {
    //        main.courses = output.data;
    //    }, function () {
    //        alert("There was an error listing the courses");
    //    });
    //}

    function getCoursesCount() {
        //Controller as parameter
        var courseCount = serviceController.getTotal('Course');
        courseCount.then(function (output) {
            main.courseCount = output.data;
        }, function () {
            alert("There was an error getting the courses count");
        });
    }

    function getStudentsCount() {
        //Controller as parameter
        var studentCount = serviceController.getTotal('Student');
        studentCount.then(function (output) {
            main.studentCount = output.data;
        }, function () {
            alert("There was an error getting the courses count");
        });
    }




});