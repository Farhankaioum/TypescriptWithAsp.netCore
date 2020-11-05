function warnUser(): [string, string, string] {
    let name: string = (document.getElementById('Name') as HTMLInputElement).value;
    let email: string = (document.getElementById('Email') as HTMLInputElement).value;
    let password: string = (document.getElementById('Password') as HTMLInputElement).value;
    return [name, email, password];
}

function printMe(): void {
    let data = warnUser();
    if (data[0] == '')
        console.log('Name is empty');

    console.log(data[0], data[1], data[2])
}

function checkValidation(): boolean {
    let name: string = (document.getElementById('Name') as HTMLInputElement).value;
    let email: string = (document.getElementById('Email') as HTMLInputElement).value;
    let password: string = (document.getElementById('Password') as HTMLInputElement).value;
    let confirmPassword: string = (document.getElementById('ConfirmPassword') as HTMLInputElement).value;

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
