using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Program
    {
        static List<Sikidom> Síkidom = new List<Sikidom>();
        static void Main(string[] args)
        {
            
            Síkidom.Add(new Kor(5));
            Síkidom.Add(new Kor(4.2));
            Síkidom.Add(new Negyzet(6.2));
            Síkidom.Add(new Teglalap(3,2));
            foreach (var item in Síkidom)
            {
                if (item.GetType()==typeof(Kor))
                {
                    Kor kor = (Kor)item; //Csak így juthatunk az egyedi adathoz, a sugárhoz
                    Console.WriteLine($"A kör kerülete: {Math.Round(item.kerület(),2)} - területe: {Math.Round(item.terület(),2)} - sugara: {kor.sugár} - átmérője: {kor.Átmérő}");
                    kor.Kisebb();
                }
                else if (item.GetType()==typeof(Negyzet))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"A négyzet kerülete: {Math.Round(item.kerület(), 2)} - területe: {Math.Round(item.terület(), 2)} - oldala: {negyzet.oldal}");
                }
                else if (item.GetType()==typeof(Teglalap))
                {
                    Teglalap teglalap = (Teglalap)item;
                    Console.WriteLine($"A téglalap kerülete: {Math.Round(item.kerület(), 2)} - területe: {Math.Round(item.terület(), 2)} - A oldala: {teglalap.OldalA} - B oldala: {teglalap.OldalB}");
                }
            }
            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
    }
}
