var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
    $scope.records = [];
    var result = $http.get("/Urls/GetUrls");
    result.success(function (data) {
        $scope.records = data;
        $scope.title = $scope.records.length == 0 ? "У вас пока нет ссылок" : "Список всех моих ссылок"
        $.each($scope.records, (i, elem) => {
            elem.CreationDate = new Date(parseInt(elem.CreationDate.replace("/Date(", "").replace(")/", ""), 10));
        })
    });
});