
using tpmodul4__103022300071;
using static tpmodul4__103022300071.KodePos;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kode Pos Batununggal: " + GetKodePos(Kelurahan.Batununggal));
        Console.WriteLine("Kode Pos Kujangsari: " + GetKodePos(Kelurahan.Kujangsari));
        Console.WriteLine("Kode Pos Mengger: " + GetKodePos(Kelurahan.Mengger));
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.ActivateTrigger(DoorMachine.Trigger.UNLOCK);
        doorMachine.ActivateTrigger(DoorMachine.Trigger.LOCK);
    }
}