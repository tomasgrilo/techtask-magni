collegeApp.controller('gradeController', function ($scope, $http, serviceController) {


    var controller = 'Grade';

    this.getAverageGrade() = function () {
        var request = $http.get(`/${controller}/GetAverageGrade`);
        request.then(function () {
            $scope.averageGrade = output.data;
        }, function () {
            alert("There was an adding the course");
        });
    }
 
});