collegeApp.controller('subjectController', function ($scope, serviceController) {


    var controller = 'Subject';

    initialize();
    function initialize() {
        var subjects = serviceController.readAll(controller);
        subjects.then(function (output) {
            $scope.subjects = output.data;
        }, function () {
            alert("There was an error listing the subjects");
        });

        var teachers = serviceController.readAll('Teacher');
        teachers.then(function (output) {
            $scope.teachers = output.data;
            for (i = 0; i < $scope.teachers.length; i++) {
                $scope.teachers[i].Birthday = formatDatetime($scope.teachers[i].Birthday);
            }
        }, function () {
            alert("There was an error listing the subjects");
        });
    }

    $scope.addSubject = function () {

        var subject = {
            Name: $scope.name,
            Teacher: $scope.selectedTeacher
        }

        var addSubject = serviceController.create(controller, subject);
        addSubject.then(function () {
            alert("Successfully added!");
            initialize();

        }, function () {
            alert("There was an error adding");
        });
    }


    //make an Utils class for this
    function formatDatetime(jsonDate) {
        return new Date(parseInt(jsonDate.substr(6)));
    }

});