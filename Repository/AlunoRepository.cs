namespace AlunoApi;

public class AlunoRepository
{
        public static List<Aluno> BancoDeDados {get; set;} = new List<Aluno>();

        public void Carga(){
            Aluno aluno1 = new Aluno(1,"Anderson","Matriculado",10);
            Aluno aluno2 = new Aluno(2,"Peterson","Cancelado",20);
            Aluno aluno3 = new Aluno(3,"Ronald","Trancado",30);
            Aluno aluno4 = new Aluno(4,"Kefela","Matriculado",40);
            Aluno aluno5 = new Aluno(5,"Kalifa","Matriculado",50);
            Aluno aluno6 = new Aluno(6,"Brenda","Expulso",60);
            Aluno aluno7 = new Aluno(7,"Jorge","Matriculado",70);
            Aluno aluno8 = new Aluno(8,"Paulo","Matriculado",80);
            Aluno aluno9 = new Aluno(9,"Maria","Trancado",90);

            BancoDeDados.Add(aluno1);
            BancoDeDados.Add(aluno2);
            BancoDeDados.Add(aluno3);
            BancoDeDados.Add(aluno4);
            BancoDeDados.Add(aluno5);
            BancoDeDados.Add(aluno6);
            BancoDeDados.Add(aluno7);
            BancoDeDados.Add(aluno8);
            BancoDeDados.Add(aluno9);
        }
}
