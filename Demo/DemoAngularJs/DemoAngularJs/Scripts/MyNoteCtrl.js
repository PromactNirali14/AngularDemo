app.controller("MyNoteCtrl", function ($scope) {
    $scope.message = "Enter ur text here";
    $scope.left = function () { return 160 - $scope.message.length; };
    $scope.clear = function () { $scope.message = ""; };
    $scope.save = function () { alert(" Just demo Application ...Note Saved"); };
});