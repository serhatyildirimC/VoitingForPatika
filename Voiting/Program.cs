using Business;

List<string> catagories = new List<string> { "macera", "aksiyon", "komedi", "romantik" };
Console.WriteLine("Hoşgeldiniz kullanıcı adınızı giriniz:");
string userName = Console.ReadLine();
Console.WriteLine("Şifre giriniz:");
string password = Console.ReadLine();
UserController userController = new UserController();
bool a = userController.Controller(userName, password);
int maceraCount = 0;
int aksiyonCount = 0;
int komediCount = 0;
int romantikCount = 0;

if (a== true)
{
    Console.WriteLine("giriş onaylandı hoşgeldiniz");
    Console.WriteLine("lütfen oylamaya katılın");
    for (int i = 0  ; i < catagories.Count; i++)
    {
        Console.WriteLine(catagories[i]+" için "+ i);
    }
    Console.WriteLine("oyunuz için teşekkürler.");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (b == 1) maceraCount++;
    if (b == 2) aksiyonCount++;
    if (b == 3) komediCount++;
    if (b == 4) romantikCount++;
    
}
if (a== false)
{
    Console.WriteLine("kayıt olmak için username giriniz");
    string newUserName = Console.ReadLine();
    Console.WriteLine("şifre girin");
    string newPassword = Console.ReadLine();
    bool c = userController.AddUser(newUserName, newPassword);
    if (c == true) Console.WriteLine("kayıt başarılı");
    else Console.WriteLine("kullanıcı adı kullanımda");    
}