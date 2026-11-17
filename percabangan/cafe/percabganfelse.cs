// IF SWICT CASE
// Console.WriteLine("Menu:1,2,3`");
// int menu = Convert.ToInt32(Console.ReadLine());


// switch (menu)
// {
//     case 1:
//         Console.WriteLine("Anda memilih Gacoan");
//         break;
//     case 2:
//         Console.WriteLine("anda memilih mie ayam");
//         break;
//     case 3:
//         Console.WriteLine("Anda memilih nasi padang");
//         break;
//     default:
//         Console.WriteLine("Pilihan tidak valid");
//         break;
// }

// IF NESTED
string? username ="zevian";
string? password = "1234";

Console.WriteLine("Masukkan username:");
username = Console.ReadLine();
Console.WriteLine("Masukkan password:");
password = Console.ReadLine();
if (username == "zevian")
{
    if (password == "1234")
    {
        Console.WriteLine("Login berhasil!");
    }
    else
    {
        Console.WriteLine("Password salah!!");

    }
}
else
{
    Console.WriteLine("akun tidak ditemukan");
}

// &&
// Console.Write("Masukkan username:");
// string? username = Console.ReadLine();
// Console.Write("Masukkan password:");
// string? password = Console.ReadLine();

// if (username == "king" && password == "4321") 
// {
//     Console.WriteLine("Selamat datang kembali, " + username);
// }
// else
// {
//     Console.WriteLine("penyusup jangan masuk!!");
// }