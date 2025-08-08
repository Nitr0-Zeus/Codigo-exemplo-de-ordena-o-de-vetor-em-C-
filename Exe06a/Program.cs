// codigo exemplo de ordenação de vetor em C#

int tamanho = 100;
int[] vetor = new int[tamanho];

// Serve para gerar números aleatórios
Random random = new();
{
    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = random.Next(1, 100);
    }
}

// Percorer o vetor com laço de repetição
for (int i = 0; i < vetor.Length - 1; i++)
{
    // -Comparar a posição atual com a próxima
    for (int j = i + 1; j < vetor.Length; j++)
    {
        // -Se a posição atual for maior que a próxima, trocar os valores de lugar
        if (vetor[i] > vetor[j])
        {
            // -Trocar os valores entre a posição atual e a próxima
            int temp = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = temp;
        }
    }
}
// Exibir o vetor ordenado
Console.WriteLine("\nVetor ordenado:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

