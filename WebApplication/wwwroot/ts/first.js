var url = "https://localhost:44384/";
var mockRepository = /** @class */ (function () {
    function mockRepository() {
    }
    mockRepository.prototype.getUsers = function () {
        return fetch(url + 'getUsers')
            .then(function (res) { return res.json(); })
            .then(function (res) {
            return res;
        });
    };
    mockRepository.prototype.getUser = function (id) {
        return fetch(url + 'getUser/' + id)
            .then(function (res) { return res.json(); })
            .then(function (res) {
            return res;
        });
    };
    mockRepository.prototype.create = function (item) {
        fetch(url);
    };
    mockRepository.prototype.update = function (updatedItem) {
        throw new Error("Method not implemented.");
    };
    mockRepository.prototype.delete = function (deletedItem) {
        throw new Error("Method not implemented.");
    };
    return mockRepository;
}());
var repository = new mockRepository();
var users = repository.getUsers();
console.log(users);
function getUserById() {
    var searchUserId = parseInt(document.getElementById('searchUserId').value);
    var user = repository.getUser(searchUserId);
    console.log(user);
}
//# sourceMappingURL=first.js.map