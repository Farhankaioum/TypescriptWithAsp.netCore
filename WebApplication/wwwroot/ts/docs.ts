interface SquareConfig {
    color?: string;
    width?: number;
    [propName: string]: any;
}

function createSquare(config: SquareConfig): { color: string; area: number } {
    return { color: config.color || "red", area: config.width ? config.width * config.width : 20 };
}

let squareOptions = { colour: "red" };
let mySquare = createSquare(squareOptions);


interface StringArray {
    [index: number]: string;
}


