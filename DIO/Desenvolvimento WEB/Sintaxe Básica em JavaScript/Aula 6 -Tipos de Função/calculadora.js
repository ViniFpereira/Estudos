function denovo() {

    let sim = prompt("Gostaria de calcular novamente? S / N")
    if (sim == "S" && "s" && "y" && "Y") {
        calculadora();
    }

}

function calculadora() {


    const operacao = Number(prompt("Escolha uma Operação:\n1- SOMA  +\n2- SUBTRAÇÃO -\n3 - Multiplicação *\n4 - Divisão Real /\n5 - Divisão Inteiro %\n6 - Pontenciação **   ,"));

    let n1 = Number(prompt("Insira o Primeiro Valor"));
    let n2 = Number(prompt("Insira o Segundo Valor"));
    let resultado;


    function soma() {
        resultado = n1 + n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }

    function subtracao() {
        resultado = n1 - n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }

    function multiplicacao() {
        resultado = n1 * n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }

    function divisaoInteiro() {
        resultado = n1 / n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }

    function divisaoReal() {
        resultado = n1 % n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }

    function potencializacao() {
        resultado = n1 ** n2;
        alert(n1 + " + " + n2 + " = " + resultado);

    }




    if (operacao == 1) {

        soma();

    } else if (operacao == 2) {

        subtracao();

    } else if (operacao == 3) {

        multiplicacao();


    } else if (operacao == 4) {

        divisaoInteiro();

    } else if (operacao == 5) {

        divisaoReal()

    } else if (operacao == 6) {

        potencializacao();

    }
    denovo()
}
calculadora();