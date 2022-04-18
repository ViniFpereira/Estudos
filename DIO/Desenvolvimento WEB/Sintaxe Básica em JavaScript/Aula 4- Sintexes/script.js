var jogador1 = 3;
var jogador2 = 0;

var placar;

console.log("---------------------------")
console.log("Operador condicional  ? ");
console.log("");


(jogador1 != -1) && (jogador2 != -1) ? console.log("Os jogares sao validos"):
    console.log("Os jogares sao invalidos");


console.log("---------------------------")
console.log("Condição com If, Else IF e Else");
console.log("");
if (jogador1 > 0 && jogador2 == 0) {
    console.log("jogador 1 marcou " +
        jogador1 +
        " gols ")
    placar = jogador1 > jogador2;
} else
if (jogador2 > 0 && jogador1 == 0) {
    console.log("jogador 2 marcou " +
        jogador2 +
        " gols ")
    placar = jogador2 > jogador1;
} else {

    console.log("Ninguem marcou gol")
}

console.log("---------------------------")
console.log("Switch")
console.log("");

switch (placar) {
    case placar = jogador1 > jogador2:
        console.log("jogador 1 ganhou do jogador 2")
        break
    case placar = jogador2 > jogador1:
        console.log("jogador 2 ganhou do jogador 1")
        break
    default:
        console.log("Ninguem ganhou o jogo, Empate")

}


console.log("---------------------------")
console.log("FOR")
console.log("");


let array = ['valor1', 'valor2', 'valor3', 'valor4', 'valor5'];
let object = { propriedade1: 'valor1', propriedade2: 'valor2', propriedade3: 'valor3', };

for (let indice = 0; indice < array.length; indice++) {
    console.log(indice);
    // imprime o array pelo indice COMO OBJETO, começando pelo 0 (total 5)
}
console.log("---------------------------")
console.log("FOR IN")
console.log("");

for (let i in array) {
    console.log(i);
    // imprime o array pelo indice COMO STRING,  começando pelo 0 (total 5)
}

console.log("---------------------------")
console.log("FOR IN OBJECT")
console.log("");

for (i in object) {
    console.log(i);
    // imprime o OBJECT,  começando pelo 0 (total 5)
}
console.log("---------------------------")
console.log("FOR OF OBJECT")
console.log("");
// imprime o OBJECT,  cada linha o valor da string do objeto
for (i of object.propriedade1) {
    console.log(i);
}

console.log("---------------------------")
console.log("While")
console.log("");
var a = 0;
while (a < 10) { // so funciona enquanto a condição dele seja atendida por dentro.

    a++;
    console.log(a);
}

console.log("---------------------------")
console.log(" do While")
console.log("");
// so funciona enquanto a condição dele seja atendida por fora.

var b = 0;
do {
    b++;
    console.log(b);
} while (b < 10);