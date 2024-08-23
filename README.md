<h1 align="center">Resolução de erros da atividade da aula 03</h1>

[Lista corrigida](https://github.com/lucasns06/DS_Aula03Colecoes_ExercicioCorrigido)
### Validar nome

```csharp
 public static void ValidarNome()
        {
            Console.Write("Digite: ");
            string nome = Console.ReadLine();
            if(nome.Length <= 2)
            {
                Console.WriteLine("Erro, nome muito pequeno!!");
            }else
            {
                Console.WriteLine("Nome validado! Adicione o funcionário: ");
                AdicionarFuncionario();
            }
        }
```

Devia ter usado um loop while para permitir a repetição da entrada de dados até que as condições sejam atendidas. Isso garante que os dados inseridos pelo usuário estejam corretos antes de prosseguir.

### ValidarSalarioAdmissao

Mesma coisa do validar nome, usar o while.

O meu codigo não adiciona o funcionário, no caso deveria usar o (lista.Add(f)) se as condições forem atendidas.

**Admissão**:
- Meu código: Utiliza DateTime.Now para comparação. Isso inclui a hora atual, o que pode não ser necessário e pode resultar em erros de validação se a hora não for zero.
- Código corrigido: Utiliza DateTime.Now.Date, o que considera apenas a data sem a hora, tornando a comparação mais adequada para o contexto da validação.
