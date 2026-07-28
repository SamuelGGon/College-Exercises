/*
 Você está desenvolvendo uma ferramenta de cálculo geométrico para auxiliar estudantes de um curso de matemática. 
Uma das funcionalidades é representar um retângulo, permitindo calcular sua área de acordo com a altura e a largura fornecidas.

Crie uma classe chamada Retangulo que tenha:

Duas propriedades públicas: Altura e Largura.
Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).
Depois, crie um objeto da classe, atribua os valores e mostre o resultado da área na tela.
 */

using System.Reflection.Metadata.Ecma335;

class Retangulo
{
    public double Altura { get; set; }

    public double Largura { get; set; }

    public double CalcularArea() 
    {  
        return Altura * Largura; 
    }
}