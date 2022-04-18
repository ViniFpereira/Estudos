/* ARRAY */

/* let array = ['string', 1, true];
console.log(array);
*/
/* da pra definir varios array dentro de um array 
let array = ['string', 1, true, ['array1'],
    ['array2'],
    ['array3'],
    ['array4'],
];
  console.log(array); 
  esse comando abaixo ele imprime os valores do array e o index (numero aonde está no array)
  array.forEach(function(item, index) { console.log(item, index) });
/* push adiciona um novo valor ao final do array; de  7 pra 8;
array.push('novo item');
console.log(array);

 pop remove o ultimo falor do array, ali está 8, vai ficar 7 novamente 

array.pop();
console.log(array)

 SHIFT REMOVE O PRIMEIRO VALOR DO ARRAY, de 7 PRA 6

array.shift();
console.log(array)

 UNSHIFT ADICIONA O PRIMEIRO VALOR DO ARRAY, de  6 pra 7
array.unshift("VALOR NUMERO 1 AGORA");
console.log(array)
    /* indexOf procura o valor e da o index dele
console.log(array.indexOf(true));



splice remove o index do array, 

exemplo 0 é o inicio e 3 até aonde vai , so ficaria apenas os array .
array.splice(0, 3);
console.log(array);


  pega uma parte do aray, slice = é fatia, ou seja, define um array novo com a fatia de um já existente.
let novo_array = array.slice(0, 3);
console.log(novo_array);

*/
/* OBEJTOS. */


let object = {
    string: "String",
    number: 1,
    boolean: true,
    array: ["Valor 1 do array", "Valor 2 do array"],
    objectIterno: { objectIterno: "Objeto interno" }
};
console.log(object.objectIterno);

//* desestrutaração 
var string = object.string;
console.log(string);

var { string, boolean, objectIterno } = object;
console.log(string, boolean, objectIterno);