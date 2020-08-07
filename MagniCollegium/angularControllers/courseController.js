collegeApp.controller('courseController', function ($scope, serviceController) {


    var controller = 'Course';
    $scope.adding = false;
    $scope.updating = true;

    initialize();
    function initialize() {
        $scope.name = null;
        $scope.maxStudents = null;
        $scope.courseId = null;
        var courses = serviceController.readAll(controller);
        courses.then(function (output) {
            $scope.courses = output.data;
        }, function () {
            alert("There was an error listing the courses");
        });
    }

    $scope.toAdd = function () {
        $scope.adding = true;
        $scope.updating = false;
        $scope.name = null;
        $scope.maxStudents = null;
        $scope.courseId = null;
    }

    $scope.toUpdate = function () {
        $scope.adding = false;
        $scope.updating = true;
    }

    $scope.addCourse = function () {

        var course = {
            name: $scope.name,
            maxStudents: $scope.maxStudents
        }

        if ($scope.modelHasErrors(course.name, course.maxStudents)) {
            return;
        }

        var addCourse = serviceController.create(controller, course);
        addCourse.then(function () {
            alert("Successfully added!");
            initialize();
     
        }, function () {
            alert("There was an error adding the course");
        });
    }

    $scope.deleteCourse = function (key) {
        var deleteCourse = serviceController.delete(controller, key);
        deleteCourse.then(function () {
            alert("Successfully deleted!");
            initialize();
        }, function () {
            alert("There was an deleting the course");
        });

    }

    $scope.updateCourseRequest = function (model) {
        $scope.courseId = model.Id;
        $scope.name = model.Name;
        $scope.maxStudents = model.MaxStudents;
        $scope.toUpdate();
    }

    $scope.updateCourse = function () {
        var course = {
            Id: $scope.courseId,
            Name: $scope.name,
            MaxStudents: $scope.maxStudents
        }

        if ($scope.modelHasErrors(course.Name, course.MaxStudents)) {
            return;
        }

        var updateCourse = serviceController.update(controller, course, course.Id);
        updateCourse.then(function () {
            alert("Successfully updated!");
            initialize();
        }, function () {
            alert("There was an deleting the course");
        });
    }

    $scope.modelHasErrors = function (name, maxStudents) {
        if (name == null || maxStudents == null) {
            alert("You must give a name and a max number of students");
            return true;
        }

        if (maxStudents < 0) {
            alert("Max students must be a positive number");
            return true;
        }
    }

});