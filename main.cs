using System;
using System.Threading; //per lavorare coi thread

public class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Prima di avviare i thread");
    //Istanzio la classe
    MyThread tr1 = new MyThread();

    //due metodi associati alla classe MyThread
    Thread1 t1 = new Thread1(new ThreadStart(tr1.Thread1));
    Thread1 t2 = new Thread2(new ThreadStart(tr1.Thread2));
  }
}

public class MyThread //classe che contiene i thread
{
  public static void Thread1()
  {
    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("Thread1 {0}", i);
    }
  } //i thread non hanno parametri

  public static void Thread2()
  {
    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("Thread2 {0}", i);
    }
  }
}