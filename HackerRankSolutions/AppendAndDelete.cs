using System;

public class AppendAndDelete
{
public string appendAndDelete(string s, string t, int k)
    {
        int minLength = Math.Min(s.Length, t.Length);
        int ortak = 0;
        
        for (int i = 0; i < minLength; i++)
        {
            if (s[i]==t[i])
            {
                ortak++;
            }
            else
            {
                break;
            }            
        }
        int toplam = (s.Length-ortak)+(t.Length-ortak);
        if ((k>=toplam && (k-toplam)%2==0)||(k>=s.Length+t.Length))
        {
            return "Yes";            
        }
        else
        {
            return "No";
        }
    }
}