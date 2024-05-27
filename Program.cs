using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia meuNokia = new Nokia("111-654-0000", "Nokia 0010", "Nokia", 17);
        Iphone meuIphone = new Iphone("222-456-0000", "iPhone 12", "Apple", 63);

        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Telegram");

        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("WhatsApp");
    }
}
