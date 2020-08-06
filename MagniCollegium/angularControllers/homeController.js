collegeApp.controller('homeController', function ($scope, serviceController) {

    var main = $scope;

    getCoursesCount();
    getStudentsCount();
    getTeachersCount();
    getSubjectsCount();


    function getCoursesCount() {
        var courseCount = serviceController.getTotal('Course');
        courseCount.then(function (output) {
            main.courseCount = output.data;
        }, function () {
            alert("There was an error getting the courses count");
        });
    }

    function getStudentsCount() {
        var studentCount = serviceController.getTotal('Student');
        studentCount.then(function (output) {
            main.studentCount = output.data;
        }, function () {
            alert("There was an error getting the courses count");
        });
    }


    function getTeachersCount() {
        var teacherCount = serviceController.getTotal('Teacher');
        teacherCount.then(function (output) {
            main.teacherCount = output.data;
        }, function () {
            alert("There was an error getting the teachers count");
        });
    }

    function getSubjectsCount() {
        var subjectCount = serviceController.getTotal('Subject');
        subjectCount.then(function (output) {
            main.subjectCount = output.data;
        }, function () {
            alert("There was an error getting the subjects count");
        });
    }

    function getAverageGrade() {

    }


});