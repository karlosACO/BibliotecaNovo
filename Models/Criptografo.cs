using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;


namespace Biblioteca.Models
{
  public class Criptografo
  {


    public static string TextoCriptografado(string textoClaro)
   {
    
    MD5 MD5Hasher = MD5.Create();
    byte[] By = Encoding.Default.GetBytes(textoClaro);
    byte[] bytesCriptografado = MD5Hasher.ComputeHash(By);
    StringBuilder SB = new StringBuilder();
    foreach (byte b in bytesCriptografado)
    {
      string DeBugB = b.ToString("x2");
      SB.Append(DeBugB);


    }
    return SB.ToString();
    
      
   }
  }
}

