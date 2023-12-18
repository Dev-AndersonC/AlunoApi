using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi;

public class AlunoGet
{
    public static string Template => "/aluno/{id:int}";
    public static string[] Metodo => new string[] {HttpMethod.Get.ToString()};
    public static Delegate Func => acao;


    public static IResult acao([FromRoute] int id){
        AlunoRepository alunoCarga = new AlunoRepository();
        alunoCarga.Carga();

        Aluno alunoEncotrado = AlunoRepository.BancoDeDados.FirstOrDefault(a => a.Id.Equals(id));

        if(alunoEncotrado != null) {
            return Results.Ok(alunoEncotrado);
        } else {
            return Results.NotFound( new { msg = "Não localizado ou inexistente!",
            status = HttpStatusCode.NotFound    

            });
        }

    }
}
