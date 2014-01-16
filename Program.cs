using System;


public static class Memory
{
    char[] memory;
}

public class FSB
{
	public FSB next;
	public uint size;
	public char[] adres;
	public char mark;
	public FSB()
	{
		next = null;
		size = 0;
		adres = null;
	}
	public FSB(uint s, Memory a)
	{
		next = null;
		size = s;
		adres = a;
	}
}
public class PCB{

}

public class Semafor
{
		public int value;
		public PCB firstWaiter;
		public Semafor()
		{
		}
		public Semafor(int v)
		{#define N 50
			this.value = v;
			firstWaiter = null;
		}
		public void Dispose()
		{
		}
}

public class ListaFSB {

		public FSB first;             
		public Semafor FSBSEM;        
		public Semafor MEMORY;
		public ListaFSB(){
			FSBSEM = new Semafor(0);
			MEMORY = new Semafor(0);
			this.first = new FSB(50, Memory.memory[);   // tworzenie pierwszego wolnego bloku pamięci
		}
		~ListaFSB(){};
}
