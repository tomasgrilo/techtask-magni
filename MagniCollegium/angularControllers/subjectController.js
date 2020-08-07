collegeApp.controller('subjectController', function ($scope, serviceController) {


    var controller = 'Subject';
    $scope.adding = false;
    $scope.updating = true;

    $scope.toAdd = function () {
        $scope.adding = true;
        $scope.updating = false;
        $scope.name = null;
        $scope.selectedTeacher = null;
        $scope.id = null;
    }

    $scope.toUpdate = function () {
        $scope.adding = false;
        $scope.updating = true;
    }


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


    //The delete class for example could be in serviceController case its always used the same way
    $scope.deleteSubject = function (key) {
        var deleteSubject = serviceController.delete(controller, key);
        deleteSubject.then(function () {
            alert("Successfully deleted!");
            initialize();
        }, function () {
            alert("There was an deleting the subject");
        });
    }

    $scope.updateSubjectRequest = function (model) {
        $scope.id = model.Id;
        $scope.name = model.Name;
        $scope.selectedTeacher = model.Teacher;
        $scope.toUpdate();
    }

    //The update class for example could be in serviceController case its always used the same way
    $scope.updateSubject = function () {
        var subject = {
            Id: $scope.id,
            Name: $scope.name,
            Teacher: $scope.selectedTeacher
        }

        var updateSubject = serviceController.update(controller, subject, subject.Id);
        updateSubject.then(function () {
            alert("Successfully updated!");
            initialize();
        }, function () {
            alert("There was an updating the subject");
        });
        $scope.teachers = null;

    }

    //make an Utils class for this
    function formatDatetime(jsonDate) {
        return new Date(parseInt(jsonDate.substr(6)));
    }

});