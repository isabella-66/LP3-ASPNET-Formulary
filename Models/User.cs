namespace ExemploAspNetMvc.Models;

public class UserRequest //objetos da classe representação de dados do usuário que vem na requisição
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}