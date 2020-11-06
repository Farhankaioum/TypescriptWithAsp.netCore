interface IMockRepository<T> {
    create(item: T): void;
    update(updatedItem: T): void;
    delete(deletedItem: T): void;
    getUsers(): Promise<User[]>;
    getUser(id: number): Promise<User>;
}

let url: string = "https://localhost:44384/";

class mockRepository<T> implements IMockRepository<T> {
    getUsers(): Promise<User[]> {
        return fetch(url + 'getUsers')
            .then(res => res.json())
            .then(res => {
                return res as User[]
            })
    }
    getUser(id: number): Promise<User> {
        return fetch(url + 'getUser/' + id)
            .then(res => res.json())
            .then(res => {
                return res as User
            })
    }

    create(item: T): void {
        fetch(url);
    }
    update(updatedItem: T): void {
        throw new Error("Method not implemented.");
    }
    delete(deletedItem: T): void {
        throw new Error("Method not implemented.");
    }

}

interface User {
    id: number,
    name: string,
    email: string,
    password: string,
    confirmPassword: string
}

let repository = new mockRepository<User>();
let users = repository.getUsers();
console.log(users);

function getUserById(): void {
    let searchUserId: number = parseInt((document.getElementById('searchUserId') as HTMLInputElement).value)
    let user = repository.getUser(searchUserId);
    console.log(user);
}


