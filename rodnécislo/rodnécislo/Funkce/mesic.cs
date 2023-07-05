using System;

public class kontrolaMesic
{
	public static int uMesic(int m)
	{
		if ((m >= 1) && (m <= 12))
		{	
			Console.WriteLine("Pohlaví: Můž");
			return m;
		}
		else if((m >= 51)&&(m <= 62))
		{
            Console.WriteLine("Pohlaví: Žena");
			m = m - 50;
			return m;
        }
		return 0;

	}
}
