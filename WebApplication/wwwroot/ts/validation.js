function warnUser() {
    var name = document.getElementById('Name').value;
    var email = document.getElementById('Email').value;
    var password = document.getElementById('Password').value;
    return [name, email, password];
}
function printMe() {
    var data = warnUser();
    if (data[0] == '')
        console.log('Name is empty');
    console.log(data[0], data[1], data[2]);
}
function checkValidation() {
    var name = document.getElementById('Name').value;
    var email = document.getElementById('Email').value;
    var password = document.getElementById('Password').value;
    var confirmPassword = document.getElementById('ConfirmPassword').value;
    if (name == '' || email == '' || password == '' || confirmPassword == '') {
        return false;
    }
    if (email.indexOf('@') <= 0) {
        return true;
    }
    if (password != confirmPassword)
        return false;
    return true;
}
//# sourceMappingURL=validation.js.map